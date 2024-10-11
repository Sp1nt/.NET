
/*
    Начиная с версии C# 9, метод Main не нужно явно включать в проект консольного приложения. 
    Вместо этого можно использовать операторы верхнего уровня для минимизации объема создаваемого кода. 
    В этом случае компилятор создает класс и точку входа метода Main для приложения.
*/


Book book = new Book("CLR via C#. Программирование на платформе Microsoft .NET Framework 4.5 на языке C#.", 
                "Джеффри Рихтер");
book.Print();

class Book
{
    string Name;
    string Author;

    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }

    public void Print()
    {
        Console.WriteLine($"Название: {Name} Author: {Author}");
    }
}


