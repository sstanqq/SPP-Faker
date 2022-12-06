using System;

namespace SPP_Faker
{
    public class Generator
    {
        public Random Random { get; }
        public Faker Faker { get; }

        public Generator(Faker faker, Random random)
        {
            Random = random;
            Faker = faker;
        }
    }
}
