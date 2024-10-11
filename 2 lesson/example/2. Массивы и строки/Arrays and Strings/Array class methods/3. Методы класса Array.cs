using System;

namespace CSharpApplication.methodsOfArray
{
    class MainClass
    {
        static void Main()
        {
            int[] ar = new int[10];

            Random rnd = new Random();

            Console.WriteLine("�������� ������������� ������: ");

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-20, 20);
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();

            int number, position;

            Console.WriteLine("������� ����� ��� ������: ");

            number = Convert.ToInt32(Console.ReadLine());

            position = Array.IndexOf(ar, number); // ����� ������� ��������� ����� � ������

            if (position >= 0)
                Console.WriteLine("������ ��������� ���������� ����� ������� � ������� " + position);
            else
                Console.WriteLine("������ ����� ��� � �������!");
            Console.WriteLine();

            Console.WriteLine("������� ����� ��� ������: ");

            number = Convert.ToInt32(Console.ReadLine());

            position = Array.LastIndexOf(ar, number); // ����� ���������� ��������� ����� � ������
            if (position >= 0)
                Console.WriteLine("��������� ��������� ���������� ����� ������� � ������� " + position);
            else
                Console.WriteLine("������ ����� ��� � �������!");
            Console.WriteLine();

            Console.WriteLine("������, ��������������� �� �����������: ");

            Array.Sort(ar); // ���������� �� �����������
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0,4}", ar[i]);
            }

            Console.WriteLine();

            Console.WriteLine("������� ����� ��� ������: ");

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("������� ����� ��������� � ������� �� " + Array.BinarySearch(ar, number) + " �������");
            Console.WriteLine();

            Console.WriteLine("������, ��������������� �� ��������: ");

            Array.Reverse(ar); // ���������� �� ��������

            foreach (int n in ar)
                Console.Write("{0,4}", n); // ���������� n �������� ������ ��� ������

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("�������� ������������ ������: ");

            double[] doubleArr = new double[10];

            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] = rnd.NextDouble() * 100;
                Console.Write("{0:F3}\t", doubleArr[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("������������� ������������ ������: ");

            double[] doubleArr2 = new double[10];

            Array.Copy(doubleArr, doubleArr2, doubleArr.Length);
            foreach (double n in doubleArr2)
                Console.Write("{0:F3}\t", n); // ���������� n �������� ������ ��� ������

            Console.WriteLine();
            Console.WriteLine();

            Array.Clear(doubleArr, 0, doubleArr.Length); // ��������� �������

            foreach (double n in doubleArr)
                Console.Write("{0,4}", n); // ���������� n �������� ������ ��� ������

            Console.WriteLine();

        }
    }
}

