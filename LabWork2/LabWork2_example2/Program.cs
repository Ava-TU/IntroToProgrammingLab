namespace LabWork2_example2;

class Program
{
    public static void Main(string[] args)
    {
        int myIntVar = 10;
        String myStringVar = "An Example String";

        Console.WriteLine("Variable 1 is {0}", myIntVar);
        Console.WriteLine("Variable 2 is {0}", myStringVar);
        myIntVar = myIntVar + 10;
        myStringVar = myStringVar + "Extended";

        Console.WriteLine("Variable 1 is {0}", myIntVar);
        Console.WriteLine("Variable 2 is {0}", myStringVar);
    }
}
