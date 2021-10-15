using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Часть 2. Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
             * Последовательность потенциально не ограничена, окончанием последовательности служит число 0. */
            int sum1 = 0;
            int sum2 = 1;
            int chislo;
            int i = 0;
            int r = 0;
            do
            {
                chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo > 0)
                {
                    sum1 += chislo;
                    i++;
                }
                else
                    if (chislo != 0)
                {
                    sum2 += chislo;
                    r++;
                }
            }
            while (chislo != 0);
            if (i > r)
                Console.WriteLine("Колличество положительных чисел больше колличества отрицательных: {0} >{1}", i, r);
            else if (r > i)
                Console.WriteLine("Колличество  отрицательных чисел больше колличества положительных: {0} >{1}", r, i);
            else
                Console.WriteLine("Колличество  отрицательных чисел равно  колличества положительных: {0} ={1}", r, i);
            Console.ReadKey();

        }
    }
}
