using System;

namespace SPP_Faker
{
    public interface IGenerator
    {
        object Generate(Type type, Generator context);
        bool CanGenerate(Type type);
    }
}
