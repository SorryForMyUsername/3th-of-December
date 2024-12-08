using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_14
{
    /// <summary>
    /// Задача 1. Массив предназначен для хранения значений ростов двенадцати человек. 
    /// С помощью датчика случайных чисел заполнить массив целыми значениями, 
    /// лежащими в диапазоне от 163 до 190 включительно. Вывести значения элементов 
    /// с использованием цикла for. Найти средний рост.
    /// </summary>
    internal class Program
    {
        static int[] RandomArray(int length, int min, int max)
        {
            int[] array = new int[length];
            Random rnd = new Random();

            for(int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        static void OutputArray(int[] array, string name)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static int Average(int[] array)
        {
            int sum = 0;

            foreach(int el in array)
            {
                sum += el;
            }

            return sum / array.Length;
        }

        static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int[] heights = RandomArray(12, 163, 190);
            OutputArray(heights, nameof(heights));

            int averageHeight = Average(heights);
            Output($"Средний рост: {averageHeight}");

            Console.ReadKey(true);
        }
    }
}
