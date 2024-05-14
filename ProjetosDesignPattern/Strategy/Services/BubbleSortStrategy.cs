using ProjetosDesignPattern.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.Strategy.Services
{
    // Implementação do algoritmo de ordenação Bubble Sort
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Ordenando usando Bubble Sort...");
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Troca os elementos se estiverem fora de ordem
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
