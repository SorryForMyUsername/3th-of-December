using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_14
{
    /// <summary>
    /// Задача 4. Заполнить одномерный массив случайным образом от -5 до 5 целыми числами. 
    /// Увеличить все элементы в два раза. Вывести новые значения массива 
    /// с использованием цикла foreach.
    /// </summary>
    internal class Program
    {
        static int[] RandomArray(int length, int min, int max)
        {
            int[] array = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        static void OutputArray(int[] array, string name)
        {
            foreach (int el in array)
            {
                if (el < 0)
                {
                    Console.WriteLine(el);
                }
                else
                {
                    Console.WriteLine($" {el}");
                }
            }
        }

        static void ArrayMultiply(int[] array, int multiplier)
        {
            Output($"Увеличение элементов массива в {multiplier} раза");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplier;
            }
        }

        static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int[] omas = RandomArray(10, -5, 5);
            OutputArray(omas, nameof(omas));

            ArrayMultiply(omas, 2);
            OutputArray(omas, nameof(omas));

            Console.ReadKey(true);
        }
    }
}