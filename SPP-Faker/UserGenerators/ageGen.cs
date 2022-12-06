using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Faker.UserGenerators
{
    public class ageGen : IUserGenerator
    {
        public object Generate(Type type, Generator context)
        {
            var age = context.Random.Next(18, 60);

            return age;
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(int);
        }
    }
}
