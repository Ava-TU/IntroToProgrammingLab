namespace LabWork6_Example1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Instruction 1");
        Console.WriteLine();
        //Now I will call the function below
        simpleFunction();
        //The function will print out first before the next WriteLine line
        Console.WriteLine("Instruction 2");
    }

    public static void simpleFunction()
    {
        Console.WriteLine("Calling the function");
        Console.WriteLine(); //This just adds a space in the console to read it easier
    }
}
