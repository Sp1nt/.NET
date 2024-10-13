


//task 1
Random random = new Random();
int[] data = new int[10];


for (int i = 0; i < data.Length; i++)
{
    data[i] = random.Next(0,5);
}

foreach (int i in data)
{
    Console.Write(i);
}

Console.WriteLine("\n\n");

for (int i = 0; i < data.Length; i++)
{
    if (data[i] == 0)
    {
        data[i] = -1;
    }
}

foreach (int i in data)
{
    Console.Write(i);
}

//task 2

Console.Write("Введите размер матрицы N (нечётное число): ");
int N = int.Parse(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Введите нечётное число.");
    return;
}

int[,] matrix = new int[N, N];

int x = N / 2;
int y = N / 2;

matrix[x, y] = 1;

int value = 2;
int step = 1;

while (value <= N)
{
    for (int i = 0; i < step; i++)
    {
        matrix[--x, y] = value++;
    }

    for (int i = 0; i < step; i++)
    {
        matrix[x, --y] = value++;
    }

    step++;

    for (int i = 0; i < step; i++)
    {
        matrix[++x, y] = value++;
    }

    for (int i = 0; i < step; i++)
    {
        matrix[x, ++y] = value++;
    }

    step++;
}

Console.WriteLine("Result:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matrix[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}



//task 3


