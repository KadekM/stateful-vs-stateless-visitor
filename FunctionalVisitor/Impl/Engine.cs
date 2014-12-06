using System.Collections.Generic;

namespace FunctionalVisitor.Impl
{
    internal class Engine : IVisitable
    {
        private readonly string _name;

        public Engine(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public IEnumerable<T> Accept<T>(IVisitor<T> visitor)
        {
            yield return visitor.Visit(this);
        }
    }
}