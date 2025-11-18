namespace LabWork6_Example4;

class Program
{
    static void Main(string[] args)
    {
        //Declare x and y values and a result variable to hold the return value
        int xValue = 10;
        int yValue = 25;

        int myFunctionResult = algebraFunction(xValue, yValue);
        //Now output the value of the result variable
        Console.WriteLine("Function return value: " + myFunctionResult);
    }

    public static int algebraFunction(int numberX, int numberY)
    {
        //Equation is (3x + 2y)
        var myEquationResult = 3 * numberX + 2 * numberY;
        //Return the result from the function
        return myEquationResult;
    }
}
