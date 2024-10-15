


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

//soon

//task 3

//soon


