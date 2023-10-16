int num = 0;

while (true)
{
    num = int.Parse(Console.ReadLine());
    if (num>=1 && num <=100)
    {
        break;
    }
}
Console.WriteLine(num);