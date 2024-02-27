using System.Runtime.InteropServices;

namespace SNHU_Banking;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;
        BackColor   = ThemePalette.FormBackColor;
        //accountsPanel.Height += 200;
        DarkStylizer.UseDarkMode(Handle, true);


        foreach (var control in accountsPanel.Controls)
        {
            if (control is AccountCategoryControl acc)
            {
                acc.MainForm = this;
                pieChart1.AddAccountCategoryControl(acc);
            }
        }
    }
    public void AddBalancePreview(BalancePreview balancePreview) => balancePreviewPanel.Controls.Add(balancePreview);
}
