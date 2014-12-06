namespace StatefulVisitor.Impl
{
    internal class Wheel : IVisitable
    {
        private readonly double _quality;

        public Wheel(double quality)
        {
            _quality = quality;
        }

        public double Quality
        {
            get { return _quality; }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}