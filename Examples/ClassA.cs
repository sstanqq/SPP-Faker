
namespace Examples
{
    public class ClassA
    {
        public string Ctor { get; }
        public ClassB B { get; set; }

        public int IntField { get; set; }
        public int FieldWithoutSet { get; }
        public int FieldWithPrivateSet { get; private set; }

        public int IntValue;
        public decimal DecimalValue;
        public short ShortValue;
        public string StringValue;

        public string City { get; }
        public int Age;

        private ClassA()
        {
            Ctor = "A()";
        }

        public ClassA(string city)
        {
            Ctor = "A(string)";
            City = city;
        }
    }
}
