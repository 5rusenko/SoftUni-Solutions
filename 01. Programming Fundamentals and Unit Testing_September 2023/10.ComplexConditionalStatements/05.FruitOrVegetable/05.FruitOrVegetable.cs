namespace _05.FruitOrVegetable;
class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();

        //If product is one of following "banana", "apple", "kiwi", "cherry" or "lemon" you have to print "fruit"
        //If product is one of following "cucumber", "pepper" or "carrot" you have to print "vegetable

        if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon")
        {
            Console.WriteLine("fruit");
        }
        else if (product == "cucumber" || product == "pepper" || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}

