using System;
using System.Linq;
using StatefulVisitor.Impl;

namespace StatefulVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine("Ultron Engine");
            var wheels = Enumerable.Range(1, 4).Select(_ => new Wheel(85.0));
            var car = new Car(24000m, engine, wheels);

            var visitor = new CarInfoVisitor();
            car.Accept(visitor);
            var info = visitor.Info;
            Console.WriteLine(info);
            Console.ReadKey();
            /*
                Price: 24000
                Engine name: Ultron Engine
                Wheel quality: 85
                Wheel quality: 85
                Wheel quality: 85
                Wheel quality: 85
             */
        }
    }

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
