using System;
using Express.ObjectMapper.CodeGenerators.Emitters;
using Express.ObjectMapper.Core.DataStructures;
using Express.ObjectMapper.Core.Extensions;
using Express.ObjectMapper.Mappers.Caches;

namespace Express.ObjectMapper.Mappers.Classes.Members
{
    internal sealed class MemberEmitterDescription
    {
        public MemberEmitterDescription(IEmitter emitter, MapperCache mappers)
        {
            Emitter = emitter;
            MapperCache = new Option<MapperCache>(mappers, mappers.IsEmpty);
        }

        public IEmitter Emitter { get; private set; }
        public Option<MapperCache> MapperCache { get; private set; }

        public void AddMapper(MapperCache value)
        {
            MapperCache = value.ToOption();
        }
    }
}
