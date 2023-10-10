namespace _01.SignOfIntNum_Method;
class Program
{
    static void PrintNumSign(int num)
    {
        if (num == 0)
        {
            Console.WriteLine($"The number {num} is zero.");
        }
        else if (num > 0)
        {
            Console.WriteLine($"The number {num} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {num} is negative.");
        }
    }
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        PrintNumSign(num);
    }
}

