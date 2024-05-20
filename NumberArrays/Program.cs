using System.Diagnostics.CodeAnalysis;
using System.Globalization;

int[] number = new int[10];
Random rnd = new Random();

int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    number[i] = rnd.Next(1, number.Lenght + 1);
    sum = sum + NumberStyles[i];
}

foreach (int i in number)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");