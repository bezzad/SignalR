using System;
using Express.ObjectMapper.Bindings;
using Express.ObjectMapper.Core.DataStructures;
using Express.ObjectMapper.Reflection;

namespace Express.ObjectMapper.Mappers
{
    internal interface IMapperBuilderConfig
    {
        IDynamicAssembly Assembly { get; }
        MapperBuilder GetMapperBuilder(TypePair typePair);
        Option<BindingConfig> GetBindingConfig(TypePair typePair);
    }
}
