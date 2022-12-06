using System;

namespace SPP_Faker.Generators
{
    public class LongGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return context.Random.NextInt64(long.MinValue, long.MaxValue);
        }
        
        public bool CanGenerate(Type type)
        {
            return type == typeof(long);
        }
    }
}
