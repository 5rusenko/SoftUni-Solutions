int size = int.Parse(Console.ReadLine());

for (int row = 1; row<=size; row++)
{
    for (int numStar = 1; numStar<=row; numStar+=1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}