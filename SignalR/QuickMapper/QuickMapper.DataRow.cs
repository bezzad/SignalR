using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using Express.ObjectMapper.Core;
using Express.ObjectMapper.Core.DataStructures;

namespace Express.ObjectMapper
{
    public static partial class QuickMapper
    {
        /// <summary>
        ///     Maps the specified source to <see cref="TTarget" /> type.
        /// </summary>
        /// <typeparam name="TTarget">The type of the target.</typeparam>
        /// <param name="source">The DataRow source value.</param>
        /// <returns>Value</returns>
        /// <remarks>For mapping nullable type use <see cref="Map{TSource, TTarget}" />method.</remarks>
        public static TTarget Map<TTarget>(this DataRow source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source, for mapping nullable type use Map<TSource, TTarget> method");
            }

            var func = source.Bind<TTarget>();
            return func(source);
        }

        public static TTarget Map<TSource, TTarget>(this DataRow source) where TSource : DataRow
        {
            return source.Map<TTarget>();
        }

        public static Func<DataRow, TTarget> Bind<TTarget>(this DataRow source)
        {
            MethodInfo mapper = GetMapper(source, TypePair.Create<DataRow, TTarget>());

            var func = new Func<DataRow, TTarget>(record => (TTarget)mapper.Invoke(null, new object[] { record }));

            return func;
        }

        public static Func<DataRow, TTarget> Bind<TSource, TTarget>(this DataRow source) where TSource : DataRow
        {
            return Bind<TTarget>(source);
        }

        public static Func<DataRow, TTarget> Bind<TSource, TTarget>(this DataTable source) where TSource : DataTable
        {
            return Bind<TTarget>(source);
        }

        public static Func<DataRow, TTarget> Bind<TTarget>(this DataTable source)
        {
            MethodInfo mapper = GetMapper(source, TypePair.Create<DataRow, TTarget>());

            var func = new Func<DataRow, TTarget>(record => (TTarget)mapper.Invoke(null, new object[] { record }));

            return func;
        }

        public static List<TTarget> MapToList<TTarget>(this DataTable source)
        {
            //
            // Map many objects by the binding method's
            // 
            Func<DataRow, TTarget> mapper = source.Bind<TTarget>();

            return (from DataRow row in source.Rows select mapper(row)).ToList();
        }

        private static MethodInfo GetMapper(DataRow source, TypePair typePair)
        {
            MethodInfo mapper;
            if (TargetMappers.TryGetValue(typePair, out mapper) == false)
            {
                mapper = TargetMapperBuilder.Build(source, typePair.Target);
                TargetMappers[typePair] = mapper;
            }
            return mapper;
        }

        private static MethodInfo GetMapper(DataTable source, TypePair typePair)
        {
            MethodInfo mapper;
            if (TargetMappers.TryGetValue(typePair, out mapper) == false)
            {
                mapper = TargetMapperBuilder.Build(source, typePair.Target);
                TargetMappers[typePair] = mapper;
            }
            return mapper;
        }
    }
}