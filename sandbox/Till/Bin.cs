class Bin
{
    private string _denomination;

    private double _value;
    private int _count;


    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    public void Transaction(int count)// negative for debit, possitive for credit.
    {
        _count += count;
    }

    public int GetCount()
    {
        return _count;
    }

    public double GetValue()
    {
        return _value;
    }
    public string GetDenomination()
    {
        return _denomination;
    }

// attributes private, methods public. THIS IS ALWAYS THE WAY!
// THIS VIOLATES PRIVICY
    // public void setCount(int startAmount)
    // {
    //     _count += amount;
    // }



}