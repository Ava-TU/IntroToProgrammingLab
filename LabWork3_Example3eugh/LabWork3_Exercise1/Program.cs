namespace LabWork3_Exercise1;

class Program
{
    static void Main(string[] args)
    {
        bool isRaining = true;
        bool isDaylight = true;

        if (!isRaining && !isDaylight)
        {
            Console.WriteLine("I'm going to sit outside!");
        }
        else if (!isRaining && isDaylight)
        {
            Console.WriteLine("It's nice out, I'm going for a walk.");
        }
        else if (isRaining && !isDaylight)
        {
            Console.WriteLine("I think I'll stay inside...");
        }
        else if (isRaining && isDaylight)
        {
            Console.WriteLine("I'll have to grab a raincoat for the day.");
        }
        else
        {
            Console.WriteLine("What did you do?");
        }
    }
}
