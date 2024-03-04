namespace SNHU_Banking;

// Purpose: While BankAccountControl displays the bank account, this class backing data for that control. 
// It didn't make sense to me to have both the UI and the data in the same class, so they're separated. 

// I'm not sure how up to date you are with C# features, but this feature came out in November 2023, in C# 12. 
// Classes can now have parameters, called a Primary Constructor. These parameters are class-scoped fields and a constructor
// is automatically created that assigns the parameters to the backing fields. This does those 3 steps in a single step
// The constructor is public implicitily, while the created fields are private implicitly
public class BankAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl, decimal yield)
{
    private BankAccountControl _bankAccountControl;
    public BankAccountControl BankAccountControl
    {
        get => _bankAccountControl;
        set => _bankAccountControl ??= value;  
    }
    
    public string Name     { get; private set; } = name;    // I use the class parameters to initalize the public properties
    public decimal YTD     { get; private set; }
    public decimal Balance { get; private set; } = balance;
    public decimal Yield   { get; private set; } = yield;

    public AccountCategoryControl Owner { get; private set; } = accountCategoryControl;
    public EAccountCategory Category => Owner.Category;

    public readonly List<Transaction> Transactions = [];
    private static readonly Dictionary<string, BankAccount> accountNames = [];

    // ---- Methods ---- //
    // I avoid using the constructor here, because I want the option to return null in the case that the account name is taken. 
    // I am aware that a public constructor does allow the client to avoid this method, and I should enforce a private constructor,
    // but decieded it won't be a given how small the scope of the project is. 
    public static BankAccount? CreateAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl, decimal yield)
    {
        // Prevent duplicate accounts
        if (accountNames.ContainsKey(name)) 
            return null;
        BankAccount bankAccount = new(name, balance, accountCategoryControl, yield);
        accountNames.Add(name, bankAccount);
        return bankAccount;
    }
    public static BankAccount GetBankAccount(string name) => accountNames[name];
    
    // Returns a bool if withdrawal was sucessful or not
    public bool TryWithdraw(decimal amount)
    {
        if (amount > Balance)
        {
            // Since this class was supposed to avoid UI, I realize I'm breaking encaplusation by doing this Message box here. 
            // I also create multiple similar MessageBoxes to display errors, so this should be encapsulated, but given the small
            // scope of the project and the small time frame, I decieded to just copy and past, even though its WET code
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
        Transactions.Add(new Transaction(MainForm.CurrentDate, $"{Name} {label}", amount, Balance));

        if (Transactions.Count > 100)
            Transactions.RemoveAt(0);   // 0 is the oldest transaction, so remove it from the list
    }

    // I'm aware this is a simplified naive calcaluation of interest, but it's more of a UI placeholder. 
    // I thought I'd have more help from my teammates and would have the time to flesh this out
    public void AddInterest(decimal amount) => YTD += amount * Yield / 365.25m;
}