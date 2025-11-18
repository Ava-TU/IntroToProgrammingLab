namespace LabWork6_exercise1;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 4;
        int num2 = 6;

        int resultValue = returnFunction(num1, num2);
        Console.WriteLine("The value is: " + resultValue);

    }

    public static int returnFunction(int value1, int value2)
    {
        var functionResult = value1 * value2;
        return functionResult;
    }
}
