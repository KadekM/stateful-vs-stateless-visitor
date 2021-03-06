﻿using System;
using System.Linq;
using FunctionalVisitor.Impl;

namespace FunctionalVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine("Ultron Engine");
            var wheels = Enumerable.Range(1, 4).Select(_ => new Wheel(85.0));
            var car = new Car(24000m, engine, wheels);

            var visitor = new CarInfoVisitor();
            var info = car.Accept(visitor).Aggregate((acc, s) => acc + s);
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
}
