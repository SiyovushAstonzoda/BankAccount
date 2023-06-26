namespace Domain.Models;
public class Account
{
    private int _accountNumber;
    private double _balance;

    public Account(int accountNumber, double balance)
    {
        this._accountNumber = accountNumber;
        this._balance = balance;
    }

    public Account(int accountNumber)
    {
        this._accountNumber= accountNumber;
    }

    public Account()
    {
        
    }

    public int GetAccountNumber { get { return _accountNumber; } }
    public double GetBalance { get { return _balance; } }

    public double SetBalance { set { _balance = value; } }
}
