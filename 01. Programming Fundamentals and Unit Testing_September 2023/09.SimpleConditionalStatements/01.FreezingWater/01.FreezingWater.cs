using System.ComponentModel;
using System.Reflection.Metadata;

namespace _01.FreezingWater;
class Program
{
    static void Main(string[] args)
    {
        /* Write a program to check for freezing water, which:
 ▪ Reads a temperature in Celsius
 ▪ Checks whether the temperature is below zero
 ▪ Prints "Freezing weather!", if the temperature is equal or
 smaller than 0, otherwise print nothing

 4 (no output)
 - 2 Freezing weather!

 
        */

        int temp = int.Parse(Console.ReadLine());

        if(temp<0)
        {
            Console.WriteLine("Freezing weather!");
        }
    }
}

