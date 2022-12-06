using System;
using SPP_Faker;
using SPP_Faker.UserGenerators;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakerConfig = new config();
            fakerConfig.Add<ClassA, string, NameGen>(a => a.City);
            fakerConfig.Add<ClassA, int, ageGen>(a => a.Age);

            var faker = new Faker(fakerConfig);


            var a = faker.Create<ClassA>();

            Console.WriteLine($"Constructor {a.Ctor};\nIntField: {a.IntField};\nFieldWithoutSet: {a.FieldWithoutSet};\n" +
                              $"FieldWithPrivateSet: {a.FieldWithPrivateSet};\nIntValue: {a.IntValue};\n" +
                              $"DecimalValue: {a.DecimalValue};\nShortValue: {a.ShortValue};\nStringValue: {a.StringValue};\n" +
                              $"Name: {a.City};\nAge: {a.Age};");
        }
    }
}
