using System;

namespace SPP_Faker.Generators
{
    public class BoolGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return context.Random.Next(0, 2) == 0;
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(bool);
        }
    }
}
