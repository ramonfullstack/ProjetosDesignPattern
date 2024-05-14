using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        // Método de exemplo
        public void DoSomething()
        {
            Console.WriteLine("Singleton está fazendo algo...");
        }
    }
}
