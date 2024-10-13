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
            Console.WriteLine("\n\n");

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

            Console.WriteLine("\n\n");
            //task 2

            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());



            Console.WriteLine("Введите делитель: ");
            double b = double.Parse(Console.ReadLine());


            double res = (a * b) / 100;
            Console.WriteLine("\n\n");
            Console.WriteLine(res);


            Console.WriteLine("\n\n");
            //task 3


            Console.WriteLine("Введите 1 число: ");
            char num1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число: ");
            char num2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 3 число: ");
            char num3 = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите 4 число: ");
            char num4 = char.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            Console.WriteLine(num1 + "" + num2 + "" + num3 + "" + num4);


            Console.WriteLine("\n\n");
            //task 4
            try
            {
                Console.WriteLine("Введите 6-значное число: ");
                int sixs = int.Parse(Console.ReadLine());

                if (sixs.ToString().Length != 6)
                {
                    throw new Exception("Error: введено не шестизначное число.");
                }
                else
                {
                    Console.WriteLine("Введите номера разрядов для обмена: ");

                    int pos1 = int.Parse(Console.ReadLine()) - 1;
                    int pos2 = int.Parse(Console.ReadLine()) - 1;

                    if (pos1 < 0 || pos1 >= 6 || pos2 < 0 || pos2 >= 6)
                    {
                        throw new Exception("Error: введено не существующие разряды");
                    }

                    char[] data = sixs.ToString().ToCharArray();

                    char tmp = data[pos1];
                    data[pos1] = data[pos2];
                    data[pos2] = tmp;

                    int result = int.Parse(new string(data));

                    Console.WriteLine("\n\n");

                    Console.WriteLine(result);
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n\n");

            //task 5


            Console.WriteLine("Введите дату: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            string season = "";

            if (date.Month == 12 || date.Month == 1 && date.Month == 2)
            {
                season = "Winter";
            }
            else if (date.Month >= 3 && date.Month <= 5)
            {
                season = "Spring";
            }
            else if (date.Month >= 6 && date.Month <= 8)
            {
                season = "Summer";
            }
            else if (date.Month >= 9 && date.Month <= 11)
            {
                season = "Autumn";
            }
            Console.WriteLine("\n\n");

            Console.WriteLine(season + " " + date + " " + date.DayOfWeek);

            Console.WriteLine("\n\n");

            //task 6

            Console.WriteLine("1 - ConvertToЦельсия; 2 - ConvertToФаренгейт");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введите температуру (в Фаренгейт):");
                double fahrenheit = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");

                double celsius = (fahrenheit - 32) * 5 / 9;

                Console.WriteLine(celsius);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите температуру (в Цельсия):");
                double celsius1 = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");

                double fahrenheit1 = (celsius1 * 9 / 5) + 32;

                Console.WriteLine(fahrenheit1);
            }

            Console.WriteLine("\n\n");

            //task 7

            Console.WriteLine("Введите начало диапазона: ");
            int start = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите конец диапазона: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }


            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
