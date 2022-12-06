using System;

namespace SPP_Faker.Generators
{
    public class UShortGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (ushort)context.Random.Next(ushort.MinValue, ushort.MaxValue);
        }
         public bool CanGenerate(Type type)
        {
            return type == typeof(ushort);
        }
    }
}
