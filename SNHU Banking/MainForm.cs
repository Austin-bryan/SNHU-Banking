using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Populate data
        List<(string Category, string[] Entries)> data = new List<(string, string[])>
    {
        ("Checking", new string[] { "Acc1", "Acc2", "Acc3" }),
        ("Savings", new string[] { "Acc1", "Acc2" }),
        ("CDs", new string[] { "Acc1", "Acc2", "Acc3" })
    };

        // Add items to the ListBox with custom formatting
        foreach (var (category, entries) in data)
        {
            listBox.Items.Add(category); // Add category with bold formatting
            foreach (string entry in entries)
                listBox.Items.Add("    " + entry); // Add indented entry with regular formatting
        }
    }

    // Custom drawing for the ListBox
    private void listBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0)
            return;

        string itemText = listBox.Items[e.Index].ToString();
        bool isCategory = !itemText.StartsWith("    "); // Check if item is a category

        // Set font style based on category or entry
        Font font = isCategory ? new Font(listBox.Font, FontStyle.Bold) : listBox.Font;

        // Draw item
        e.DrawBackground();
        TextRenderer.DrawText(e.Graphics, itemText, font, e.Bounds, e.ForeColor, TextFormatFlags.Left);
        e.DrawFocusRectangle();
    }
}
