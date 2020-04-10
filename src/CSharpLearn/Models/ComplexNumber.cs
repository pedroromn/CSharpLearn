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
            Imaginary = imaginary; // page 293 -  Deittel
        }

    }
}