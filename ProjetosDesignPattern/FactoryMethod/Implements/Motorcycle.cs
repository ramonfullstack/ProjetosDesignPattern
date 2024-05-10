using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetosDesignPattern.FactoryMethod.Implements.Base;

namespace ProjetosDesignPattern.FactoryMethod.Implements
{
    public class Motorcycle : Vehicle
    {
        public override void Mover()
        {
            Console.WriteLine("Motorcycle is moving...");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Motorcycle is acelerating...");
        }
    }
}
