using ProjetosDesignPattern.FactoryMethod.Factories;
using ProjetosDesignPattern.FactoryMethod.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.FactoryMethod
{

    public static class ExampleUsageFactoryMethod
    {
        public static void StartusingFactoryMethod()
        {
            IVehicleFactory fabricaCarro = new FactoryCar();
            var meuCarro = fabricaCarro.CreateVehicle();
            meuCarro.Mover();
            meuCarro.Acelerar();

            var fabricaMoto = new FactoryMotorcycle();
            var minhaMoto = fabricaMoto.CreateVehicle();
            minhaMoto.Mover();
            minhaMoto.Acelerar();

            Console.ReadLine();
        }
        
    }
}
