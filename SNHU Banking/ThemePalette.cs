using System.Text.RegularExpressions;

namespace SNHU_Banking;

public static class ThemePalette
{
    public static readonly Color FormBackColor    = Color.FromArgb(255, 30, 30, 30);
    public static readonly Color ControlBackColor = Color.FromArgb(255, 50, 50, 50);
    public static readonly Color CheckingTheme    = Color.FromArgb(255, 75, 110, 255);
    public static readonly Color SavingsTheme     = Color.FromArgb(255, 40, 240, 40);
    public static readonly Color CDsTheme         = Color.FromArgb(255, 220, 40, 50);

    public static (Color ForeColor, Color BackColor) GetAccountTheme(EAccountCategory category) => category switch
    {
        EAccountCategory.Checking => (Color.White, CheckingTheme),
        EAccountCategory.Savings  => (Color.Black, SavingsTheme),
        EAccountCategory.CDs      => (Color.White, CDsTheme),
        _                         => (Color.Black, Color.White),
    };
    public static string FormatMoney(decimal d) => string.Format("${0:#,##0.00}", d);

    public static string OnMoneyTextbox_Leave(string text)
    {
        if (text.StartsWith("00"))                        // Removes leading zeroes
            text = text.TrimStart('0');
        if (text.StartsWith('.'))                         // Adds a leading zero if a decimal is the first char
            text = "0" + text;
        if (!text.Contains('.'))                          // If there is no decimal, add a .00 at the end
            text += ".00";
        else if (text.EndsWith('.'))                      // If the user adds a decimal but not the zeros, add them in
            text += "00";
        else if (text.EndsWith(".0"))                     // Make sure it ends with two zeros, not just one
            text += "0";
        else if (Regex.IsMatch(text, @"\.\d$"))           // If the user enters .N where N is any digit, add a zero at the end
            text += "0";
        return text;
    }
    public static void OnMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBox tb = (TextBox)sender;
        if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))    // Surpress key if not number, but allow decimal
            e.Handled = true;
        else if (e.KeyChar == '.' && tb.Text.Contains('.'))                  // Suppress key press if a decimal point is already present
            e.Handled = true;
        else if (e.KeyChar == '.' && tb.Text.Length == 0)                    // Surpress key if first character is decimal
            e.Handled = true;
        
        // Surpress key if a decimal has been placed, and two decimal points have already been added. However, allow a backspace to delete text. 
        // Also allows editing of the textbox if the entire textbox contents are selected
        else if (
            !(tb.SelectionStart == 0 && tb.SelectionLength == tb.Text.Length) &&
            e.KeyChar != '\b' && tb.Text.Contains('.') && tb.Text[tb.Text.IndexOf('.')..].Length > 2)
            e.Handled = true;
    }
}
