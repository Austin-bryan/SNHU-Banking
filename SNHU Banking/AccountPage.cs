
namespace SNHU_Banking;

/* Purpose: When the user clicks on an account, this is the page that opens up. 
 * This page will show transactions, and allow the user to make withdrawals and deposits.
 */
public partial class AccountPage : UserControl
{
    private enum ETransferMode { Withdraw, Deposit }
    private ETransferMode transferMode = ETransferMode.Deposit;
    private readonly BankAccountControl bankAccountControl;

    // This shows only one account at a time, so that is injected here
    public AccountPage(BankAccountControl bac)
    {
        InitializeComponent();

        // Set the labels of the all the UI based on the bank account
        bankAccountControl    = bac;
        nameLabel.Text        = bankAccountControl.Name;
        accountTypeLabel.Text = bankAccountControl.Category.ToString().TrimEnd('s') + " Account";
        yieldLabel.Text       = bankAccountControl.Yield.ToString() + "%";
        balanceLabel.Text     = ThemePalette.FormatMoney(bankAccountControl.Balance);
        ytdLabel.Text         = ThemePalette.FormatMoney(bankAccountControl.YTD);
        
        accountDisplayBackgorund.BackColor = ThemePalette.GetAccountTheme(bankAccountControl.Category).BackColor;

        // Creates the transaction controls
        foreach (var transaction in bac.Transactions)
            CreateTransationControl(transaction);
    }

    // Changes the colors of the withdraw and deposit buttons to show whats selected
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

    // Since transferTB is used for money inputs, it gets forwarded
    private void transferTB_Leave(object sender, EventArgs e) => transferTB.Text = ThemePalette.OnMoneyTextbox_Leave(transferTB.Text);
    private void transferTB_KeyPress(object sender, KeyPressEventArgs e) => ThemePalette.OnMoneyTextBox_KeyPress(sender, e);
    private void transferButton_Click(object sender, EventArgs e)
    {
        // Ensures that the user enters a valid enter, before the try to submit
        if (!decimal.TryParse(transferTB.Text, out decimal amount))
        {
            MessageBox.Show("Must enter a number.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Don't let them make a transaction of amount 0
        if (amount == 0)
            return;
        if (transferMode == ETransferMode.Deposit)
        {
            // Add interest for deposits
            bankAccountControl.Deposit(amount);
            bankAccountControl.AddInterest(amount);
            ytdLabel.Text = ThemePalette.FormatMoney(bankAccountControl.YTD);
        }
        else bankAccountControl.TryWithdraw(amount);

        // Add transaction and update UI
        CreateTransationControl(bankAccountControl.Transactions.Last());
        balanceLabel.Text = ThemePalette.FormatMoney(bankAccountControl.Balance);
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
        noTransLabel.Hide();    // Hide the label that says, "no transactions" now that we have one

        TransactionControl tc = new(transaction);
        tc.Show();
        tc.Parent = transactionPanel;
        tc.Margin = new Padding(0, 3, 3, 3);
        transactionPanel.Controls.SetChildIndex(tc, 0);     // Ensure the newest transactions are on the top

        if (transactionPanel.Controls.Count > 100)
        {
            // Removes the oldest control, which is at the bottom of the page and at the top of the Controls list
            // This makes it so the 101st control is deleted
            Control tcRemove = transactionPanel.Controls[transactionPanel.Controls.Count - 1];
            transactionPanel.Controls.Remove(tcRemove);
            tcRemove.Dispose();
        }
    }

    private void transferTB_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;      // Turns off annoying error sound when hitting enter
            transferButton.PerformClick();  // Allows pressing enter to have the same effect as pushing the submit button
        }
    }
}