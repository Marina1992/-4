using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Часть 3. Ввести положительные числа A, B, C. 
             * 	На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
             *  Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать. */
            int i = 0;
            int r = 0;
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число В");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число С");
            int c = Convert.ToInt32(Console.ReadLine());


            while ((a - c) >= 0)
            {
                a = a - c;
                i++;
            }

            while ((b - c) >= 0)
            {
                b = b - c;
                r++;
            }

            Console.WriteLine("Колличество квадратов , размещенных на прямоугольнике равно ={0}", (i * r));


            Console.ReadKey();

        }
    }
}
