namespace _01.SignOfIntNum;
class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        if (num ==0)
        {
            Console.WriteLine($"The number {num} is zero.");
        }
        else if (num >0)
        {
            Console.WriteLine($"The number {num} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {num} is negative.");
        }
    }
}

