using System;

namespace Express.ObjectMapper.CodeGenerators.Emitters
{
    internal interface IEmitter
    {
        void Emit(CodeGenerator generator);
    }
}
