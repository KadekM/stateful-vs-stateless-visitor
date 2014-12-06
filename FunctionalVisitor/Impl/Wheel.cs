using System.Collections.Generic;

namespace FunctionalVisitor.Impl
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

        public IEnumerable<T> Accept<T>(IVisitor<T> visitor)
        {
            yield return visitor.Visit(this);
        }
    }
}