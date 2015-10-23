using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using Express.ObjectMapper.Core;
using Express.ObjectMapper.Core.DataStructures;

namespace Express.ObjectMapper
{
    public static partial class QuickMapper
    {

        public static TTarget Map<TTarget>(this IDataRecord source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source, for mapping nullable type use Map<TSource, TTarget> method");
            }

            var func = source.Bind<TTarget>();
            return func(source);
        }

        public static TTarget Map<TSource, TTarget>(this IDataRecord source) where TSource : IDataRecord
        {
            return source.Map<TTarget>();
        }


        public static Func<IDataRecord, TTarget> Bind<TSource, TTarget>(this IDataRecord source) where TSource : IDataRecord
        {
            return Bind<TTarget>(source);
        }

        public static Func<IDataRecord, TTarget> Bind<TTarget>(this IDataRecord source)
        {
            MethodInfo mapper = GetMapper(source, TypePair.Create<IDataRecord, TTarget>());

            var func = new Func<IDataRecord, TTarget>(record => (TTarget)mapper.Invoke(null, new object[] { record }));

            return func;
        }

        private static MethodInfo GetMapper(IDataRecord source, TypePair typePair)
        {
            MethodInfo mapper;
            if (TargetMappers.TryGetValue(typePair, out mapper) == false)
            {
                mapper = TargetMapperBuilder.Build(source, typePair.Target);
                if (typePair.Target != typeof (object))
                    TargetMappers[typePair] = mapper;
            }
            return mapper;
        }


        public static List<TTarget> MapToList<TTarget>(this IDataReader source)
        {
            List<TTarget> objectList = new List<TTarget>();

            //
            // Map many objects by the binding method's
            // 
            Func<IDataRecord, TTarget> mapper = source.Bind<TTarget>();

            while (source.Read())
            {
                objectList.Add(mapper(source));
            }

            return objectList;
        }
    }
}
