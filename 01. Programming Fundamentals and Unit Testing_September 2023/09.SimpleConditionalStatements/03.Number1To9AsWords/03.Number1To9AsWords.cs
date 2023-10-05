using System;

namespace _03.Number1To9AsWords;
class Program
{
    static void Main(string[] args)
    {
        /*
         * Write a program to print a number as words, which:
▪ Reads an integer and checks its value [1 … 9]
▪ Prints the value in the form of English words
▪ If the number is out of range, prints "Out of range"

7 seven
10 Out of range
2 two

        */

        int num = int.Parse(Console.ReadLine());

        if (num ==1)
        {
            Console.WriteLine("one");
        }
        else if(num ==2)
        {
            Console.WriteLine("two");
        }
        else if (num == 3)
        {
            Console.WriteLine("three");
        }
        else if (num == 4)
        {
            Console.WriteLine("four");
        }
        else if (num == 5)
        {
            Console.WriteLine("five");
        }
        else if (num == 6)
        {
            Console.WriteLine("six");
        }
        else if (num == 7)
        {
            Console.WriteLine("seven");
        }
        else if (num == 8)
        {
            Console.WriteLine("eight");
        }
        else if (num == 9)
        {
            Console.WriteLine("nine");
        }
        else if (num > 9)
        {
            Console.WriteLine("Out of range");
        }
        else if (num < 1)
        {
            Console.WriteLine("Out of range");
        }
    }
}

