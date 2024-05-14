using ProjetosDesignPattern.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDesignPattern.Strategy
{
    // Contexto que utiliza o algoritmo de ordenação
    public class Sorter
    {
        private ISortStrategy _sortStrategy;

        public Sorter(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        // Método para alterar o algoritmo de ordenação
        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        // Método para ordenar usando o algoritmo atual
        public void Sort(int[] array)
        {
            _sortStrategy.Sort(array);
        }
    }
}
