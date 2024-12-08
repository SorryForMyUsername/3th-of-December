using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_14
{
    /// <summary>
    /// Задача 5. В массиве хранятся сведения об оценках 25 учеников по химии. 
    /// Определить количество неуспевающих по химии учеников.
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

        static int Count(int[] array, int condition)
        {
            int count = 0;

            foreach(int el in array)
            {
                if(el == condition)
                {
                    count++;
                }
            }

            return count;
        }

        static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int[] omas = RandomArray(25, 2, 5);

            int dStudent = Count(omas, 2);
            Output($"Кол-во неуспевающих учеников: {dStudent}");

            Console.ReadKey(true);
        }
    }
}
