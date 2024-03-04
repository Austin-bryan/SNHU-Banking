namespace SNHU_Banking;

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

        (bankAccount, nameLabel.Text, ytdLabel.Text, yieldLabel.Text) = 
            (account, account.Name, ThemePalette.FormatMoney(account.Balance), account.Yield + "%");
        bankAccount.BankAccountControl = this;
        UpdateBalance();
    }

    public void UpdateBalance()
    {
        balanceLabel.Text = ThemePalette.FormatMoney(bankAccount.Balance);
        ytdLabel.Text = ThemePalette.FormatMoney(bankAccount.YTD);
        bankAccount.Owner.UpdateTotals();
    }
    public void Deposit(decimal amount)     => bankAccount.Deposit(amount);
    public bool TryWithdraw(decimal amount) => bankAccount.TryWithdraw(amount);
    public void AddInterest(decimal amount)
    {
        bankAccount.AddInterest(amount);
        ytdLabel.Text = ThemePalette.FormatMoney(amount);
    }

    private void nameLabel_Click(object sender, EventArgs e) => (ParentForm as MainForm).SwitchPages(true, this);

}