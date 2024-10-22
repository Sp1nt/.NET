using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassHw
{
    internal class Employee
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string phNum;
        private string email;
        private string post;
        private string jobDesc;


        public void InputData()
        {
            do
            {
                Console.Write("Введите ФИО: ");
                fullName = Console.ReadLine();
            } while (!Regex.IsMatch(fullName, @"^[a-zA-Zа-яА-Я\s]+$") || string.IsNullOrEmpty(fullName));

            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth) || dateOfBirth > DateTime.Now)
            {
                Console.WriteLine("Неправильный формат даты или дата в будущем. Попробуйте снова.");
            }

            do
            {
                Console.Write("Введите контактный телефон (10 цифр): ");
                phNum = Console.ReadLine();
            } while (phNum.Length != 10 || !Regex.IsMatch(phNum, @"^\d{10}$"));

            do
            {
                Console.Write("Введите рабочий email: ");
                email = Console.ReadLine();
            } while (string.IsNullOrEmpty(email) || !email.Contains('@'));

            do
            {
                Console.Write("Введите должность: ");
                post = Console.ReadLine();
            } while (string.IsNullOrEmpty(post));

            do
            {
                Console.Write("Введите описание служебных обязанностей: ");
                jobDesc = Console.ReadLine();
            } while (string.IsNullOrEmpty(jobDesc));
        }

        public void DisplayData()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Дата рождения: " + dateOfBirth.ToShortDateString());
            Console.WriteLine("Контактный телефон: " + phNum);
            Console.WriteLine("Рабочий email: " + email);
            Console.WriteLine("Должность: " + post);
            Console.WriteLine("Описание служебных обязанностей: " + jobDesc);
        }

        public void SetFullName(string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я\s]+$") && !string.IsNullOrEmpty(value))
            {
                fullName = value;
            }
        }

        public void SetDateOfBirth(DateTime value)
        {
            if (value <= DateTime.Now)
            {
                dateOfBirth = value;
            }
        }

        public void SetContactPhone(string value)
        {
            if (value.Length == 10 && Regex.IsMatch(value, @"^\d{10}$"))
            {
                phNum = value;
            }
        }

        public void SetWorkEmail(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Contains('@'))
            {
                email = value;
            }
        }

        public void SetPosition(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                post = value;
            }
        }

        public void SetDuties(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                jobDesc = value;
            }
        }

        public string GetFullName() => fullName;
        public DateTime GetDateOfBirth() => dateOfBirth;
        public string GetContactPhone() => phNum;
        public string GetWorkEmail() => email;
        public string GetPosition() => post;
        public string GetDuties() => jobDesc;
    }
}
