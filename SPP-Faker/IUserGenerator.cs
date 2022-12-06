using System;

namespace SPP_Faker
{
    public interface IUserGenerator
    {
        object Generate(Type type, Generator context);
        bool CanGenerate(Type type);
    }
}
