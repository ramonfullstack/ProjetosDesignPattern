using ProjetosDesignPattern.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.Strategy.Services
{
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Ordenando usando Quick Sort...");
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    // Troca os elementos se estiverem fora de ordem
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            // Troca o pivô para o seu lugar correto
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
