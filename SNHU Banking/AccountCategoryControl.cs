namespace SNHU_Banking;

public delegate void BalanceChangeHandler(decimal balance, decimal ytd);
public enum EAccountCategory { Checking, Savings, CDs };

/* Purpose: AccountCategoryControl holds all bank accounts of a certain account category.
 * It maintains the add of accounts, and updating their values. It also displays the totals from all accounts.
 */
public partial class AccountCategoryControl : UserControl
{
    public static bool AccountFormOpen { get; set; }    // The user can open a dialog to create an account. This ensures only one is open at a time.

    public decimal Total { get; private set; }
    public EAccountCategory Category { get; set; }
    public List<BankAccountControl> BankAccounts { get; private set; } = [];

    public event BalanceChangeHandler OnBalanceChange;
    private readonly BalancePreview balancePreview;

    public AccountCategoryControl()
    {
        InitializeComponent();
        balancePreview = new BalancePreview(this);  // Shows the balance amount in the pie chart
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        const int colorSide = 15;
        const int borderThickness = 1;
        base.OnPaint(e);

        // Sets the color splash based on the account category
        categoryLabel.Text      = Category.ToString().ToUpper();
        var (fore, back)        = ThemePalette.GetAccountTheme(Category);
        BackColor               = back;
        newAccountBtn.BackColor = back;
        newAccountBtn.ForeColor = fore;

        // Sets the border dynamically, allowed me to adjust the width and height
        mainPanel.Location = new(colorSide, borderThickness);
        mainPanel.Size     = new(Size.Width - borderThickness - colorSide, Size.Height - borderThickness * 2);

        ((MainForm)ParentForm).AddBalancePreview(balancePreview);
    }

    public void AddAccount(BankAccount account)
    {
        // And and show the newly created account
        BankAccountControl bac = new(account);
        BankAccounts.Add(bac);

        // The UI must be elongated to show the bank account
        int shiftAmount = (int)(bac.Height * 1.475);
        
        // Since I'm using a flow panel, all the account categories below will automatically move down
        accountsFlowPanel.Controls.Add(bac);
        accountsFlowPanel.Height += shiftAmount;
        totalPanel.Location       = new(totalPanel.Location.X, totalPanel.Location.Y + shiftAmount);
        
        Height += shiftAmount;
        UpdateAmounts();     // New account has made total and YTD out of date, update
    }
    public void UpdateAmounts()
    {
        Total = 0;
        decimal ytd = 0;

        foreach (var bankAccount in BankAccounts)
        {
            Total += bankAccount.Balance;
            ytd   += bankAccount.YTD;
        }

        totalLabel.Text = ThemePalette.FormatMoney(Total);
        ytdLabel.Text   = ThemePalette.FormatMoney(ytd);

        OnBalanceChange(Total, ytd);
    }
    private void newAccountBtn_Click(object sender, EventArgs e)
    {
        // Ensures only one window is open at a time
        if (AccountFormOpen)        
            return;
        AccountFormOpen = true;

        // Open new window
        NewAccountForm nac = new(this)
        {
            Owner = (MainForm)Parent.Parent
        };
        nac.Show();
        nac.Select(Category);
    }

    public void UpdateAccounts() => BankAccounts.ForEach(ba => ba.UpdateBalance());
}
