int num = int.Parse(Console.ReadLine());
int pow = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i<=pow; i+=1)
{
    result = num * i;
}
Console.WriteLine(result);