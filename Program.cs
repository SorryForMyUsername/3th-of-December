using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_14
{
    /// <summary>
    /// Задача 2. Заполнить массив из восьми элементов следующими значениями 
    /// с использованием явной инициализации: 
    /// первый элемент массива равен 37, 
    /// второй — 0, 
    /// третий — 50, 
    /// четвертый — 46,
    /// пятый — 34, 
    /// шестой — 46, 
    /// седьмой — 0, 
    /// восьмой —13. 
    /// Найти максимальный и минимальный элементы массива.
    /// </summary>
    internal class Program
    {
        static int[] InitialArray()
        {
            return new int[] { 37, 0, 50, 46, 34, 46, 0, 13 };
        }

        static void OutputArray(int[] array, string name)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static int ArrayMax(int[] array)
        {
            int max = 0;

            foreach(int el in array)
            {
                if(el > max)
                {
                    max = el;
                }
            }

            return max;
        }

        static int ArrayMin(int[] array)
        {
            int min = 0;

            foreach (int el in array)
            {
                if (el < min)
                {
                    min = el;
                }
            }

            return min;
        }

        static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int[] omas = InitialArray();

            int max = ArrayMax(omas);
            int min = ArrayMin(omas);

            Output($"Максимальный элемент omas: {max}");
            Output($"Минимальный элемент omas: {min}");

            Console.ReadKey(true);
        }
    }
}
