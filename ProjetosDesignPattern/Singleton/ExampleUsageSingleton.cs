using ProjetosDesignPattern.FactoryMethod.Factories.Interfaces;
using ProjetosDesignPattern.FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.Singleton
{
    public static class ExampleUsageSingleton
    {
        public static void StartusingSingleton()
        {
            Singleton singleton = Singleton.GetInstance();

            singleton.DoSomething();

            Singleton anotherSingleton = Singleton.GetInstance();
            Console.WriteLine(singleton == anotherSingleton); // Deve imprimir "True"
        }
    }
}
