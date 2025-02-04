namespace Till;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    
    Bin myBin = new Bin("Singles", 1.00,25);

    Console.WriteLine(myBin.GetDenomination());
    Console.WriteLine(myBin.GetValue());
    Console.WriteLine(myBin.GetCount());
    }


}
