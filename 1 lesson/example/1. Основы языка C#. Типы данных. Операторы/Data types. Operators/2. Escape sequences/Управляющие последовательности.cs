using System;

namespace CSharpApplication.escape
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Привет C#!");
            Console.WriteLine("Привет \tC#!");
            Console.WriteLine("Привет \nC#!");
            Console.WriteLine("Привет \bC#!");
            Console.WriteLine("Привет \rC#!");
            Console.WriteLine("\"Привет C#!\"");
            Console.WriteLine("\\Привет C#!\\");
            Console.WriteLine(@"\Привет 
            C#!\");   
        }
    }
}

