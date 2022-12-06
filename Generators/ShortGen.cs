using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{
    public class ShortGen
    {
        private static object Generate(Type type)
        {
            var random = new Random();
            return (short)random.Next(short.MinValue, short.MaxValue);
        }

        private static bool CanGenerate(Type type)
        {
            return type == typeof(short);
        }
    }
}
