namespace _10.ComplexConditionalStatements;
class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string day = Console.ReadLine();

        switch(product)
        {
            case "Banana":
                {
                    if (day=="Weekday")
                    {
                        Console.WriteLine(2.50.ToString("F2"));
                    }
                    else if (day=="Weekend")
                    {
                        Console.WriteLine(2.70.ToString("F2"));
                    }
                }
                break;

            case "Apple":
                {
                    if (day == "Weekday")
                    {
                        Console.WriteLine(1.30.ToString("F2"));
                    }
                    else if (day == "Weekend")
                    {
                        Console.WriteLine(1.60.ToString("F2"));
                    }
                }
                break;
            case "Kiwi":
                {
                    if (day == "Weekday")
                    {
                        Console.WriteLine(2.20.ToString("F2"));
                    }
                    else if (day == "Weekend")
                    {
                        Console.WriteLine(3.00.ToString("F2"));
                    }
                }
                break;
        }
    }
}

