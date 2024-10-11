namespace CSharpApplication.DataTypes
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                //sbyte a = -153;
                //sbyte a = (sbyte)-153;
                sbyte a = -100;
                Console.WriteLine(a);
                Console.WriteLine("System.SByte.MinValue {0}", SByte.MinValue);
                Console.WriteLine("System.SByte.MaxValue {0}", sbyte.MaxValue);

                byte b = 100;
                Console.WriteLine(b);
                Console.WriteLine("System.Byte.MinValue {0}", System.Byte.MinValue);
                Console.WriteLine("System.Byte.MaxValue {0}", byte.MaxValue);

                int c = -32765;
                //a = c; // неявное преобразование запрещено
                a = (sbyte)c;
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine("System.Int32.MinValue {0}", System.Int32.MinValue);
                Console.WriteLine("System.Int32.MaxValue {0}", int.MaxValue);

                uint d = 153;
                Console.WriteLine(d);
                Console.WriteLine("System.UInt32.MinValue {0}", System.UInt32.MinValue);
                Console.WriteLine("System.UInt32.MaxValue {0}", uint.MaxValue);

                Console.WriteLine("System.Int16.MinValue {0}", System.Int16.MinValue);
                Console.WriteLine("System.Int16.MaxValue {0}", short.MaxValue);
                Console.WriteLine("System.UInt16.MinValue {0}", System.UInt16.MinValue);
                Console.WriteLine("System.UInt16.MaxValue {0}", ushort.MaxValue);

                Console.WriteLine("System.Int64.MinValue {0}", System.Int64.MinValue);
                Console.WriteLine("System.Int64.MaxValue {0}", long.MaxValue);

                Console.WriteLine("System.UInt64.MinValue {0}", System.UInt64.MinValue);
                Console.WriteLine("System.UInt64.MaxValue {0}", ulong.MaxValue);

                char e = 'A';
                Console.WriteLine(e);
                Console.WriteLine("System.Char.MinValue {0}", (int)System.Char.MinValue);
                Console.WriteLine("System.Char.MaxValue {0}", (int)char.MaxValue);

                double f = 12345.6789;
                Console.WriteLine(f);
                Console.WriteLine("System.Double.MinValue {0}", System.Double.MinValue);
                Console.WriteLine("System.Double.MaxValue {0}", double.MaxValue);

                //float g = 75.535; // неявное преобразование запрещено
                float g = 75.535f;
                Console.WriteLine(g);
                Console.WriteLine("System.Single.MinValue {0}", System.Single.MinValue);
                Console.WriteLine("System.Single.MaxValue {0}", float.MaxValue);

                decimal h = 12345.6789M; //Десятичное число с фиксированной точностью 
                Console.WriteLine(h);
                Console.WriteLine("System.Decimal.MinValue {0}", System.Decimal.MinValue);
                Console.WriteLine("System.Decimal.MaxValue {0}", decimal.MaxValue);

                bool i = true;
                //bool i = 1; // неявное преобразование запрещено
                Console.WriteLine(i);
                i = false;
                Console.WriteLine(i);

                const double number = 578.7;
                string str = number.ToString();
                Console.WriteLine(str);

                Console.Write("Введите строку:");
                str = Console.ReadLine();
                double real = double.Parse(str);
                Console.WriteLine(real + 10);

                Console.Write("Введите строку:");
                str = Console.ReadLine();
                real = Convert.ToDouble(str);
                Console.WriteLine(real + 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
}

