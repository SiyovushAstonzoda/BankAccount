using Domain.Models;

namespace Infrastructure.Services;

public class AccountService
{
    Account _account = new Account();
    public AccountService(Account account)
    {
        _account = account;   
    }

    public AccountService()
    {
        
    }

    public string toString()
    {
        return $"Account = {_account.GetAccountNumber}, balance = ${_account.GetBalance}";
    }
    
    public void GetCredit(double amount)
    {
        _account.SetBalance = _account.GetBalance + amount;
    }
    
    public void GetDebit(double amount) 
    {
        if(_account.GetBalance >= amount) 
        {
            _account.SetBalance = _account.GetBalance - amount;
        }
        else
        {
            Console.WriteLine("Amount exceeded");
        }
    }

    public void transferTo(double amount, Account another)
    {
        if(_account.GetBalance >= amount)
        {
            _account.SetBalance = _account.GetBalance - amount;
            another.SetBalance = another.GetBalance + amount;
        }
        else
        {
            Console.WriteLine("Amount exceeded");
        }
    }
}
