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
        var real1 = double.Parse(args[0]);
        var imag1 = double.Parse(args[1]);
        var real2 = double.Parse(args[2]);
        var imag2 = double.Parse(args[3]);

        var c1 = new Complex(real1, imag1);
        var c2 = new Complex(real2, imag2);

        var c3 = Complex.Add(c1,c2);
        var c4 = Complex.Multiply(c1,c2);

        Console.WriteLine($"{c3.Real} + {c3.Imaginary}i");
        Console.WriteLine($"{c4.Real} + {c4.Imaginary}i");

        return 0;
    }

    private static void PrintHelp()
    {
        Console.WriteLine("miko.qccs.app <real1> <imaginary1> <real2> <imaginary2>");
    }
}