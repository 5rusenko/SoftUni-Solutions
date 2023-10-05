namespace _09.SumSeconds;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;
        int minutes = sum / 60;
        int seconds = sum % 60;

        string leadingZero = "";

        if(seconds<10)
        {
            leadingZero = "0";
        }

        Console.WriteLine($"{minutes}:{leadingZero}{seconds}");
    }
}

