namespace CSharpApplication.Logical_Relation_operators
{
    class Logical_Relation_operators
    {
        public static void Main()
        {
            int a = 10, b = 5, c = 7, d = 8; // &&  ||
            if (a < b && ++c <= d) //++c не выполнится, т.к. сокращенная схема
            {
                Console.WriteLine("Строка не выведется на экран!");
            }
            else
            {
                Console.WriteLine("a = {0} b = {1} c = {2} d = {3}", a, b, c, d);
            }

            if (a < b & ++c <= d) // &  |  ^
            {
                Console.WriteLine("Строка не выведется на экран!");
            }
            else
            {
                Console.WriteLine("a = {0} b = {1} c = {2} d = {3}", a, b, c, d);
            }

            if (a < b ^ --c <= d)
            {
                Console.WriteLine("a = {0} b = {1} c = {2} d = {3}", a, b, c, d);
            }
            else
            {
                Console.WriteLine("Строка не выведется на экран!");
            }

            if (a > 0)
            {
                Console.WriteLine("Значение переменной а отлично от нуля!");
            }

            /*
             // ошибка компиляции: выражание в скобках должно иметь тип bool
             if(a) 
             {
               Console.WriteLine("Значение переменной а отлично от нуля!");
             }
             
             // ошибка компиляции: к типу bool преобразования нет
            if ((bool)a)
            {
                Console.WriteLine("Значение переменной а отлично от нуля!");
            }
            */

        }
    }


}

