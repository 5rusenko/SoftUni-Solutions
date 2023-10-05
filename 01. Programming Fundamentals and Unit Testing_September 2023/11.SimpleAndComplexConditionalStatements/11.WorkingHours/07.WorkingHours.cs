namespace _11.WorkingHours;
class Program
{
    static void Main(string[] args)
    {
        int workingHours = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        if (workingHours >=10 && workingHours <=18 && day=="Monday")
        {
            Console.WriteLine("open");
        }
        else if (workingHours >= 10 && workingHours <= 18 && day == "Tuesday")
        {
            Console.WriteLine("open");
        }
        else if (workingHours >= 10 && workingHours <= 18 && day == "Wednesday")
        {
            Console.WriteLine("open");
        }
        else if (workingHours >= 10 && workingHours <= 18 && day == "Thursday")
        {
            Console.WriteLine("open");
        }
        else if (workingHours >= 10 && workingHours <= 18 && day == "Friday")
        {
            Console.WriteLine("open");
        }
        else if (workingHours >= 10 && workingHours <= 18 && day == "Saturday")
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
    }
}

