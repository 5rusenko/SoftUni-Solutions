﻿namespace _08.InvalidNumber;
class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        if (num >0 && num <100 || num<0)
        {
            Console.WriteLine("invalid");
        }
        else if (num>200)
        {
            Console.WriteLine("invalid");
        }
    }
}

