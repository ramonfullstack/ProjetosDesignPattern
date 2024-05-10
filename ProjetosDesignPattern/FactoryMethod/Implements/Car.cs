using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetosDesignPattern.FactoryMethod.Implements.Base;

namespace ProjetosDesignPattern.FactoryMethod.Implements
{
    class Car: Vehicle
    {
        public override void Mover()
        {
            Console.WriteLine("Car is moving...");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Car is acelerating...");
        }
    }
}
