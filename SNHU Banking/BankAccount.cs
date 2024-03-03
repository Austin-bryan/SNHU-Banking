namespace SNHU_Banking;

public class BankAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl, decimal yield)
{
    public string Name     { get; private set; } = name;
    public decimal YTD     { get; private set; }
    public decimal Balance { get; private set; } = balance;
    public decimal Yield   { get; private set; } = yield;

    public AccountCategoryControl Owner { get; private set; } = accountCategoryControl;

    private BankAccountControl _bankAccountControl;
    public BankAccountControl BankAccountControl
    {
        get => _bankAccountControl;
        set => _bankAccountControl ??= value;
    }

    public EAccountCategory Category => Owner.Category;

    public static BankAccount GetBankAccount(string name) => accountNames[name];

    private static readonly Dictionary<string, BankAccount> accountNames = [];

    public readonly List<Transaction> Transactions = [];

    public static BankAccount? CreateAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl, decimal yield)
    {
        if (accountNames.ContainsKey(name)) 
            return null;
        BankAccount bankAccount = new(name, balance, accountCategoryControl, yield);
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
        Transactions.Add(new(MainForm.CurrentDate, $"{Name} Withdrawal", -amount, Balance));
       
        return true;
    }
    public void Deposit(decimal amount)
    {
        Transactions.Add(new(MainForm.CurrentDate, $"{Name} Deposit", amount, Balance));
        Balance += amount;
    }
}