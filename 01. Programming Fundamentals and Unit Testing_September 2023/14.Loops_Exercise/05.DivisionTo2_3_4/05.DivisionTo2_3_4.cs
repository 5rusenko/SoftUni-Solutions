int countNum = int.Parse(Console.ReadLine());
int count2 = 0;//числа, които се делят на 2
int count3 = 0;//числа, които се делят на 3
int count4 = 0;//числа, които се делят на 4

for (int number = 1; number <=countNum; number++)
{
    int value = int.Parse(Console.ReadLine());

    if(value %2==0)
    {
        count2++;
    }
    if (value % 3 == 0)
    {
        count3++;
    }
    if (value % 4 == 0)
    {
        count4++;
    }
}
double percent2 = count2*1.0 / countNum * 100;
double percent3 = count3*1.0 / countNum * 100;
double percent4 = count4*1.0 / countNum * 100;

Console.WriteLine($"{percent2:f2}%");
Console.WriteLine($"{percent3:f2}%");
Console.WriteLine($"{percent4:f2}%");