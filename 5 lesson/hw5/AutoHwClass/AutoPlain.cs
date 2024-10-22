using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHwClass
{
    internal class AutoPlain
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }

        public AutoPlain()
        {
            Name = "";
            Manufacturer = "";
            Year = 0;
            Type = "";
        }

        public AutoPlain(string name, string manufacturer, int year, string type)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
            Type = type;
        }

        public void InputData()
        {
            do
            {
                Console.Write("Введите название самолета: ");
                Name = Console.ReadLine();
            } while (string.IsNullOrEmpty(Name));

            do
            {
                Console.Write("Введите название производителя: ");
                Manufacturer = Console.ReadLine();
            } while (string.IsNullOrEmpty(Manufacturer));

            do
            {
                Console.Write("Введите год выпуска: ");
                while (!int.TryParse(Console.ReadLine(), out Year) || Year.ToString().Length != 4 || Year <= 0)
                {
                    Console.WriteLine("Неверный формат года! Попробуйте снова.");
                }
            } while (Year.ToString().Length != 4 || Year <= 0);

            do
            {
                Console.Write("Введите тип самолёта: ");
                Type = Console.ReadLine();
            } while (string.IsNullOrEmpty(Type));
        }

        public void DisplayData()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Название самолета: " + Name);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Тип самолёта: " + Type);
        }
    }
}
