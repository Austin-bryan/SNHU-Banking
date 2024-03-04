
namespace SNHU_Banking;

public partial class AccountPage : UserControl
{
    private enum ETransferMode { Withdraw, Deposit }
    private ETransferMode transferMode = ETransferMode.Deposit;
    private readonly BankAccountControl bankAccountControl;

    public AccountPage(BankAccountControl bac)
    {
        bankAccountControl = bac;
        InitializeComponent();
        accountDisplayBackgorund.BackColor = ThemePalette.GetAccountTheme(bankAccountControl.Category).BackColor;

        nameLabel.Text = bankAccountControl.Name;
        accountTypeLabel.Text = bankAccountControl.Category.ToString().TrimEnd('s') + " Account";
        balanceLabel.Text = ThemePalette.FormatMoney(bankAccountControl.Balance);
        ytdLabel.Text = ThemePalette.FormatMoney(bankAccountControl.YTD);
        yieldLabel.Text = bankAccountControl.Yield.ToString() + "%";

        foreach (var transaction in bac.Transactions)
            CreateTransationControl(transaction);
    }

    private void withdrawButton_Click(object sender, EventArgs e) =>
        SwitchModes(ETransferMode.Withdraw, Color.FromArgb(200, 50, 50), withdrawButton, depositButton, "Widthdraw");
    private void depositButton_Click(object sender, EventArgs e) =>
        SwitchModes(ETransferMode.Deposit, Color.FromArgb(50, 150, 50), depositButton, withdrawButton, "Deposit");

    private void SwitchModes(ETransferMode transferMode, Color backColor, Button selectedButton, Button deselectedButton, string text)
    {
        this.transferMode          = transferMode;
        transferButton.Text        = text;
        deselectedButton.BackColor = Color.FromArgb(80, 80, 80);
        transferButton.BackColor   = selectedButton.BackColor = backColor;
    }
    private void transferTB_Leave(object sender, EventArgs e) => transferTB.Text = ThemePalette.OnMoneyTextbox_Leave(transferTB.Text);

    private void transferTB_KeyPress(object sender, KeyPressEventArgs e) => ThemePalette.OnMoneyTextBox_KeyPress(sender, e);
    private void transferButton_Click(object sender, EventArgs e)
    {
        if (decimal.TryParse(transferTB.Text, out decimal amount))
        {
            if (amount == 0)
                return;
            if (transferMode == ETransferMode.Deposit)
                 bankAccountControl.Deposit(amount);
            else bankAccountControl.TryWithdraw(amount);

            CreateTransationControl(bankAccountControl.Transactions.Last());
            balanceLabel.Text = ThemePalette.FormatMoney(bankAccountControl.Balance);
        }
        else MessageBox.Show("Must enter a number.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void returnButton_Click(object sender, EventArgs e)
    {
        ((MainForm)ParentForm).SwitchPages(false);
        ((MainForm)ParentForm).UpdateAccounts();
        ParentForm.Controls.Remove(this);
        Dispose();
    }
    private void CreateTransationControl(Transaction transaction)
    {
        noTransLabel.Hide();

        TransactionControl tc = new(transaction);
        tc.Show();
        tc.Parent = transactionPanel;
        tc.Margin = new Padding(0, 3, 3, 3);
        transactionPanel.Controls.SetChildIndex(tc, 0);

        if (transactionPanel.Controls.Count > 100)
        {
            Control tcRemove = transactionPanel.Controls[transactionPanel.Controls.Count - 1];
            transactionPanel.Controls.Remove(tcRemove);
            tcRemove.Dispose();
        }
    }

    private void transferTB_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            transferButton.PerformClick();
        }
    }
}