using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_14
{
    /// <summary>
    /// Задача3. Заполнить одномерный массив с клавиатуры и вывести элементы массива 
    /// на экран в обратном порядке.
    /// </summary>
    internal class Program
    {
        static int[] InputArray(int length, string name)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{name}[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static void OutputArray(int[] array, string name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static void OutputReverseArray(int[] array, string name)
        {
            Console.WriteLine($"Массив {name} в обратном порядке: ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int[] omas = InputArray(5, "omas");
            OutputReverseArray(omas, nameof(omas));

            Console.ReadKey(true);
        }
    }
}