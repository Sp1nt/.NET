
namespace CSharpApplication.arithmetic_operations
{
    class Arithmetic_operations
    {
        public static void Main()
        {
            try
            {
                int a = 0, b = 0;
                double c = 0, d = 0;
                Console.WriteLine("Введите целое число: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите целое число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат {0}/{1}={2}", a, b, a / b);
                Console.WriteLine("Результат {0}%{1}={2}", a, b, a % b); 

                Console.WriteLine("Введите дробное число: ");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите дробное число: ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат {0}/{1}={2}", c, d, c / d);
                Console.WriteLine("Результат {0}%{1}={2}", c, d, c % d); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }


}

