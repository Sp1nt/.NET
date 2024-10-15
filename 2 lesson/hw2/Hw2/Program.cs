


//task 1
Random random = new Random();
int[] data = new int[10];


for (int i = 0; i < data.Length; i++)
{
    data[i] = random.Next(0, 5);
}

foreach (int i in data)
{
    Console.Write(i);
}

Console.WriteLine("\n\n");

for (int i = 0; i < data.Length; i++)
{
    if (data[i] <= 0)
    {
        data[i] = -1;

        for (int j = i; j < data.Length; j++)
        {
            if (data[j] > 0)
            {
                int temp = data[j];
                data[j] = data[i];
                data[i] = temp;
                break;
            }
        }
    }
}

foreach (int i in data)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n\n");

//task 2


Console.Write("Введите размер массива (нечетное число): ");
int N = int.Parse(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Пожалуйста, введите нечетное число.");
    return;
}

int[,] data1 = new int[N, N];

int center = N / 2;
data1[center, center] = 1;

int counter = 2;
int step = 1;
int size = N * N;

int row = center;
int col = center;

while (counter < size)
{
    // вправо
    for (int i = 0; i < step; i++)
    {
        if (counter > size) break;
        col++;
        data1[row, col] = counter++;
    }

    // вверх
    for (int i = 0; i < step; i++)
    {
        if (counter > size) break;
        row--;
        data1[row, col] = counter++;
    }

    step++;

    // влево
    for (int i = 0; i < step; i++)
    {
        if (counter > size) break;
        col--;
        data1[row, col] = counter++;
    }

    // вниз
    for (int i = 0; i < step; i++)
    {
        if (counter > size) break;
        row++;
        data1[row, col] = counter++;
    }

    step++;
}

Console.WriteLine("Заполненная матрица:");
for (int i = 0; i < data1.GetLength(0); i++)
{
    for (int j = 0; j < data1.GetLength(1); j++)
    {
        Console.Write(data1[i, j] + "\t");
    }
    Console.WriteLine();
}

//task 3

//soon


