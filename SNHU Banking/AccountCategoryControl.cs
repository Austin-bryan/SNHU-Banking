﻿namespace SNHU_Banking;

public delegate void BalanceChangeHandler(decimal balance, decimal ytd);

public partial class AccountCategoryControl : UserControl
{
    public decimal Total { get; private set; }
    public EAccountCategory Category { get; set; }
    public List<BankAccountControl> BankAccounts { get; private set; } = new();
    public MainForm MainForm
    {
        get => mainForm;
        set
        {
            if (mainForm != null)
                return;
            mainForm = value;
            mainForm?.AddBalancePreview(balancePreview);
        }
    }
    public event BalanceChangeHandler OnBalanceChange;

    private MainForm mainForm;
    private readonly BalancePreview balancePreview;


    public AccountCategoryControl()
    {
        InitializeComponent();
        balancePreview = new BalancePreview(this);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        const int colorSide = 15;
        const int borderThickness = 1;
        base.OnPaint(e);

        categoryLabel.Text      = Category.ToString().ToUpper();
        var (fore, back)        = ThemePalette.GetAccountTheme(Category);
        BackColor               = back;
        newAccountBtn.BackColor = back;
        newAccountBtn.ForeColor = fore;
        mainPanel.Location      = new(colorSide, borderThickness);
        mainPanel.Size          = new(Size.Width - borderThickness - colorSide, Size.Height - borderThickness * 2);
    }

    public void AddAccount(BankAccount account)
    {
        BankAccountControl bac = new(account);
        BankAccounts.Add(bac);
        int shiftAmount = (int)(bac.Height * 1.475);
        
        accountsFlowPanel.Controls.Add(bac);
        accountsFlowPanel.Height += shiftAmount;
        totalPanel.Location = new(totalPanel.Location.X, totalPanel.Location.Y + shiftAmount);
        
        Height += shiftAmount;

        UpdateTotals();
    }
    private void UpdateTotals()
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
        NewAccountForm nac = new(this);
        nac.Show();
        nac.Select(Category);
    }
}