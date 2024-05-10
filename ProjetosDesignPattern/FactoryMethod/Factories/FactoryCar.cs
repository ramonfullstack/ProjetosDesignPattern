using ProjetosDesignPattern.FactoryMethod.Factories.Interfaces;
using ProjetosDesignPattern.FactoryMethod.Implements;
using ProjetosDesignPattern.FactoryMethod.Implements.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.FactoryMethod.Factories
{
    public class FactoryCar : IVehicleFactory
    {
        public Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
