using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            // �������� ������� �� 10 ��������� ���� int
            // ��� �������� ������� ���������������� ������
            int[] intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0,4}", intArray[i]);
            }
            Console.WriteLine();
            
            // �������� + �������������
            int[] intArray2 = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.Write("{0,4}", intArray2[i]);
            }
            Console.WriteLine();
            
            // �������� + ������������� (����������� �������)
            int[] arr2 = { 0, 3, 7, 17, 25 };
            // ����� �������� ������ ��� �������������
            int[] arr3;
            // �� ��� ������ ������������, ���� �� �� ������ � ������� ��������� new
            /*
            arr3[0] = 0; // ������ ����������
            arr3 = {0, 3, 7, 17, 25}; // ������ ����������
            */
            arr3 = new int[] { 0, 3, 7, 17, 25 };
            arr3[0] = 10;
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0,4}", arr3[i]);
            }
            Console.WriteLine();

            // �������� ������� �� 10 ��������� ���� string
            // ��� �������� ������� ���������������� null,
            // �. �. string - ��������� ���
            string[] stringArray = new string[10];
            string[] stringArray2 = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < stringArray2.Length; i++)
            {
                Console.WriteLine(stringArray2[i]);
            }
        }
    }
}

