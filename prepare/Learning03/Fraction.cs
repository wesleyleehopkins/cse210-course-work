public class Fraction
{

    private double _numerator;

    private double _denominator;

    public Fraction() 
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(double numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(double numerator, double denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public double GetNumerator()
    {
        return _numerator;
    }


    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public double GetDenominator()
    {
        return _denominator;
    }

    public double SetDenominator(double denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine("Error: Denominator cannot be zero. setting to one");
            _denominator = 1;
        }
        else
        {
            _denominator = denominator;
        }
        return _denominator;
    }


    
    public string GetFractionString()
    {

        return $"{_numerator}/{_denominator}" ;

    }

    public double GetDecimalValue()
    {
        return Math.Round((double)_numerator / _denominator, 3);
    }
}
