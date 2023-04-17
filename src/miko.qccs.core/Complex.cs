namespace miko.qccs.core;
public class Complex
{
    public double Real {get;}
    public double Imaginary {get;}
    public Complex(double real, double imaginary)
    {
       Real = real;
       Imaginary = imaginary; 
    }

    public static Complex Add(Complex c1, Complex c2)
    {
        double real = c1.Real+c2.Real;
        double imaginary = c1.Imaginary + c2.Imaginary;

        var result = new Complex(real,imaginary);

        return result;
    }

    public static Complex Multiply(Complex c1, Complex c2)
    {
        double real = c1.Real*c2.Real - c1.Imaginary*c2.Imaginary;
        double imaginary = c1.Real*c2.Imaginary + c1.Imaginary*c2.Real;

        var result = new Complex(real,imaginary);

        return result;
    }
}
