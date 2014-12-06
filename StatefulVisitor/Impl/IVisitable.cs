namespace StatefulVisitor.Impl
{
    internal interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}