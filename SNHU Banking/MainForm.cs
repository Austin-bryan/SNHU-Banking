namespace SNHU_Banking;

public partial class MainForm : Form
{
    private readonly int transferPanelStartHeight;

    private static readonly Random rand  = new();
    private static DateTime _currentDate = DateTime.Today;
    public  static DateTime CurrentDate  => _currentDate = _currentDate.AddDays(rand.Next(11));

    public MainForm()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;
        BackColor   = ThemePalette.FormBackColor;
        DarkStylizer.UseDarkMode(Handle, true);

        accountsPanel.Controls
            .ToList()
            .OfType<AccountCategoryControl>()
            .ToList().ForEach(acc =>
            {
                acc.OnBalanceChange += Account_OnBalanceChange;
                pieChart.AddAccountCategoryControl(acc);
            });

        fromAccountBox.OnSelectionChange += FromAccountBox_OnSelectionChange;
        toAccountBox.OnSelectionChange   += ToAccountBox_OnSelectionChange;
        transferPanelStartHeight          = transferPanel.Height = 232;
    }

    public void SwitchPages(bool showAccounView, BankAccountControl? bac = null)
    {
        accountsPanel.Visible = pieChartPanel.Visible = transferPanel.Visible = bankAccountsLabel.Visible = !showAccounView;

        if (!showAccounView || bac == null)
            return;
       
        AccountPage accountPage = new(bac);
        accountPage.Location    = new Point(Width / 2 - accountPage.Width / 2, 0);

        Controls.Add(accountPage);
    }

    public void AddAccount(BankAccount account)
    {
        if (account.Category != EAccountCategory.CDs)
            fromAccountBox.AddItem(account.Name, (int)account.Category);
        toAccountBox.AddItem(account.Name, (int)account.Category);
    }
    public void AddBalancePreview(BalancePreview balancePreview) => balancePreviewPanel.Controls.Add(balancePreview);
    public List<AccountCategoryControl> GetAccountCategoryControls() => accountsPanel.Controls.ToList().OfType<AccountCategoryControl>().ToList();

    public void ShowTransferError()  => ChangeTransfer(25,  true,  false);
    public void ShowTransferSubmit() => ChangeTransfer(120, false, true);
    public void ResetTransfer()      => ChangeTransfer(0,   false, false);

    private void ChangeTransfer(int heightDelta, bool errorVisible, bool submitTransferVisible) =>
        (transferPanel.Height, errorLabel.Visible, submitTransferPanel.Visible) =
        (transferPanelStartHeight + heightDelta, errorVisible, submitTransferVisible);
    private void MainForm_Load(object sender, EventArgs e)
    {
        // The user isn't able to transfer from CDs because they are locked up for a time frame, but they are able to transfer to CDs
        fromAccountBox.AddCategory("Checking");
        fromAccountBox.AddCategory("Savings");

        toAccountBox.AddCategory("Checking");
        toAccountBox.AddCategory("Savings");
        toAccountBox.AddCategory("CDs");
    }

    private void submitTransferButton_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(transferTB.Text, out decimal transferAmount))
        {
            MessageBox.Show("Must enter a number.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        BankAccount fromAccount = BankAccount.GetBankAccount(fromAccountBox.Text);
        BankAccount toAccount = BankAccount.GetBankAccount(toAccountBox.Text);

        if (!fromAccount.TryWithdraw(transferAmount))
            return;
        
        toAccount.Deposit(transferAmount);
        toAccount.BankAccountControl.UpdateBalance();
        fromAccount.BankAccountControl.UpdateBalance();
    }
    private void transferTB_Leave(object sender, EventArgs e) => transferTB.Text = ThemePalette.OnMoneyTextbox_Leave(transferTB.Text);
    private void transferTB_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            submitTransferButton.PerformClick();
        }
    }

    private void ToAccountBox_OnSelectionChange  (int newIndex, int? categoryIndex) => OnAccountSelected(toAccountBox,   categoryIndex.Value);
    private void FromAccountBox_OnSelectionChange(int newIndex, int? categoryIndex) => OnAccountSelected(fromAccountBox, categoryIndex.Value);
    private void OnAccountSelected(LayeredComboBox lcb, int categoryIndex)
    {
        lcb.SetColor(ThemePalette.GetAccountTheme((EAccountCategory)categoryIndex));

        if (toAccountBox.IsDefaultOption || fromAccountBox.IsDefaultOption)
            return;
        if (toAccountBox.Text == fromAccountBox.Text)
             ShowTransferError();
        else ShowTransferSubmit();
    }
    private void Account_OnBalanceChange(decimal balance, decimal ytd)
    {
        decimal total = 0;

        accountsPanel.Controls
            .ToList()
            .OfType<AccountCategoryControl>()
            .ToList()
            .ForEach(acc => total += acc.Total);

        pieChartTotalLabel.Text = ThemePalette.FormatMoney(total);
    }

    private void transferTB_KeyPress(object sender, KeyPressEventArgs e) => ThemePalette.OnMoneyTextBox_KeyPress(sender, e);

    public void UpdateAccounts()
    {
        accountsPanel.Controls
            .ToList()
            .OfType<AccountCategoryControl>()
            .ToList()
            .ForEach(acc =>
            {
                acc.UpdateAccounts();
                acc.UpdateAmounts();
            });
    }
}