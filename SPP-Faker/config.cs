using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SPP_Faker
{
    public class config
    {
        private readonly Dictionary<Type, Dictionary<string, IUserGenerator>> _generators;

        public config()
        {
            _generators = new Dictionary<Type, Dictionary<string, IUserGenerator>>();
        }

        public void Add<TTypeName, TFieldType, TGenerator>(Expression<Func<TTypeName, TFieldType>> getField)
        {
            if (!_generators.ContainsKey(typeof(TTypeName)))
            {
                _generators.Add(typeof(TTypeName), new Dictionary<string, IUserGenerator>());
            }

            var member = getField.Body as MemberExpression ?? throw new ArgumentException("Invalid expression");
            var fieldName = member.Member.Name;
            var generator = (IUserGenerator)Activator.CreateInstance(typeof(TGenerator));

            _generators[typeof(TTypeName)].Add(fieldName, generator);
        }

        public bool HasGenerator(Type type, string fieldName)
        {
            return _generators.ContainsKey(type) && _generators[type].ContainsKey(fieldName);
        }

        public IUserGenerator GetGenerator(Type type, string fieldName)
        {
            return HasGenerator(type, fieldName) ? _generators[type][fieldName] : null;
        }
    }
}
