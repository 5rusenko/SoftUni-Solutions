﻿int n = int.Parse(Console.ReadLine());

for (int i = 0; i<=n; i+=2)
{
    double powerOf2 = Math.Pow(2, i);
    Console.WriteLine(powerOf2);
}