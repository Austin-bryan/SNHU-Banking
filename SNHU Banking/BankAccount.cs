namespace SNHU_Banking;

public class BankAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl)
{
    public string Name { get; private set; } = name;
    public decimal Balance { get; private set; } = balance;
    public decimal YTD { get; private set; }
    public AccountCategoryControl Owner { get; private set; } = accountCategoryControl;

    public EAccountCategory Category => Owner.Category;

    public static BankAccount GetBankAccount (string name) => accountNames[name];

    private static readonly Dictionary<string, BankAccount> accountNames = [];
    private decimal yield;

    public static BankAccount? CreateAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl)
    {
        if (accountNames.ContainsKey(name)) 
            return null;
        BankAccount bankAccount = new(name, balance, accountCategoryControl);
        accountNames.Add(name, bankAccount);
        return bankAccount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            MessageBox.Show("Insufficient Funds", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        amount -= Balance;

    }

    public void Deposit(decimal amount)
    {
        // if (ChildSupportDue == true) {Close();}
        amount += Balance;
    }
}