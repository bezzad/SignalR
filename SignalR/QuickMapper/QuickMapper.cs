using System;
using System.Collections.Generic;
using System.Reflection;
using Express.ObjectMapper.Bindings;
using Express.ObjectMapper.Core;
using Express.ObjectMapper.Core.DataStructures;
using Express.ObjectMapper.Core.Extensions;
using Express.ObjectMapper.Mappers;
using Express.ObjectMapper.Reflection;

namespace Express.ObjectMapper
{
    public static partial class QuickMapper
    {
        private static readonly Dictionary<TypePair, Mapper> Mappers = new Dictionary<TypePair, Mapper>();
        private static readonly TargetMapperBuilder TargetMapperBuilder;
        private static readonly Dictionary<TypePair, MethodInfo> TargetMappers = new Dictionary<TypePair, MethodInfo>();

        static QuickMapper()
        {
            IDynamicAssembly assembly = DynamicAssemblyBuilder.Get();
            TargetMapperBuilder = new TargetMapperBuilder(assembly);
        }

        public static void Bind<TSource, TTarget>()
        {
            TypePair typePair = TypePair.Create<TSource, TTarget>();

            Mappers[typePair] = TargetMapperBuilder.Build(typePair);
        }

        public static void Bind<TSource, TTarget>(Action<IBindingConfig<TSource, TTarget>> config)
        {
            TypePair typePair = TypePair.Create<TSource, TTarget>();

            var bindingConfig = new BindingConfigOf<TSource, TTarget>();
            config(bindingConfig);

            Mappers[typePair] = TargetMapperBuilder.Build(typePair, bindingConfig);
        }

        public static TTarget Map<TSource, TTarget>(this TSource source, TTarget target = default(TTarget))
        {
            TypePair typePair = TypePair.Create<TSource, TTarget>();

            Mapper mapper = GetMapper(typePair);
            var result = (TTarget)mapper.Map(source, target);

            return result;
        }

        /// <summary>
        ///     Maps the specified source to <see cref="TTarget" /> type.
        /// </summary>
        /// <typeparam name="TTarget">The type of the target.</typeparam>
        /// <param name="source">The source value.</param>
        /// <returns>Value</returns>
        /// <remarks>For mapping nullable type use <see cref="Map{TSource, TTarget}" />method.</remarks>
        public static TTarget Map<TTarget>(this object source)
        {
            if (source.IsNull())
            {
                throw Error.ArgumentNull("source, for mapping nullable type use Map<TSource, TTarget> method");
            }

            TypePair typePair = TypePair.Create(source.GetType(), typeof(TTarget));

            Mapper mapper = GetMapper(typePair);
            var result = (TTarget)mapper.Map(source);

            return result;
        }

        private static Mapper GetMapper(TypePair typePair)
        {
            Mapper mapper;
            if (Mappers.TryGetValue(typePair, out mapper) == false)
            {
                mapper = TargetMapperBuilder.Build(typePair);
                Mappers[typePair] = mapper;
            }
            return mapper;
        }

        internal static bool IsMicrosoftType(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (type.Assembly.GetName().Name.Equals("mscorlib", StringComparison.OrdinalIgnoreCase))
                return true;

            object[] atts = type.Assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true);
            if (atts.Length == 0)
                return false;

            AssemblyCompanyAttribute aca = (AssemblyCompanyAttribute)atts[0];
            return aca.Company != null && aca.Company.IndexOf("Microsoft Corporation", StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
