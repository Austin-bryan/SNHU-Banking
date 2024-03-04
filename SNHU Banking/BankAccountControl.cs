namespace SNHU_Banking;

// Purpose: This is the UI component to the BankAccount. It contains exactly one BankAccount, 
// and forwards many fields and properties. This class will display and update in real time the BankAccount fields
public partial class BankAccountControl : UserControl
{
    public decimal YTD     => bankAccount.YTD;
    public decimal Balance => bankAccount.Balance;
    public decimal Yield   => bankAccount.Yield;

    public EAccountCategory Category               => bankAccount.Category;
    public IReadOnlyList<Transaction> Transactions => bankAccount.Transactions;
    private readonly BankAccount bankAccount;

    public BankAccountControl(BankAccount account)
    {
        InitializeComponent();

        account.AddInterest(account.Balance);

        // Intialize Fields
        (bankAccount, nameLabel.Text, ytdLabel.Text, yieldLabel.Text) = 
            (account, account.Name, ThemePalette.FormatMoney(account.Balance), account.Yield + "%");
        
        bankAccount.BankAccountControl = this;
        UpdateBalance();
    }

    public void UpdateBalance()
    {
        // Update balance and YTD
        balanceLabel.Text = ThemePalette.FormatMoney(bankAccount.Balance);
        ytdLabel.Text     = ThemePalette.FormatMoney(bankAccount.YTD);
        bankAccount.Owner.UpdateAmounts();
    }
    public void Deposit(decimal amount)     => bankAccount.Deposit(amount);
    public bool TryWithdraw(decimal amount) => bankAccount.TryWithdraw(amount);
    public void AddInterest(decimal amount)
    {
        bankAccount.AddInterest(amount);
        ytdLabel.Text = ThemePalette.FormatMoney(amount);
    }
    // When the user clicks on one of the account names, open the account page
    private void nameLabel_Click(object sender, EventArgs e) => (ParentForm as MainForm).SwitchPages(true, this);

}