using System;
using System.Collections.Generic;
using System.Text;

namespace AppFuerGrundberechnungen
{
    // Class created for every basic calculation
    class Grundberechnungen
    {
        // Every class type is "void" and every sentence written in the console is an explanation of the respective operation
        public void Addition(double a, double b)
        {
            Console.WriteLine($"Summe: {a} plus {b} ist gleich {a + b}");
        }

        public void Substraction(double a, double b)
        {
            Console.WriteLine($"Substraktion: {a} minus {b} ist gleich {a - b}");
        }

        public void Multiplication(double a, double b)
        {
            Console.WriteLine($"Multiplikation: {a} mal {b} ist gleich {a * b}");
        }

        public void Division(double a, double b)
        {
            Console.WriteLine($"Division: {a} durch {b} ist gleich {a / b}");
        }

        public double Mult(double a, double b)
        {
           return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
