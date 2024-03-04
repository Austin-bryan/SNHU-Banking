using static SNHU_Banking.ThemePalette;

namespace SNHU_Banking;

// Purpose: Shows the name, color and balance of an account in the pie chart display
public partial class BalancePreview : UserControl
{
    private EAccountCategory Category => accountCategoryControl.Category;
    private readonly AccountCategoryControl accountCategoryControl;

    public BalancePreview(AccountCategoryControl acc)
    {
        InitializeComponent();
        accountCategoryControl = acc;
        accountCategoryControl.OnBalanceChange += OnBalanceChange;  // Subscribe to any balance changes
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        
        // Set display based on Bank Account
        colorSplash.BackColor = GetAccountTheme(Category).BackColor;
        balanceLabel.Text     = FormatMoney(accountCategoryControl.Total);
        accountLabel.Text     = Category.ToString();
    }
    private void OnBalanceChange(decimal balance, decimal ytd) => balanceLabel.Text = FormatMoney(balance);
}