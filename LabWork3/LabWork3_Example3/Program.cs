namespace LabWork3_Example3;

class Program
{
    static void Main(string[] args)
    {
        bool Projector = true;
        bool Class = false;

        if (!Projector && Class)
        {
            Console.WriteLine("Turn on the projector");
        }
        else if (Projector && !Class)
        {
            Console.WriteLine("Where are they...");
        }
        
    }
}
