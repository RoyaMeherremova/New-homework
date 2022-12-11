



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