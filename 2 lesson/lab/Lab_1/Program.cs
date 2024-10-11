
Random rand = new Random();

int[] data = new int[15];

int[] data1 = new int[8];


for (int i = 0; i < data.Length; i++)
{

    data[i] = rand.Next(1, 10);
}

foreach (int numbers in data)
{
    Console.Write(numbers + " ");
}

Console.WriteLine("\n\n");

for (int i = 0; i < data1.Length; i++)
{

    data1[i] = rand.Next(1, 10);
}

foreach (int numbers1 in data1)
{
    Console.Write(numbers1 + " ");
}

//task 1

int evenN = 0;

int oddN = 0;

int n = 0;

for(int i = 0; i < data.Length; i++)
{
    bool f = true;

    if((data[i] % 2) == 0)
    {
        evenN++;
    }
    else
    {
        oddN++;
    }


    for (int j = 0; j < i; j++)
    {
        if (data[i] == data[j])
        {
            f = false;
            break;
        }
    }

    if (f)
    {
        n++;
    }
}

Console.WriteLine("\n\n");

Console.WriteLine("N even: " + evenN);
Console.WriteLine("N odd: " + oddN);
Console.WriteLine("N Unic: " + n);



//task 2

Console.WriteLine("\n\n");

Console.WriteLine("Input number: ");

int num = int.Parse(Console.ReadLine());

for (int i = 0; i < data.Length; i++)
{
    if(data[i] < num)
    {
        Console.WriteLine(data[i]);
    }
}


//task 3

Console.WriteLine("\n\n");

Console.WriteLine("Input 1 number: ");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input 2 number: ");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("Input 3 number: ");

int c = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0;i < data.Length - 3; i++)
{
    if (data[i] == a && data[i+1] == b && data[i+2] == c)
    {
        count++;
    }
}

Console.WriteLine("\n\n");

Console.WriteLine("Count: " + count);

//task 4

Console.WriteLine("\n\n");

int size = Math.Min(data.Length, data1.Length);

int[] data3 = new int[size];

int len = 0;

for (int i = 0; i < data.Length; ++i)
{
    bool isCheck = true;
    for (int j = 0; j < data1.Length; j++)
    {
        if (data[i] == data1[j])
        {
            isCheck = true;
            break;
        }
    }

    for (int j = 0; j < len; j++)
    {
        if (data3[j] == data[i])
        {
            isCheck = false;
            break;
        }
    }

    if (isCheck)
    {
        data3[len] = data[i];
        len++;
    }
}

for (int i = 0; i < len; i++)
{
    Console.WriteLine(data3[i]);
}
