namespace SNHU_Banking;

public partial class MainForm : Form
{
    private readonly int transferPanelStartHeight;

    public MainForm()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;
        BackColor = ThemePalette.FormBackColor;
        DarkStylizer.UseDarkMode(Handle, true);

        accountsPanel.Controls
            .ToList()
            .OfType<AccountCategoryControl>()
            .ToList().ForEach(acc =>
            {
                acc.MainForm = this;
                acc.OnBalanceChange += Account_OnBalanceChange;
                pieChart.AddAccountCategoryControl(acc);
            });

        fromAccountBox.OnSelectionChange += FromAccountBox_OnSelectionChange;
        toAccountBox.OnSelectionChange += ToAccountBox_OnSelectionChange;
        transferPanelStartHeight = transferPanel.Height;
    }

    public void AddAccount(BankAccount account)
    {
        if (account.Category != EAccountCategory.CDs)
            fromAccountBox.AddItem(account.Name, (int)account.Category);
        toAccountBox.AddItem(account.Name, (int)account.Category);
    }
    public void AddBalancePreview(BalancePreview balancePreview) => balancePreviewPanel.Controls.Add(balancePreview);
    public List<AccountCategoryControl> GetAccountCategoryControls() => accountsPanel.Controls.ToList().OfType<AccountCategoryControl>().ToList();

    public void ShowTransferError()  => ChangeTransfer(25, true, false);
    public void ShowTransferSubmit() => ChangeTransfer(120, false, true);
    public void ResetTransfer()      => ChangeTransfer(0, false, false);
    
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
    
    private void button1_Click(object sender, EventArgs e)
    {
        //decimal transferAmount = decimal.Parse(transferTB.Text);

        if (decimal.TryParse(transferTB.Text, out decimal transferAmount))
        {
            BankAccount fromAccount = BankAccount.GetBankAccount(fromAccountBox.Text);      
         
            BankAccount toAccount = BankAccount.GetBankAccount(toAccountBox.Text);

            // Change balances
            if (fromAccount.TryWithdraw(transferAmount))
            {
                toAccount.Deposit(transferAmount);
                //TODO: toAccount.BankAccountControl.UpdateDisplay();
                //TODO: fromAccount.BankAccountControl.UpdateDisplay();
            }

        }
        else
        {
            MessageBox.Show("Must enter a number.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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
    
    private void ToAccountBox_OnSelectionChange(int newIndex, int? categoryIndex)   => OnAccountSelected(toAccountBox, categoryIndex.Value);
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
}