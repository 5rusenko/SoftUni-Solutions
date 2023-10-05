namespace _05.VacationExpenses;
class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        string accomodation = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());
        double HotelPrice = 0;
        double campingPrice = 0;

        switch (season)
        {
            case "Spring":
                if (accomodation=="Hotel")
                {
                    HotelPrice = (30 * days) * 0.8;
                    Console.WriteLine(HotelPrice.ToString("f2"));
                }
                else if (accomodation=="Camping")
                {
                    campingPrice = (10 * days) * 0.8;
                    Console.WriteLine(campingPrice.ToString("f2"));
                }
                break;
            case "Summer":
                if (accomodation == "Hotel")
                {
                    HotelPrice = 50 * days;
                    Console.WriteLine(HotelPrice.ToString("f2"));
                }
                else if (accomodation == "Camping")
                {
                    campingPrice = 30 * days;
                    Console.WriteLine(campingPrice.ToString("f2"));
                }
                break;
            case "Autumn":
                if (accomodation == "Hotel")
                {
                    HotelPrice = (20 * days) * 0.7;
                    Console.WriteLine(HotelPrice.ToString("f2"));
                }
                else if (accomodation == "Camping")
                {
                    campingPrice = (15 * days) * 0.7;
                    Console.WriteLine(campingPrice.ToString("f2"));
                }
                break;
            case "Winter":
                if (accomodation == "Hotel")
                {
                    HotelPrice = (40 * days) * 0.9;
                    Console.WriteLine(HotelPrice.ToString("f2"));
                }
                else if (accomodation == "Camping")
                {
                    campingPrice = (10 * days) * 0.9;
                    Console.WriteLine(campingPrice.ToString("f2"));
                }
                break;
        }
    }
}

