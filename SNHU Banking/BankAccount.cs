namespace SNHU_Banking;

public class BankAccount
{
    public string Name        { get; private set; } = "";
    public string Description { get; private set; } = "";
    public decimal Balance    { get; private set; }
    
    public AccountCategoryControl Owner { get; private set; }
    public EAccountCategory Category => Owner.Category;

    public decimal YTD { get; private set; }
    private decimal yield;

    public BankAccount(string name, decimal balance, AccountCategoryControl owner) =>
        (Name, Balance, Owner) = (name, balance, owner);
}
