
//Method 1:FindGreaterNumbe
static int FindGreaterNumber(int num1, int num2)
{
    if (num1>num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

//Method 2:FindGreaterChar

static char FindGreaterChar(char ch1, char ch2)
{
    if (ch1>ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
}

//Method 3: FindGreaterString

static string FindGreaterString(string string1, string string2)
{
    if(string1.CompareTo(string2)>0)
    {
        return string1;
    }
    else
    {
        return string2;
    }
}


string valueType = Console.ReadLine();

if (valueType=="int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterNumber(num1, num2));
}
else if (valueType=="char")
{
    char ch1 = char.Parse(Console.ReadLine());
    char ch2 = char.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterChar(ch1,ch2));
}
else if (valueType == "string")
{
    string string1 = Console.ReadLine();
    string string2 = Console.ReadLine();

    Console.WriteLine(FindGreaterString(string1, string2));
    
}

