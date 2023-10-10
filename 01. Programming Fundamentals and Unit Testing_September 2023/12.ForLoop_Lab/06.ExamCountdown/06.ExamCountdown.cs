namespace _06.ExamCountdown;
class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        for (int currentDay=days; currentDay>0; currentDay-=1)
        {
                Console.WriteLine($"{currentDay} days before the exam");
        }
        Console.WriteLine("The exam has come");
    }
}

 