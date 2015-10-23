using System;
using System.Collections.Generic;
using Express.ObjectMapper.Bindings;
using Express.ObjectMapper.Core.DataStructures;
using Express.ObjectMapper.Mappers.Classes;
using Express.ObjectMapper.Mappers.Collections;
using Express.ObjectMapper.Mappers.Types.Convertible;
using Express.ObjectMapper.Reflection;

namespace Express.ObjectMapper.Mappers
{
    internal sealed partial class TargetMapperBuilder : IMapperBuilderConfig
    {
        private readonly Dictionary<TypePair, BindingConfig> _bindingConfigs = new Dictionary<TypePair, BindingConfig>();
        private readonly ClassMapperBuilder _classMapperBuilder;
        private readonly CollectionMapperBuilder _collectionMapperBuilder;
        private readonly ConvertibleTypeMapperBuilder _convertibleTypeMapperBuilder;

        public TargetMapperBuilder(IDynamicAssembly assembly)
        {
            Assembly = assembly;

            _classMapperBuilder = new ClassMapperBuilder(this);
            _collectionMapperBuilder = new CollectionMapperBuilder(this);
            _convertibleTypeMapperBuilder = new ConvertibleTypeMapperBuilder(this);
        }

        public IDynamicAssembly Assembly { get; private set; }

        public Option<BindingConfig> GetBindingConfig(TypePair typePair)
        {
            BindingConfig result;
            bool exists = _bindingConfigs.TryGetValue(typePair, out result);
            return new Option<BindingConfig>(result, exists);
        }

        public MapperBuilder GetMapperBuilder(TypePair typePair)
        {
            if (_convertibleTypeMapperBuilder.IsSupported(typePair))
            {
                return _convertibleTypeMapperBuilder;
            }
            else if (_collectionMapperBuilder.IsSupported(typePair))
            {
                return _collectionMapperBuilder;
            }
            return _classMapperBuilder;
        }

        public Mapper Build(TypePair typePair, BindingConfig bindingConfig)
        {
            _bindingConfigs[typePair] = bindingConfig;
            return Build(typePair);
        }

        public Mapper Build(TypePair typePair)
        {
            MapperBuilder mapperBuilder = GetMapperBuilder(typePair);
            Mapper mapper = mapperBuilder.Build(typePair);
            return mapper;
        }
    }
}
