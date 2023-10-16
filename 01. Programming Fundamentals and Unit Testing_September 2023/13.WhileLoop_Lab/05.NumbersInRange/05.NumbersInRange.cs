int num = int.Parse(Console.ReadLine());

bool inRange = num >= 1 && num <= 100;

while (!inRange)
{
    num = int.Parse(Console.ReadLine());
    inRange = num >= 1 && num <= 100;
}
Console.WriteLine(num);