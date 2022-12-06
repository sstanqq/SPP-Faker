using System;

namespace SPP_Faker.Generators
{
    class SByteGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (sbyte)context.Random.Next(sbyte.MinValue, sbyte.MaxValue);
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(sbyte);
        }
    }
}
