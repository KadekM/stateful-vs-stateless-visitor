using System.Collections.Generic;

namespace StatefulVisitor.Impl
{
    internal class Car : IVisitable
    {
        private readonly decimal _price;
        private readonly Engine _engine;
        private readonly IEnumerable<Wheel> _wheels;

        public Car(decimal price, Engine engine, IEnumerable<Wheel> wheels)
        {
            _engine = engine;
            _wheels = wheels;
            _price = price;
        }

        public decimal Price
        {
            get { return _price; }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            _engine.Accept(visitor);

            foreach (var wheel in _wheels)
            {
                wheel.Accept(visitor);
            }
        }
    }
}