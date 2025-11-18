namespace Lab5_Example2;

class Program
{
    static void Main(string[] args)
    {
        int[] numberArray = new int[10];

        Random rnd = new Random();
        for (int x = 0; x < numberArray.Length; x++)
        {
            numberArray[x] = rnd.Next(10, 100);
        }
        
        for (int y = 0; y < numberArray.Length; y++)
        {
            Console.WriteLine("The number is: " + numberArray[y]);
        }
    }
}
