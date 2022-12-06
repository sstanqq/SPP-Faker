using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Faker.Generators
{
    public class DoubleGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return (context.Random.NextDouble() - 0.5) * double.MaxValue;
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(double);
        }
    }
}
