namespace SNHU_Banking;

public class BankAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl)
{
    public string Name                  { get; private set; } = name;
    public decimal Balance              { get; private set; } = balance;
    public decimal YTD                  { get; private set; }
    public AccountCategoryControl Owner { get; private set; } = accountCategoryControl;
    
    public EAccountCategory Category => Owner.Category;

    private static readonly List<string> accountNames = [];
    private decimal yield;

    public static BankAccount? CreateAccount(string name, decimal balance, AccountCategoryControl accountCategoryControl)
    {
        if (accountNames.Contains(name)) 
            return null;
        accountNames.Add(name);
        return new(name, balance, accountCategoryControl);
    }
}