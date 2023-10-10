namespace _03.Triangle;
class Program
{
    static void PrintLine(int start, int end)
    {
        for (int i=start; i<=end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        static void PrintTriangle(int num)
        {
            for (int currentLine = 1; currentLine<=num; currentLine++)
            {
                PrintLine(1, currentLine);
            }
            for(int currentLIne =num-1; currentLIne>=1; currentLIne--)
            {
                PrintLine(1, currentLIne);
            }
        }

        int number = int.Parse(Console.ReadLine());
        PrintTriangle(number);
    }

}

