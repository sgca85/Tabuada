﻿Console.Clear();

Console.Write("Tabuada do número: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int m = 0;
int produto;

while (m <= 10)
{
    produto = n * m;
    Console.WriteLine($"{n} x {m} = {produto}");
    m += 1;
}