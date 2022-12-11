



using System;

Num(21);
static void Num(int n)

{
    if (n % 3 == 0 && n % 7 == 0)

    {
        Console.WriteLine("bolunur");
    }
    else
    {
        Console.WriteLine("bolunmur");
    }


}




GetevenNums(10, 50);
static void GetevenNums(int n, int m)

{
    if (n % 2 == 0 && m % 2 == 0) ;

    {
        int sum = n + m;

        Console.WriteLine(sum);
    }
}


Sum(1, 30);

static void Sum(int n, int m)
{

    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        if (i % 2 == 1)
        {
            sum += i;
        }
    }

    Console.WriteLine(sum);


}



int[] arr = { 1, 2, 3, 4, 5, 7, 8, 96 };
Sum(arr);
static void Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += i;
        }
    }
    Console.WriteLine(sum);
}



int[] arr = { 1, 3, 13, 4, 5, 7, 8, 96 };
Sum1(arr);
static void Sum1(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine(sum);
}



Count(5, 30);

static void Count(int n, int m)
{

    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        if (i % 2 == 1)
        {
            sum++;
        }
    }

    Console.WriteLine(sum);
}


Sum2(1, 5);
static void Sum2(int n, int m)
{
    int sum = 0;
    for (int i = n; i < m; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine(sum);
}

