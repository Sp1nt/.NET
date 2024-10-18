
using Lab1._1;
using System;


try
{

    Lab1._1.Math mathExpression = new Lab1._1.Math("5*2*1*4");
    Console.WriteLine("Результат: " + mathExpression.Evaluate());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}