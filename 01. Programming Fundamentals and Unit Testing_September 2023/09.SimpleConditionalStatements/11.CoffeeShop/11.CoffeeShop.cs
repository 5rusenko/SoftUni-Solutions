namespace _11.CoffeeShop;
class Program
{
    static void Main(string[] args)
    {
        string drink = Console.ReadLine();
        string extra = Console.ReadLine();
        double finalPrice = 0;

        switch(drink)
        {
            case "coffee":
                {
                    if(extra=="sugar")
                    {
                        finalPrice = 1.00 + 0.40;
                        Console.WriteLine($"Final price: ${finalPrice:f2}");
                    }
                    else if (extra =="no")
                    {
                        finalPrice = 1.00;
                        Console.WriteLine($"Final price: ${finalPrice:f2}");
                    }
                }
                break;
            case "tea":
                {
                    if (extra == "sugar")
                    {
                        finalPrice = 0.60 + 0.40;
                        Console.WriteLine($"Final price: ${finalPrice:f2}");
                    }
                    else if (extra == "no")
                    {
                        finalPrice = 0.60;
                        Console.WriteLine($"Final price: ${finalPrice:f2}");
                    }
                }
                break;

        }
    }
}

