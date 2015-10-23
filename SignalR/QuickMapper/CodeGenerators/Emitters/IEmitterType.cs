using System;

namespace Express.ObjectMapper.CodeGenerators.Emitters
{
    internal interface IEmitterType : IEmitter
    {
        Type ObjectType { get; }
    }
}
