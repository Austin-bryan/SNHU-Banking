namespace SNHU_Banking;

public partial class MainForm : Form
{
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
                pieChart1.AddAccountCategoryControl(acc);
            });

        fromAccountBox.AddCategory("Checking", EAccountCategory.Checking);
        fromAccountBox.AddCategory("Savings", EAccountCategory.Savings);
        fromAccountBox.AddCategory("CDs", EAccountCategory.CDs);
    }
    private void AddCategory(ToolStripDropDownMenu menu, string category, string[] entries)
    {
        // Create the category item (bold)
        ToolStripMenuItem categoryItem = new ToolStripMenuItem(category);
        categoryItem.Font = new Font(categoryItem.Font, FontStyle.Bold);
        menu.Items.Add(categoryItem);

        // Add entries under the category
        foreach (string entry in entries)
        {
            // Create the entry item (indented and unbold)
            ToolStripMenuItem entryItem = new ToolStripMenuItem(entry);
            entryItem.Padding = new Padding(20, 0, 0, 0); // Add indentation
            categoryItem.DropDownItems.Add(entryItem);
        }
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

    public void AddBalancePreview(BalancePreview balancePreview) => balancePreviewPanel.Controls.Add(balancePreview);
}
