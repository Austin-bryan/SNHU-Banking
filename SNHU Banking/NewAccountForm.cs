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

        coloredControls = [submitButton, sideBackground, accountLabel, nameLabel, startBalanceLabel];
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
            submitButton.Enabled = false;
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
        "Checking" => (EAccountCategory.Checking, "Checking Account"),
        "Savings"  => (EAccountCategory.Savings,  "Savings Account"),
        "CDs"      => (EAccountCategory.CDs,      "Certificate of Deposit"),
        _          => (EAccountCategory.Checking, "Default"),
    };

    private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == ' ' && nameTextBox.Text != "")                     // Allow a space if the text box isnt empty
            return;
        namedHasChanged = true;
    }
    private void nameTextBox_TextChanged(object sender, EventArgs e) => UpdateAppearence();

    private void balanceTextBox_Leave(object sender, EventArgs e)            => BalanceText = ThemePalette.OnMoneyTextbox_Leave(BalanceText);
    private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e) => ThemePalette.OnMoneyTextBox_KeyPress(sender, e);
    private void balanceTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            submitButton.PerformClick();
        }
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        decimal yield = accountCategoryControl.Category switch
        {
            EAccountCategory.Checking => 0.5m,
            EAccountCategory.Savings  => 3.5m,
            EAccountCategory.CDs      => 4.5m,
            _                         => throw new ArgumentException()
        };

        BankAccount? account = BankAccount.CreateAccount(nameTextBox.Text, decimal.Parse(BalanceText), accountCategoryControl, yield);

        if (account == null)
        {
            MessageBox.Show("An account with that name already exists.\nChoose a different name.", "SNHU Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        accountCategoryControl.AddAccount(account);

        (Owner as MainForm).AddAccount(account);
        Close();
    }
    private void accountTypeBox_OnSelectionChange(int newIndex, int? newCategoryIndex)
    {
        int adjustedIndex = newIndex switch
        {
            1 => 0,
            2 => 1,
            4 => 2,
            _ => throw new ArgumentException("Invalid index")
        };

        accountCategoryControl = (Owner as MainForm)
            .GetAccountCategoryControls()
            .Where(c => c.Category == (EAccountCategory)adjustedIndex)
            .ToList()[0];

        UpdateAppearence();
        UpdateNameText();
    }

    private void NewAccountForm_FormClosing(object sender, FormClosingEventArgs e) => AccountCategoryControl.AccountFormOpen = false;
}