
class Hello
{
    // Точка входа в программу
    static void Main() 
    {
        // Логические литералы
        System.Console.WriteLine(true); 
        System.Console.WriteLine(false);

        // Целочисленные литералы
        System.Console.WriteLine(-7);
        System.Console.WriteLine(7);
        System.Console.WriteLine(0b111);  
        System.Console.WriteLine(0b1001);
        System.Console.WriteLine(0x1A);   
        System.Console.WriteLine(0xFF);

        // Вещественные литералы
        System.Console.WriteLine(0.92e4);   
        System.Console.WriteLine(7.2E-1);

        // Символьные литералы
        System.Console.Write('C');
        System.Console.WriteLine('#');

        // Строковые литералы
        System.Console.WriteLine("Привет, мир\n");
        System.Console.WriteLine("Hello, world\n");
    }
}