using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Faker.UserGenerators
{
    public class NameGen : IUserGenerator
    {
        private readonly string[] _names = { "Peter", "Jhon", "Jacob", "Ethan", "Michael" };

        public object Generate(Type type, Generator context)
        {
            var nameID = context.Random.Next(0, _names.Length);

            return _names[nameID];
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(string);
        }
    }
}
