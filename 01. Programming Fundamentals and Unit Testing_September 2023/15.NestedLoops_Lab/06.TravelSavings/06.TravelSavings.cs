string destination = Console.ReadLine();

while (destination!="End")
{
    double neededSum = double.Parse(Console.ReadLine());
    double collectedsum = 0;

    while (collectedsum<neededSum)
    {
        double sumtobeadded = double.Parse(Console.ReadLine());
        collectedsum += sumtobeadded;
        Console.WriteLine($"Collected: {collectedsum:f2}");
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}