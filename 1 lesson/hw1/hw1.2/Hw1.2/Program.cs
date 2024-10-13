using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1._2
{
    internal class Program
    {
        static void Main()
        {

            //task 1
            Console.WriteLine("Введите число (в диапазоне от 1 до 100): ");
            int num = int.Parse(Console.ReadLine());


            if (num < 1 || num > 100)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100.");
            }
            else
            {

                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }


            //task 2

            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());



            Console.WriteLine("Введите делитель: ");
            double b = double.Parse(Console.ReadLine());


            double res = (a * b) / 100;

            Console.WriteLine(res);



            //task 3

            
            Console.WriteLine("Введите 1 число: ");
            char num1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число: ");
            char num2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 3 число: ");
            char num3 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 4 число: ");
            char num4 = char.Parse(Console.ReadLine());

            Console.WriteLine(num1 + "" + num2 + "" + num3 + "" + num4);



            //task 4


        }
    }
}
