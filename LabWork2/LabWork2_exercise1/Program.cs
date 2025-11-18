namespace LabWork2_exercise1;

class Program
{
    public static void Main(string[] args)
    {
        int myFirstInt = 15;
        string myFirstString = "C#";

        Console.WriteLine("My number is {0}", myFirstInt);
        Console.WriteLine("My string variable says this: {0}", myFirstString);

        myFirstString += " Programming";
        Console.WriteLine("My string variable now says this: {0}", myFirstString);

        myFirstInt = myFirstInt * 16;
        Console.WriteLine("The number was multiplied to {0}", myFirstInt);

        myFirstInt = myFirstInt / 8;
        Console.WriteLine("The number was divided and is now {0}", myFirstInt);
    }
}
