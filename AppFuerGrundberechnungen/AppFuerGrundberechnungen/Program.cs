using System;

namespace AppFuerGrundberechnungen
{
    // Define "delegate", which is an indicator of method using the same method type 
    // established in the Class "Grundberechnungen" file and data type for each parameter
    public delegate void doubleDelegate(double a, double b);

    class Program
    {
        
        static void Main(string[] args)
        {
            // Establish each parameter [local variables]
            double a = 245.9;
            double b = 0.00000003;
            double c = 10.9;
            double d = 3.00000003;
            double e = 33.3;
            double f = 56.1111113;

            // Initialize the class as grundBe
            Grundberechnungen grundBe = new Grundberechnungen();

            // Instance the delegate as doubleDel
            doubleDelegate doubleDel = grundBe.Addition;

            //// Invoke the delegate and establish the values of the parameters
            doubleDel(a, b);
            
            Console.WriteLine("=======================================================================");

            //// Invoke the delegate and apply one or many methods of the class.
            //// "Multicast Feature" (This is only valid for the same type of method [here 'void'])
            //// ****Both methods "Multiplication" and "Addition" are called using the variables invoked at the end****
            doubleDel += grundBe.Multiplication;

            //// Invoke the delegate and establish the values of the parameters
            doubleDel(c, d);

            Console.WriteLine("=======================================================================");

            //// Invoke the delegate and apply one or many methods of the class.
            //// "Multicast Feature" (this is only valid for the same type of method [here 'void'])
            //// ****The method "Multiplication" is removed and method "Substraction" is added****
            doubleDel -= grundBe.Multiplication;
            doubleDel += grundBe.Substraction;

            //// Invoke the delegate and establish the values of the parameters
            doubleDel(e, f);

            // Conclusion: 
            // - Methods indicated by delegates persist in the programm unless it is specified that they are removed from it.
            // - Methods indicated by delegates take the variables specified AFTER them.
            // - If no parameter is specified after a delegate, the delegate is not invoked (not deployed on the console).
        }
    }
}
