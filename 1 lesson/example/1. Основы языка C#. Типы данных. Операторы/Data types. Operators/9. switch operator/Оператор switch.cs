
namespace CSharpApplication.operator_switch
{
    class MainClass
    {
        public static void Main()
        {
            string answer;
            do
            {
                Console.WriteLine("Введите день недели на русском языке: ");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "Понедельник":
                        Console.WriteLine("Monday");
                        break;
                    case "Вторник":
                        Console.WriteLine("Tuesday");
                        break;
                    case "Среда":
                        Console.WriteLine("Wednesday");
                        break;
                    case "Четверг":
                        Console.WriteLine("Thursday");
                        break;
                    case "Пятница":
                        Console.WriteLine("Friday");
                        break;
                    case "Суббота":
                        Console.WriteLine("Saturday");
                        break;
                    case "Воскресенье":
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Такого дня недели нет!");
                        break;
                }
                Console.WriteLine("Ещё раз? д/н");
                answer = Console.ReadLine();
              } while (answer == "д" || answer == "Д");
            
        }

    }
}

