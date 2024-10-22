using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoClassHw
{
    internal class AutoEmployee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string JobDescription { get; set; }

        public void InputData()
        {
            do
            {
                Console.Write("Введите ФИО: ");
                FullName = Console.ReadLine();
            } while (!Regex.IsMatch(FullName, @"^[a-zA-Zа-яА-Я\s]+$") || string.IsNullOrEmpty(FullName));


            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            while (!DateTime.TryParse(Console.ReadLine(), out DateOfBirth) || DateOfBirth > DateTime.Now)
            {
                Console.WriteLine("Неправильный формат даты или дата в будущем. Попробуйте снова.");
            }

            do
            {
                Console.Write("Введите контактный телефон (10 цифр): ");
                PhoneNumber = Console.ReadLine();
            } while (PhoneNumber.Length != 10 || !Regex.IsMatch(PhoneNumber, @"^\d{10}$"));

            do
            {
                Console.Write("Введите рабочий email: ");
                Email = Console.ReadLine();
            } while (string.IsNullOrEmpty(Email) || !Email.Contains('@'));

            do
            {
                Console.Write("Введите должность: ");
                Position = Console.ReadLine();
            } while (string.IsNullOrEmpty(Position));

            do
            {
                Console.Write("Введите описание служебных обязанностей: ");
                JobDescription = Console.ReadLine();
            } while (string.IsNullOrEmpty(JobDescription));
        }

        public void DisplayData()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("ФИО: " + FullName);
            Console.WriteLine("Дата рождения: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Контактный телефон: " + PhoneNumber);
            Console.WriteLine("Рабочий email: " + Email);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Описание служебных обязанностей: " + JobDescription);
        }
    }
}
