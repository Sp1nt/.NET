
namespace Interpolation_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 0;
                Console.WriteLine("Введите целое число: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите целое число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результат {a}/{b}={a / b}");
                Console.WriteLine($"Результат {a}%{b}={a % b}");

                // Форматирование строки
                var person = new { Name = "Иван", Surname = "Иванов", Age = 25 };
                string output = String.Format("Имя: {0, 5}  Фамилия: {1, 10}  Возраст: {2, 5}",
                    person.Name, person.Surname, person.Age);
                Console.WriteLine(output);

                // Интерполяция строк предлагает альтернативу форматированию строк
                output = $"Имя: {person.Name,5}  Фамилия: {person.Surname,10}  Возраст: {person.Age,5}";
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
