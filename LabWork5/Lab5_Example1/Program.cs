namespace Lab5_Example1;

class Program
{
    static void Main(string[] args)
    {
        String[] weekdayArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int[] myEmptyArray = new int[4];

        myEmptyArray[0] = 10;
        myEmptyArray[1] = 20;
        myEmptyArray[2] = 30;
        myEmptyArray[3] = 40;

        //Write out what the 3 weekday is in the array
        Console.WriteLine("The week day is: {0}", weekdayArray[2]);
        Console.WriteLine();
        //Now write out the number value
        Console.WriteLine("The number is: " + myEmptyArray[1]);
    }
}
