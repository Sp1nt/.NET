using System;

namespace CSharpApplication.visibility_scope
{
    class MainClass
    {
        public static void Main()
        {
            Visibility_scope obj = new Visibility_scope();
            obj.test();
        }
    }

    class Visibility_scope
    {
        int A = 10, B = 5;
        
        public void test()
        {
            int C;
            int A = 20;
            {
                int D;
                //int A; // недопустимо: конфликт с локальной переменной во внешнем блоке
                C = B;
                D = this.A;
                Console.WriteLine("Переменная A = " + A + "\nПоле B = " + B + "\nПеременная C = " + C + "\nПеременная D = " + D + "\nПоле A = " + this.A);
            }
            {
                int D = 20;
                Console.WriteLine("Переменная D = " + D);
                // int E; // переменная не инициализирована
                // E += 10; // ошибка компиляции
            }
        }
    }
}

