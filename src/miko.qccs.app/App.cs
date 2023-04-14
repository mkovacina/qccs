using miko.qccs.core;

namespace miko.qccs.app;

class App
{
    static int Main(string[] args)
    {
        if (args.Length != 4 ) 
        {
            PrintHelp();
            return -1;
        }
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
        var real1 = double.Parse(args[0]);
        var imag1 = double.Parse(args[1]);
        var real2 = double.Parse(args[2]);
        var imag2 = double.Parse(args[3]);

        var c1 = new Complex(real1, imag1);
        var c2 = new Complex(real2, imag2);

        return 0;
    }

    private static void PrintHelp()
    {
        Console.WriteLine("miko.qccs.app <real1> <imaginary1> <real2> <imaginary2>");
    }
}