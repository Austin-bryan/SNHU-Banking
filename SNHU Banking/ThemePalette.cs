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
}
