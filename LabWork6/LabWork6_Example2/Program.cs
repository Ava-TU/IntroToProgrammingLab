namespace LabWork6_Example2;

class Program
{
    static void Main(string[] args)
    {
        //Declare 2 variables
        int number1 = 5;
        string number2 = "This is the second parameter";
        //Passes them through in the function call
        parameterFunction(number1, number2);
    }

    //This is declaring the function called parameterFunction
    //param1 and param2 get changed into whatever variables I called in the Main function above
    public static void parameterFunction(int param1, string param2)
    {
        Console.WriteLine("Number 1: " + param1);
        Console.WriteLine();

        Console.WriteLine("Number 2: " + param2);
        Console.WriteLine();
    }
}
