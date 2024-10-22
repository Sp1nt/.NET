using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwClass
{
    internal class Plain
    {
        private string name;
        private string manufacturer;
        private int year;
        private string type;

        public Plain()
        {
            name = "";
            manufacturer = "";
            year = 0;
            type = "";
        }

        public Plain(string name, string manufacturer, int year, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.year = year;
            this.type = type;
        }

        public void InputData()
        {
            do
            {
                Console.Write("Введите название самолета: ");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.Write("Введите название производителя: ");
                manufacturer = Console.ReadLine();
            } while (string.IsNullOrEmpty(manufacturer));
            
            do
            {
                Console.Write("Введите год выпуска: ");
                year = int.Parse(Console.ReadLine());

            } while (year.ToString().Length > 4 || year <= 0);

            do
            {
                Console.Write("Введите тип самолёта: ");
                type = Console.ReadLine();
            } while (string.IsNullOrEmpty(type));
        }

        public void DisplayData()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Название самолета: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Год выпуска: " + year);
            Console.WriteLine("Тип самолёта: " + type);
        }

        public void SetName(string value) 
        { 
            this.name = value; 
        }
        public void SetManufacturer(string value) 
        { 
            this.manufacturer = value; 
        }
        public void SetYearOfManufacture(int value)
        {
            if (year.ToString().Length > 4 || year <= 0) 
            { 
                Console.WriteLine("Неверный формат года!\n"); 
                return; 
            }

            this.year = value;
        }
        public void SetAircraftType(string value)
        {
            this.type = value;
        }
    }
}
