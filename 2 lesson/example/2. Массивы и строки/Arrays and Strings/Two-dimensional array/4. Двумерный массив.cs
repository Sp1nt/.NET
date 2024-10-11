using System;

namespace CSharpApplication.two_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            // �������� ���������� ������� �� 5x5 ��������� ���� int
            // ��� �������� ������� ���������������� ������
            int[,] intArray = new int[5, 5];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // �������� + ������������� ������� 3x2
            int[,] intArray2 = new int[3, 2] { { 0, 3 }, { 7, 17 }, { 25, 0 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,4}", intArray2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // �������� + ������������� (����������� �������)
            int[, ,] intArray3 = { { { 0, 3 }, { 7, 17 } }, { { 25, 0 }, { 0, 3 } }, { { 7, 17 }, { 25, 0 } } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write("{0,4}", intArray3[i, j, k]);
                    }
                }
            }

            // ����� �������� ������ ��� �������������
            int[,] arr3;
            // �� ��� ������ ������������, ���� �� �� ������ � ������� ��������� new
            /*
            arr3[0,0] = 0; // ������ ����������
            arr3 = { {0, 3}, {7, 17}, {25, 0} }; // ������ ����������
            */

            arr3 = new int[,] { { 0, 3 }, { 7, 17 }, { 25, 0 } };
            arr3[0, 0] = 10;

        }
    }
}

