using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 2, 1, 6, 8, 5, 3, 4 };

            Console.WriteLine("Array original:");
            PrintArray(numbers);

            QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("Array ordenado:");
            PrintArray(numbers);

            Console.ReadLine();
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);

            return i + 1;
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
