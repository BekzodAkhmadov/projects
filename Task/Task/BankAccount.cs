namespace Task;

public class BankAccount
{
    private string _accountNumber;
    public string AccountNumber
    {
        get { return _accountNumber; }
        set { _accountNumber = value; }
    }

    private string _balance;
    public string Balance
    {
        get { return _balance; }
    }

    public void Deposit(string amount) 
    {
        _balance += amount;
    }
}
