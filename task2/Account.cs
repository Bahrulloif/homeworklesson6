public class Account
{
    private int _number;
    private double _balance = 0.0;


    public Account(int number)
    {
        _number = number;
    }
    public Account(int number, double balance)
    {
        _number = number;
        _balance = balance;
    }
    public int getNumber { get { return _number; } }
    public double getBalance { get { return _balance; } }

    public string toString()
    {
        return $"Account[number={_number}, balance=${_balance}]";
    }

    public void credit(double amount)
    {
        _balance += amount;
    }
    public void debit(double amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            System.Console.WriteLine("amount exceeded");
        }
    }
    public void transferTo(double amount, Account another)
    {
        if (_balance >= amount)
        {
            another._balance += amount;
        }
        else
        {
            System.Console.WriteLine("amount exceeded");
        }
    }
}