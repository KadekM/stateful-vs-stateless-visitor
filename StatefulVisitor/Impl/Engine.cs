namespace StatefulVisitor.Impl
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

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}