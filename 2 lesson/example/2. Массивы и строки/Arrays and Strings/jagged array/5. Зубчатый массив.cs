using System;

namespace CSharpApplication.array
{
    class MainClass
    {
        static void Main()
        {
            // �������� "���������" ������� �� 3 ���������
            int [][] intArray = new int [3][];

            for(int i = 0; i < intArray.Length; i++)
               // ������ ������� �������� ���������� ������ �� 5 ���������
               intArray[i] = new int[5];

            // �������� "���������" ���������������� ������� �� 3 ���������
            float [][] floatArray = new float [3][];

            for(int i = 0; i < floatArray.Length; i++)
               // ������ ������� �������� ���������� ������ �� i + 1 ���������
               floatArray[i] = new float[i + 1];

            // ������������� "��������" ��������

            // ������� 1
            int [][] intArray2 = new int [3][];

            intArray2[0] = new int[] {1, 2, 3, 4, 5};
            intArray2[1] = new int[] {3, 4, 5};
            intArray2[2] = new int[] {1, 2, 3, 4, 5, 6, 7};

            for(int i = 0; i < intArray2.Length; i++)
            {
                for (int j = 0; j < intArray2[i].Length; j++)
                {
                    Console.Write("{0,4}", intArray2[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // ������� 2
            int[][] intArray3 = new int[][] 
            {
               new int[] {1, 2, 3, 4, 5},
               new int[] {3, 4, 5},
               new int[] {1, 2, 3, 4, 5, 6, 7}
            };

            // ������� 3
            int[][] intArray4 = 
            {
               new int[] {1, 2, 3, 4, 5},
               new int[] {3, 4, 5},
               new int[] {1, 2, 3, 4, 5, 6, 7}
            };

            // "��������" � "�������" ������� ����� ���������
            int [][,] myMixedArray = new int [][,] 
            {
               new int[,] { {1, 2}, {3, 4} },
               new int[,] { {5, 6}, {7, 8}, {9, 10} },
               new int[,] { {11, 12} } 
            };
            
            // ������ � �������� �������
            System.Console.WriteLine(myMixedArray[0][0,0]); // ����������� 1

            // ����� �������� ������ ��� �������������
            int [][] arr3;
            // �� ��� ������ ������������, ���� �� �� ������ � ������� ��������� new

        }
    }
}

