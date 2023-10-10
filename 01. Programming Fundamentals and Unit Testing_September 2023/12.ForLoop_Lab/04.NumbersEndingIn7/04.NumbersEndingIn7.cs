namespace _04.NumbersEndingIn7;
class Program
{
    static void Main(string[] args)
    {
        int endRange = int.Parse(Console.ReadLine());

        for (int i =7;i<=endRange; i+=10)
        {
            Console.WriteLine(i);
        }
    }
}

