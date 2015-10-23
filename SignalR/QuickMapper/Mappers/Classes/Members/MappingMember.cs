using System;
using System.Reflection;
using Express.ObjectMapper.Core.DataStructures;
using Express.ObjectMapper.Core.Extensions;

namespace Express.ObjectMapper.Mappers.Classes.Members
{
    internal class MappingMember
    {
        public MappingMember(MemberInfo source, MemberInfo target)
        {
            Source = source;
            Target = target;
            TypePair = new TypePair(Source.GetMemberType(), Target.GetMemberType());
        }

        public MemberInfo Source { get; private set; }
        public MemberInfo Target { get; private set; }
        public TypePair TypePair { get; private set; }
    }
}
