using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1._1
{
    internal class Program
    {
        static void Main()
        {

            //1 task

            Console.WriteLine("It's easy to win forgiveness for being wrong;\r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup");


            Console.WriteLine("\n\n");

            //2 task


            int sum = 0;
            int max = int.MaxValue;
            int min = int.MinValue;
            int mult = 1;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Введите " + i + " число: \n");
                int num = int.Parse(Console.ReadLine());

                sum += num;
                mult *= num;

                if (num < max)
                {
                    max = num;
                }

                if (num > min)
                {
                    min = num;
                }
            }


            Console.WriteLine("\n\n");

            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + mult);
            Console.WriteLine("Максимум: " + max);
            Console.WriteLine("Минимум: " + min);

            Console.WriteLine("\n\n");

            //task 3

            try
            {
                Console.WriteLine("Введите 6-значное число: ");
                int num = int.Parse(Console.ReadLine());

                if (num.ToString().Length != 6)
                {
                    throw new Exception("Error: введено не шестизначное число.");
                }
                else
                {
                    int reversedNum = 0;

                    for (int i = 0; i < 6; i++)
                    {
                        int lastNum = num % 10;
                        reversedNum = reversedNum * 10 + lastNum;
                        num /= 10;
                    }
                    Console.WriteLine(reversedNum);
                }

                

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            //task 4

                Console.WriteLine("Введите начало диапазона: ");
                int start = int.Parse(Console.ReadLine());


                Console.WriteLine("Введите конец диапазона: ");
                int end = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n");

                int a = 0;
                int b = 1;
                while (a <= end)
                {
                    if (a >= start)
                    {
                       Console.WriteLine(a + " ");
                    }

                    int next = a + b;
                    a = b;
                    b = next;
                }

            //task 5

            Console.WriteLine("\n\n");

            Console.WriteLine("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());


            for(int i = num1; num1 < num2+1; num1++)
            {
                for (int j = 0; j < num1; j++)
                {
                    Console.Write(num1);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\n\n");
            //task 6

            Console.WriteLine("Введите длину: ");
            int lineLen = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ: ");
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите направление (1 - горизонталь, 2 - вертикаль): ");
            int choice = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineLen; i++)
            {
                if (choice == 1)
                {
                    Console.Write(choice);
                }
                else if (choice == 2)
                {
                    Console.WriteLine(choice);
                }
                else 
                {
                    Console.WriteLine("Выбор от 1 до 2");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
