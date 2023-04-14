using miko.qccs.core;

namespace miko.qccs.tests;

public class ComplexTests
{
    [Test]
    public void Test_Constructor()
    {
        const double realPart = 1;
        const double imaginaryPart = 2;
        var x = new Complex(realPart, imaginaryPart);
        
        Assert.That(x.Real, Is.EqualTo(realPart));
        Assert.That(x.Imaginary, Is.EqualTo(imaginaryPart));
    }
}