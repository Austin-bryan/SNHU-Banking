using System.Text.RegularExpressions;

namespace SNHU_Banking;

public static class ThemePalette
{
    public static readonly Color FormBackColor    = Color.FromArgb(255, 40, 40, 40);
    public static readonly Color ControlBackColor = Color.FromArgb(255, 60, 60, 60);
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
}
