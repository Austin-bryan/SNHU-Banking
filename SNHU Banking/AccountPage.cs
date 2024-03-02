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
    }

    private void withdrawButton_Click(object sender, EventArgs e) => SwitchModes(ETransferMode.Withdraw, (Color.FromArgb(200, 50, 50), withdrawButton), (Color.Black, depositButton), "Widthdraw", Color.White);
    private void depositButton_Click(object sender, EventArgs e) => SwitchModes(ETransferMode.Deposit, (Color.FromArgb(50, 150, 50), depositButton), (Color.White, withdrawButton), "Deposit", Color.Black);

    private void SwitchModes(ETransferMode transferMode, (Color color, Button button) selected, (Color foreColor, Button button) deselected, string text, Color foreColor) =>
        (this.transferMode, deselected.button.BackColor, deselected.button.ForeColor, selected.button.BackColor, transferButton.BackColor, transferButton.ForeColor, transferButton.Text) =
        (transferMode, Color.FromArgb(80, 80, 80), deselected.foreColor, selected.color, selected.color, foreColor, text);

    private void transferTB_Leave(object sender, EventArgs e) => transferTB.Text = ThemePalette.OnMoneyTextbox_Leave(transferTB.Text);
    private void transferTB_KeyPress(object sender, KeyPressEventArgs e) => ThemePalette.OnMoneyTextBox_KeyPress(sender, e);

    private void transferButton_Click(object sender, EventArgs e)
    {
        if (decimal.TryParse(transferTB.Text, out decimal amount))
        {
            if (transferMode == ETransferMode.Deposit)
                 bankAccountControl.Deposit(amount);
            else bankAccountControl.TryWithdraw(amount);
        }
        else MessageBox.Show("Must enter a number.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}