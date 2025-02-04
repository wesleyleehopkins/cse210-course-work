using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(2,5);

        //we are validating the gets
        Console.WriteLine($"numerator " + f.GetNumerator());
        Console.WriteLine($"numerator " + f.GetDenominator());

        f.SetNumerator(7);
        f.SetDenominator(8);

        Console.WriteLine($"new numerator " + f.GetNumerator());
        Console.WriteLine($"new numerator " + f.GetDenominator());

        f.SetDenominator(0);


        Fraction f1 = new Fraction(3, 4);
        Fraction f2 = new Fraction(1, 3);

        Console.WriteLine(f1.GetFractionString()); // Expected: 3/4
        Console.WriteLine(f1.GetDecimalValue());   // Expected: 0.75

        Console.WriteLine(f2.GetFractionString()); // Expected: 1/3
        Console.WriteLine(f2.GetDecimalValue());   // Expected: 0.333...

    }




    
}


