int stopNum = int.Parse(Console.ReadLine());
int prevNum = stopNum;

while (true)
{
    int inputNum = int.Parse(Console.ReadLine());
    if(inputNum==stopNum)
    {
        Console.WriteLine(prevNum*1.2);
        break;
    }


    prevNum = inputNum;
}