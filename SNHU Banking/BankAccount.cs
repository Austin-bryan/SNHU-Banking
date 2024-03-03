namespace SNHU_Banking;

// TODO: 
// Refresh visual display of account balance totals
public class BankAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl)
{
    public string Name { get; private set; } = name;
    public decimal Balance { get; private set; } = balance;
    public decimal YTD { get; private set; }
    public AccountCategoryControl Owner { get; private set; } = accountCategoryControl;

    private BankAccountControl _bankAccountControl;
    public BankAccountControl BankAccountControl
    {
        get => _bankAccountControl; 
        set
        {
            if (_bankAccountControl == null)
                _bankAccountControl = value;
        }
    }

    public EAccountCategory Category => Owner.Category;

    public static BankAccount GetBankAccount(string name)
    {
        return accountNames[name];
    }

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

    public bool TryWithdraw(decimal amount)
    {
        if (amount > Balance)
        {
            MessageBox.Show("Insufficient Funds", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        Balance -= amount;
        
        return true;

    }

    public void Deposit(decimal amount)
    {
        // if (ChildSupportDue == true) {Close();}
        Balance += amount;
    }
}