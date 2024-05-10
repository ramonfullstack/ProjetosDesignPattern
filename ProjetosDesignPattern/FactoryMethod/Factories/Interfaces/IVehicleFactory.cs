using ProjetosDesignPattern.FactoryMethod.Implements.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.FactoryMethod.Factories.Interfaces
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle();
    }
}
