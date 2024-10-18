using Lab7;
using System;

        try
        {
            CreditCard card = new CreditCard("1234567812345678", "Иван Иванов", "123", new DateTime(2024, 12, 23));
            Console.WriteLine("Карта успешно создана.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при создании карты: " + ex.Message);
        }
