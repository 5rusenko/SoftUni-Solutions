namespace _03.SumNumbers;
class Program
{
    static void Main(string[] args)
    {
        int countNum = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i<=countNum; i+=1)
        {
            double InputNum = double.Parse(Console.ReadLine());
            sum = sum + InputNum;
        }
        Console.WriteLine(sum);    
    }
}

