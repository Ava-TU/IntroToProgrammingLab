using System.Runtime.CompilerServices;

namespace LabWork3_Exercise2;

class Program
{
    static void Main(string[] args)
    {
        int? val = null;
        string output = null;
        switch (val)
        {
            case 1:
                output = "A";
                break;
            case 2:
                output = "B";
                break;
            case 3:
                output = "C";
                break;
            default:
                output = "default";
                break;
        }
    }
}
