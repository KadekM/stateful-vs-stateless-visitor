using System;
using StatefulVisitor.Impl;

namespace StatefulVisitor
{
    internal class CarInfoVisitor : IVisitor
    {
        private string _info = string.Empty;

        public string Info
        {
            get { return _info; }
        }

        public void Visit(Car car)
        {
            _info = Info + String.Format("Price: {0} \n", car.Price);
        }

        public void Visit(Wheel wheel)
        {
            _info = Info + String.Format("Wheel quality: {0} \n", wheel.Quality);
        }

        public void Visit(Engine engine)
        {
            _info = Info + String.Format("Engine name: {0} \n", engine.Name);
        }
    }
}