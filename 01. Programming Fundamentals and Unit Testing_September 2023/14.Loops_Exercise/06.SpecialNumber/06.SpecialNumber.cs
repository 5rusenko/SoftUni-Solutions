int number = int.Parse(Console.ReadLine());
int startNum = number;
bool isSpecial = true;

while (number>0)
{
    int lastDigit = number % 10;

    if(startNum%lastDigit!=0)
    {
        isSpecial = false;
        break;
    }

    number /= 10;
}

if(isSpecial==true)
{
    Console.WriteLine(startNum+" is special");
}
else
{
    Console.WriteLine(startNum + " is not special");
}
