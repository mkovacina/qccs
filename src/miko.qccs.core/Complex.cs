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
}
