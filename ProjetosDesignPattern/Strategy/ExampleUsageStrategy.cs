using ProjetosDesignPattern.Strategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetosDesignPattern.Strategy
{
    public static class ExampleUsageStrategy
    {

        public static void GoStrategySort()
        {
            // Array de exemplo
            int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

            // Criar um objeto Sorter com BubbleSortStrategy como estratégia inicial
            Sorter sorter = new Sorter(new BubbleSortStrategy());
            sorter.Sort(array);
            PrintArray(array);

            // Mudar para QuickSortStrategy
            sorter.SetSortStrategy(new QuickSortStrategy());
            // Ordenar usando Quick Sort
            sorter.Sort(array);
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Array ordenado:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
