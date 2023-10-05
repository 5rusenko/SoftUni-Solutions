namespace _09.AreaOfFigures;
class Program
{
    static void Main(string[] args)
    {
        string figureType = Console.ReadLine();
        double area = 0;

        if (figureType == "square")
        {
            double squareSide = double.Parse(Console.ReadLine());
            area = squareSide * squareSide;
            Console.WriteLine($"{(area):f2}");
        }
        else if (figureType == "rectangle")
        {
            double rectSide1 = double.Parse(Console.ReadLine());
            double rectSide2 = double.Parse(Console.ReadLine());
            area = rectSide1 * rectSide2;
            Console.WriteLine($"{(area):f2}");
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine($"{(area):f2}");

        }
        else
        {
            Console.WriteLine("Invalid figure.");
        }
    }
}

