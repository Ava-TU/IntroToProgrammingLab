namespace LabWork6_exercise2;

class Program
{
    static void Main(string[] args)
    {
        int xValue = 10;
        int yValue = 20;
        int zValue = 30;

        int multiplyFunctionResult = multiplyFunction(xValue, yValue);
        Console.WriteLine("The result without the optional value is: " + multiplyFunctionResult);
        multiplyFunctionResult = multiplyFunction(xValue, yValue, zValue);
        Console.WriteLine("The result of the function with the optional value is: " + multiplyFunctionResult);
    }

    public static int multiplyFunction(int number1, int number2, int number3 = 2)
    {
        int equationResult = number1 * number2 / number3;
        return equationResult;
    }
}
