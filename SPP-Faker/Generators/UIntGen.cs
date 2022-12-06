using System;

namespace SPP_Faker.Generators
{
    public class UIntGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (uint)context.Random.Next();
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(uint);
        }
    }
}
