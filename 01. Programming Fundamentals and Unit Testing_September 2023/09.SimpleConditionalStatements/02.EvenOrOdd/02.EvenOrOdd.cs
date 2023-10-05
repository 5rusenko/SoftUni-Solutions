using System.ComponentModel;
using System.Security.Cryptography;

namespace _02.EvenOrOdd;
class Program
{
    static void Main(string[] args)
    {
        /* Write a program to check for odd / even number, which:
 ▪ Reads an integer
 ▪ If it's even, prints "even"
 ▪ If it's odd, prints "odd"

 4 even
 7 odd

 
        */

        int num = int.Parse(Console.ReadLine());

        if(num % 2 ==0)
        {
            Console.WriteLine("even");
        }else
        {
            Console.WriteLine("odd");
        }

    }
}
