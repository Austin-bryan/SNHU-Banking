namespace SNHU_Banking;

public class BankAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl, decimal yield)
{
    private BankAccountControl _bankAccountControl;
    public BankAccountControl BankAccountControl
    {
        get => _bankAccountControl;
        set => _bankAccountControl ??= value;
    }
    
    public string Name     { get; private set; } = name;
    public decimal YTD     { get; private set; }
    public decimal Balance { get; private set; } = balance;
    public decimal Yield   { get; private set; } = yield;
    public AccountCategoryControl Owner { get; private set; } = accountCategoryControl;
    public EAccountCategory Category => Owner.Category;

    public readonly List<Transaction> Transactions = [];
    private static readonly Dictionary<string, BankAccount> accountNames = [];

    // ---- Methods ---- //
    public static BankAccount? CreateAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl, decimal yield)
    {
        if (accountNames.ContainsKey(name)) 
            return null;
        BankAccount bankAccount = new(name, balance, accountCategoryControl, yield);
        accountNames.Add(name, bankAccount);
        return bankAccount;
    }
    public static BankAccount GetBankAccount(string name) => accountNames[name];
    
    public bool TryWithdraw(decimal amount)
    {
        if (amount > Balance)
        {
            MessageBox.Show("Insufficient Funds", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        CreateTransaction(-amount, "Withdrawal");
        return true;
    }
    public void Deposit(decimal amount) => CreateTransaction(amount, "Deposit");
    private void CreateTransaction(decimal amount, string label)
    {
        Balance += amount;
        Transactions.Add(new(MainForm.CurrentDate, $"{Name} {label}", amount, Balance));

        if (Transactions.Count > 100)
            Transactions.RemoveAt(0);
    }
}