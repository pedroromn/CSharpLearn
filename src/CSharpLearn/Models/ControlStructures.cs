using System;
using System.Collections.Generic;

namespace CSharpLearn
{
    class ControlStructures
    {
        public static void Calculos()
        {
            double suma = 0.0;
            double valor;
            double promedio;

            Console.WriteLine("Cálculos:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese valor: ");
                valor = double.Parse(Console.ReadLine());
                suma += valor;
            }

            Console.WriteLine($"La suma es: {suma}");
            promedio = suma / 10;
            Console.WriteLine($"El promedio es: {promedio:F2}");

        }
    }
}