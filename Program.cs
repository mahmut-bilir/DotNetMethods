// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

SayHi("Mahmut");

int number = 2;
MultiplyValueByTwo(ref number);


int result;
Sum(5, 20, out result);

WriteTotals(2, 5, 6, 8.10, 25);

void SayHi(string name)
{
    Console.WriteLine("Hi " + name + "!");
}


void MultiplyValueByTwo(ref int number)
{
    number = number * 2;
}

void Sum(int a, int b, out int result)
{

    result = a + b;
}

void WriteTotals(params int[] numbers)
{
    int total = 0;
    foreach (var number in numbers)
    {
        total += number;
    }
    Console.WriteLine("Total: " + total);
}