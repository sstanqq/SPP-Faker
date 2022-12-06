using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Faker.Generators
{
    public class IntGen : IGenerator
    {
        public object Generate(Type type, Generator context)
        {
            return context.Random.Next(int.MinValue, int.MaxValue);
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(int);
        }
    }
}
