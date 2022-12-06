using System;

namespace SPP_Faker.Generators
{
    public class FloatGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (float)((context.Random.NextSingle() - 0.5) * float.MaxValue);
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(float);
        }
    }
}
