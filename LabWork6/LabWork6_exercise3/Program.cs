namespace LabWork6_exercise3;

class Program
{
    static void Main(string[] args)
    {
        int value1 = 2;
        int value2 = 4;
        int value3 = 6;
        int value4 = 8;
        int value5 = 10;

        int functionResult = averageFunction(value1, value2, value3, value4, value5);
        Console.WriteLine("The average number is: " + functionResult);
    }

    public static int averageFunction(int num1, int num2, int num3, int num4, int num5)
    {
        int averageResult = num1 + num2 + num3 + num4 + num5 / 5;
        return averageResult;
    }
}
