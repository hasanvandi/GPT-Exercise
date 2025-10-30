
namespace Exercise_05;
public class BankAccount
{
    private string AccountNumber;
    private string OwnerName;
    private decimal Balance;


    public BankAccount()
    {
        AccountNumber = "00000000";
        OwnerName = "null";
        Balance = 0;
    }


    public BankAccount(string accountNumber, string ownerName, decimal balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Deposit completed!");
        }
        else
        {
            Console.WriteLine("The amount is invalid.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            Balance -= amount;
            Console.WriteLine("The withdrawal is done!");
        }
        else if (amount < Balance)
        {
            Console.WriteLine("Insufficient inventory!");
        }
        else
        {
            Console.WriteLine("The amount is invalid.");
        }
    }
    public decimal GetBalance()
    {
        return Balance;
    }

    public void DisplayInfo()
    {
      Console.WriteLine($"AccountNumber:{AccountNumber} OwnerName:{OwnerName} Balance:{Balance}");
    }
}

