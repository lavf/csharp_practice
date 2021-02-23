using System;

namespace Uebungsaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Übungsaufgabe");


            // for (Anfangsbedingung, Endbedingung, In- Dekrementierung

            Console.WriteLine("1) Schreiben Sie ein Programm, das die ungeraden Zahlen zwischen 1 und 50 ausgibt.");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0) // Modulo-Operator ungleich 0
                    Console.WriteLine(i);
            }


            Console.WriteLine("2) Schreiben Sie ein Programm, das die Quadrate der Zahlen zwischen 1 und 10 ausgibt.");

            for (int i = 1; i <= 10; i++) // i-- bedeutet i = i - 1
            {
                Console.WriteLine(i*i);
            }

        }
    }
}

