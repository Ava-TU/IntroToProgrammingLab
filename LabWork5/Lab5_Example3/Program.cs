namespace Lab5_Example3;

class Program
{
    static void Main(string[] args)
    {
        object[] userDataArray = new object[7];

        userDataArray[0] = "avaWOW";
        userDataArray[1] = "passworld";
        userDataArray[2] = 1234;
        userDataArray[3] = "11/09/2001";
        userDataArray[4] = "My House";
        userDataArray[5] = "My Street";
        userDataArray[6] = -36000000;

        Console.WriteLine("User Name is: " + userDataArray[0]);
        Console.WriteLine("User password is: " + userDataArray[1]);
        Console.WriteLine("Security code is: " + userDataArray[2]);
        Console.WriteLine("Date of birth: " + userDataArray[3]);
        Console.WriteLine("Address Line 1: " + userDataArray[4]);
        Console.WriteLine("Address Line 2: " + userDataArray[5]);
        Console.WriteLine("Current Balance: " + userDataArray[6]);
    }
}
