int countNumbers = int.Parse(Console.ReadLine());
int maxNum = int.MinValue;

for (int num =1; num<=countNumbers; num++)
{
    int numValue = int.Parse(Console.ReadLine());

    if (numValue > maxNum)
    {
        maxNum = numValue;
    }
}
Console.WriteLine(maxNum);
