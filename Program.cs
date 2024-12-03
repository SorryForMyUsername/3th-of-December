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

        static void OutputArray(int[] array)
        {
            foreach(int el in array)
            {
                Console.WriteLine(el);
            }
        }

        static void Main(string[] args)
        {
            int size = Size();
            int[] array = InputArray(size);
            OutputArray(array);

            Console.ReadKey();
        }
    }
}
