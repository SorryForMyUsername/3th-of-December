using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml
{
    /// <summary>
    /// Заполнить одномерный массив и вывести его в консоли.
    /// </summary>
    internal class Program
    {
        static int Size()
        {
            Console.Write("Размер о.м.: ");
            int size;
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка!");
            }
            return size;
        }

        static int[] InputArray(int length)
        {
            int[] omas = new int[length];

            for(int i = 0; i < length; i++)
            {
                Console.Write($"omas[{i}] = ");
                omas[i] = int.Parse(Console.ReadLine());
            }

            return omas;
        }

        static int[] RandomArray(int length, int min, int max)
        {
            int[] omas = new int[length];
            Random rnd = new Random();

            for (int i = 0;i < length; i++)
            {
                omas[i] = rnd.Next(min, max);
            }

            return omas;
        }

        static int[] InitialArray()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            return array;
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

        static void OutputReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }

        static void OutputArray(int[] array)
        {
            foreach(int el in array)
            {
                Console.WriteLine(el);
            }
        }

        static void Output(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            int[] array = InitialArray();
            OutputReverseArray(array);


            Console.ReadKey(true);
        }
    }
}
