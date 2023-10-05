namespace _04.FoodOrDrink;
class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();

        //If product is one of following "curry", "noodles", "sushi", "spaghetti" or "bread" you have to print "food"
        //If product is one of following "tea", "water", "coffee" or "juice" you have to print "drink"

        if (product == "curry" || product== "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
        {
            Console.WriteLine("food");
        }
        else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
        {
            Console.WriteLine("drink");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}

