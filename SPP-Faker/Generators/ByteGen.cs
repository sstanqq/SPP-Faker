using System;

namespace SPP_Faker.Generators
{
    class ByteGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (byte)context.Random.Next(byte.MinValue, byte.MaxValue);
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(byte);
        }
    }
}
