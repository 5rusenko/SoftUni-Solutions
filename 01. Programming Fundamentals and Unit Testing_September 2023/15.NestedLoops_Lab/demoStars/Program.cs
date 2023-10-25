int countRows = int.Parse(Console.ReadLine());
int countCols = int.Parse(Console.ReadLine());

for (int row =1; row<=countRows; row++ )
{
    for (int col = 1; col<=countCols; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}