namespace _10.SummerClothing;
class Program
{
    static void Main(string[] args)
    {
        int degrees = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();
        string clothing = "", shoes = "";

        if (timeOfDay == "Morning")
        {
            if (10 <= degrees && degrees <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (18 < degrees && degrees <= 24)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (degrees >= 25)
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
        }
        else if (timeOfDay == "Afternoon")
        {
            if (10 <= degrees && degrees <= 18)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (18 < degrees && degrees <= 24)
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (degrees >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }
        }
        else if (timeOfDay == "Evening")
        {
            clothing = "Shirt";
            shoes = "Moccasins";
        }

        Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");

    }


}

