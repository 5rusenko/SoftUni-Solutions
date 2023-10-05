namespace _06.BoilingWater;
class Program
{
    static void Main(string[] args)
    {
        double temp = double.Parse(Console.ReadLine());

        if (temp >100)
        {
            Console.WriteLine("The water is boiling");
        }
        else
        {
            Console.WriteLine("The water is not hot enough");
        }
    }
}

