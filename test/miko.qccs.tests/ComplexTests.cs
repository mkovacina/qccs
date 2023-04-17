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

    [TestCase(0,0,0,0,0,0)]
    [TestCase(1,2,3,4,4,6)]
    [TestCase(-1,-2,3,4,2,2)]
    [TestCase(.1,.2,.3,.4,.4,.6)]
    public void Test_Add(double realPart1, double imaginaryPart1, double realPart2, double imaginaryPart2, double expectedRealPart, double expectedImaginaryPart)
    {
        var x1 = new Complex(realPart1, imaginaryPart1);
        var x2 = new Complex(realPart2, imaginaryPart2);

        var expected = new Complex(expectedRealPart, expectedImaginaryPart);

        var actual = Complex.Add(x1,x2);

        Assert.That(actual.Real, Is.EqualTo(expected.Real));
        Assert.That(actual.Imaginary, Is.EqualTo(expected.Imaginary).Within(1).Ulps);
    }
}