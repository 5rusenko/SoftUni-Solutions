namespace _07.LatinLetters;
class Program
{
    static void Main(string[] args)
    {
        char letter1 = char.Parse(Console.ReadLine());
        char letter2 = char.Parse(Console.ReadLine());

        for (char i = letter1; i<=letter2; i++)
        {
            Console.Write(i+" ");
        }
    }
}

