using System;
using System.Reflection;
using Express.ObjectMapper.Core.DataStructures;
using Express.ObjectMapper.Reflection;

namespace Express.ObjectMapper.Mappers
{
    internal abstract class MapperBuilder
    {
        protected const MethodAttributes OverrideProtected = MethodAttributes.Family | MethodAttributes.Virtual;
        private const string AssemblyName = "DynamicQuickMapper";
        protected readonly IDynamicAssembly _assembly;
        private readonly IMapperBuilderConfig _config;

        protected MapperBuilder(IMapperBuilderConfig config)
        {
            _config = config;
            _assembly = config.Assembly;
        }

        protected abstract string ScopeName { get; }

        public Mapper Build(TypePair typePair)
        {
            return BuildCore(typePair);
        }

        public bool IsSupported(TypePair typePair)
        {
            return IsSupportedCore(typePair);
        }

        protected abstract Mapper BuildCore(TypePair typePair);

        protected MapperBuilder GetMapperBuilder(TypePair typePair)
        {
            return _config.GetMapperBuilder(typePair);
        }

        protected string GetMapperFullName()
        {
            string random = Guid.NewGuid().ToString("N");
            return string.Format("{0}.{1}.Mapper{2}", AssemblyName, ScopeName, random);
        }

        protected abstract bool IsSupportedCore(TypePair typePair);
    }
}
