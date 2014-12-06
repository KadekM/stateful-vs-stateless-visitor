namespace StatefulVisitor.Impl
{
    internal interface IVisitor
    {
        void Visit(Car car);
        void Visit(Wheel wheel);
        void Visit(Engine engine);
    }
}