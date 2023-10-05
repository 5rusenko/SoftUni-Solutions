namespace _09.Cinema;
class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int seats = int.Parse(Console.ReadLine());
        double price = 0;

        if (type == "Premiere")
        {
            price = 12.00 * (rows * seats);
            Console.WriteLine(price.ToString("F2"));
        }
        else if (type == "Normal")
        {
            price = 7.50 * (rows * seats);
            Console.WriteLine(price.ToString("F2"));
        }
        else if (type == "Discount")
        {
            price = 5.00 * (rows * seats);
            Console.WriteLine(price.ToString("F2"));
        }
    }
    }

