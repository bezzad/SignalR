using System;
using System.Reflection.Emit;

namespace Express.ObjectMapper.CodeGenerators.Emitters
{
    internal sealed class EmitNull : IEmitterType
    {
        private EmitNull()
        {
            ObjectType = typeof(object);
        }

        public Type ObjectType { get; private set; }

        public void Emit(CodeGenerator generator)
        {
            generator.Emit(OpCodes.Ldnull);
        }

        public static IEmitterType Load()
        {
            return new EmitNull();
        }
    }
}
