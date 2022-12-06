using System;

namespace SPP_Faker.Generators
{
    public class ULongGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (ulong)context.Random.NextInt64();
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(ulong);
        }
    }
}
