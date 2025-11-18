namespace LabWork3_Example3eugh;

class Program
{
    static void Main(string[] args)
    {
        bool Projector = true;
        bool Class = true;

        if (!Projector && Class)
        {
            Console.WriteLine("Turn on the projector for the class");
        }
        else if (Projector && !Class)
        {
            Console.WriteLine("Where are they...");
        }
        else if (!Projector && !Class)
        {
            Console.WriteLine("I don't get paid enough for this");
        }
        else if (Projector && Class)
        {
            Console.WriteLine("Let's get started!");
        }
        else
        {
            Console.WriteLine("That wasn't supposed to happen...");
        }
    }
}
