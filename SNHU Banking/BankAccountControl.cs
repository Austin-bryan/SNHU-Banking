namespace SNHU_Banking;

public partial class BankAccountControl : UserControl
{
    public decimal YTD     => bankAccount.YTD;
    public decimal Balance => bankAccount.Balance;

    private readonly BankAccount bankAccount;

    public BankAccountControl(BankAccount account)
    {
        InitializeComponent();

        bankAccount        = account;
        nameLabel.Text     = account.Name;
        ytdLabel.Text      = "$0";
        interestLabel.Text = "0.25%";

        bankAccount.BankAccountControl = this;
        UpdateBalance();
    }

    public void UpdateBalance() => balanceLabel.Text = string.Format("${0:#,##0.00}", bankAccount.Balance);

    private void nameLabel_Click(object sender, EventArgs e)
    {
        (ParentForm as MainForm).SwitchPages(true);
    }
}