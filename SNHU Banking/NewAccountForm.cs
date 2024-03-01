using System.Text.RegularExpressions;

namespace SNHU_Banking;

public partial class NewAccountForm : Form
{
    private AccountCategoryControl accountCategoryControl;
    private bool namedHasChanged;

    private string BalanceText
    {
        get => balanceTextBox.Text;
        set => balanceTextBox.Text = value;
    }
    private readonly List<Control> coloredControls;

    public NewAccountForm(AccountCategoryControl acc)
    {
        accountCategoryControl = acc;

        InitializeComponent();
        DarkStylizer.UseDarkMode(Handle, true);

        coloredControls = [submitButton,sideBackground, accountLabel, nameLabel,startBalanceLabel];
        UpdateAppearence();

        accountTypeBox.AddCategory("Banking");
        accountTypeBox.AddCategory("Investments");

        accountTypeBox.AddItem("Checking", 0);
        accountTypeBox.AddItem("Savings", 0);
        accountTypeBox.AddItem("CDs", 1);

        accountTypeBox.OnSelectionChange += accountTypeBox_OnSelectionChange;
    }

    public void UpdateAppearence()
    {
        var (fore, back) = ThemePalette.GetAccountTheme(GetAccountCategory().category);

        coloredControls.ForEach(c => { c.ForeColor = fore; c.BackColor = back; });
        mainLabel.Text = "Create New " + GetAccountCategory().label;

        if (nameTextBox.Text == "")
        {
            submitButton.BackColor = Color.FromArgb(60, 60, 60);
            submitButton.ForeColor = Color.Black;
            submitButton.Enabled   = false;
        }
        else submitButton.Enabled = true;
    }
    private void UpdateNameText()
    {
        if (nameTextBox.Text != "" && namedHasChanged)
            return;
        nameTextBox.Text = GetAccountCategory().label + " #" + (accountCategoryControl.BankAccounts.Count + 1).ToString();
    }
    public void Select(EAccountCategory accountCategory) => accountTypeBox.SelectItem((int)accountCategory);

    public (EAccountCategory category, string label) GetAccountCategory() => accountTypeBox.Text switch
    {
        "    Checking" => (EAccountCategory.Checking, "Checking Account"),
        "    Savings"  => (EAccountCategory.Savings,  "Savings Account"),
        "    CDs"      => (EAccountCategory.CDs,      "Certificate of Deposit"),
        _              => (EAccountCategory.Checking, "Default"),
    };

    private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == ' ' && nameTextBox.Text != "")                     // Allow a space if the text box isnt empty
            return;
        namedHasChanged = true;
        //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))      // Block all non alpha chars
        //    e.Handled = true;
    }

    private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))    // Surpress key if not number, but allow decimal
            e.Handled = true;
        else if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))                  // Suppress key press if a decimal point is already present
            e.Handled = true;
        else if (e.KeyChar == '.' && ((TextBox)sender).Text.Length == 0)                    // Surpress key if first character is decimal
            e.Handled = true;
        // Surpress key if a decimal has been placed, and two decimal points have already been added. However, allow a backspace to delete text. 
        // Also allows editing of the textbox if the entire textbox contents are selected
        else if (
            !(balanceTextBox.SelectionStart == 0 && balanceTextBox.SelectionLength == BalanceText.Length) &&

            (e.KeyChar != '\b' && ((TextBox)sender).Text.Contains('.') && ((TextBox)sender).Text.Substring(((TextBox)sender).Text.IndexOf('.')).Length > 2))
            e.Handled = true;
    }

    private void accountTypeBox_OnSelectionChange(int newIndex, int? newCategoryIndex)
    {
        UpdateAppearence();
        UpdateNameText();
    }

    private void balanceTextBox_Leave(object sender, EventArgs e)
    {
        if (BalanceText.StartsWith("00"))                        // Removes leading zeroes
            BalanceText = balanceTextBox.Text.TrimStart('0');
        if (BalanceText.StartsWith('.'))                         // Adds a leading zero if a decimal is the first char
            BalanceText = "0" + BalanceText;

        if (!BalanceText.Contains('.'))                          // If there is no decimal, add a .00 at the end
            BalanceText += ".00";
        else if (BalanceText.EndsWith('.'))                      // If the user adds a decimal but not the zeros, add them in
            BalanceText += "00";
        else if (BalanceText.EndsWith(".0"))                     // Make sure it ends with two zeros, not just one
            BalanceText += "0";
        else if (Regex.IsMatch(BalanceText, @"\.\d$"))           // If the user enters .N where N is any digit, add a zero at the end
            BalanceText += "0";
    }

    private void nameTextBox_TextChanged(object sender, EventArgs e) => UpdateAppearence();

    private void submitButton_Click(object sender, EventArgs e)
    {
        BankAccount? account = BankAccount.CreateAccount(nameTextBox.Text, decimal.Parse(BalanceText), accountCategoryControl);

        if (account == null)
        {
            MessageBox.Show("An account with that name already exists.\nChoose a different name.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        accountCategoryControl.AddAccount(account);
        
        (Owner as MainForm).AddAccount(account);
        Close();
    }

    private void balanceTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            submitButton.Focus();
        }
    }
}