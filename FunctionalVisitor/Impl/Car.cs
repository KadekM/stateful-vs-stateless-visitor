using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FunctionalVisitor.Impl
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

        public IEnumerable<T> Accept<T>(IVisitor<T> visitor)
        {
            // why yield! not in c# :(

            return new List<T> { visitor.Visit(this) }
                .Concat(_engine.Accept(visitor)
                .Concat(_wheels.SelectMany(x => x.Accept(visitor))));
        }
    }
}