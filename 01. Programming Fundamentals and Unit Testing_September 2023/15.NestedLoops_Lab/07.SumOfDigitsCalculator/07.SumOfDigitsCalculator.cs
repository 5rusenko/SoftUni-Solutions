string command = Console.ReadLine();

while(command!="End")
{
    int inputNum = int.Parse(command);
    int sum = 0;

    for (int number = inputNum; number>0; number/=10)
    {
        int digit = number % 10;
        sum += digit;
    }
    Console.WriteLine($"Sum of digits = {sum}");

    command = Console.ReadLine();
}
Console.WriteLine("Goodbye");