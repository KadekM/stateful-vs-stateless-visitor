using System;
using FunctionalVisitor.Impl;

namespace FunctionalVisitor
{
    internal class CarInfoVisitor : IVisitor<string>
    {
        public string Visit(Car car)
        {
            return String.Format("Price: {0} \n", car.Price);
        }

        public string Visit(Wheel wheel)
        {
            return String.Format("Wheel quality: {0} \n", wheel.Quality);
        }

        public string Visit(Engine engine)
        {
            return String.Format("Engine name: {0} \n", engine.Name);
        }
    }
}