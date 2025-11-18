namespace LabWork6_Example3;

class Program
{
    static void Main(string[] args)
    {
        //Declares a variable that holds the return value
        string myFunctionReturnVar = returnFunction();
        //Then this outputs the value of the variable
        Console.WriteLine("Function Return Value: " + myFunctionReturnVar);
    }

    public static string returnFunction()
    {
        //Return a value from the function
        string functionStringVar = "This string is being returned";
        return functionStringVar;
    }
}
