using System;

namespace CSharpLearn
{
    struct ComplexNumber
    {
        // read-only properties that get the real and imaginary components
        public double Real { get; }
        public double Imaginary { get; }

        // constructor
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            return $"({Real} {(Imaginary < 0 ? '-' : '+')} {Math.Abs(Imaginary)}i)";
        }

        // overload  the addition operator
        public static ComplexNumber operator+(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real, 
                x.Imaginary + y.Imaginary);
        }

        public static ComplexNumber operator-(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real,
                x.Imaginary - y.Imaginary);
        }

        public static ComplexNumber operator*(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(
                x.Real * y.Real - x.Imaginary * y.Imaginary,
                x.Real * y.Imaginary + y.Real * x.Imaginary
            );
        }

    }
}