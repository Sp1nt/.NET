
namespace CSharpApplication.format_output
{
    class MainClass
    {
        static void Main()
        {
            int number = 1234567;
            Console.WriteLine("{0:D}", number); //Decimal (десятичный)
            Console.WriteLine("{0:D4}", number); //Decimal (десятичный)
            Console.WriteLine("{0:D8}", number); //Decimal (десятичный)
            Console.WriteLine("{0:E}", number); //Exponential (экспоненциальный) 
            Console.WriteLine("{0:E4}", number); //Exponential (экспоненциальный) 
            Console.WriteLine("{0:E8}", number); //Exponential (экспоненциальный) 
            Console.WriteLine("{0:F}", number); //Fixed point (с фиксированной точкой) 
            Console.WriteLine("{0:F3}", number); //Fixed point (с фиксированной точкой) 
            Console.WriteLine("{0:N}", number); //Number (числовой)  
            Console.WriteLine("{0:N0}", number); //Number (числовой) 
            Console.WriteLine("{0:N8}", number); //Number (числовой) 
            Console.WriteLine("{0:X}", number); //Hexadecimal (шестнадцатеричный)   
            Console.WriteLine("{0:X5}", number); //Hexadecimal (шестнадцатеричный)   
            Console.WriteLine("{0:X8}", number); //Hexadecimal (шестнадцатеричный)   
            Console.WriteLine("{0,4} {1,4} {2,4}", 15, 20, 25);
            Console.WriteLine("{0:###.##} {1:#.###}", 56.3678, 345.2356);
        }
    }
}

