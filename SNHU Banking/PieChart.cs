using static SNHU_Banking.ThemePalette;
namespace SNHU_Banking;

public partial class PieChart : UserControl
{
    private readonly List<AccountCategoryControl> accountCategoryControls = new();

    public PieChart() => InitializeComponent();
    public void AddAccountCategoryControl(AccountCategoryControl acc)
    {
        accountCategoryControls.Add(acc);
        acc.OnBalanceChange += OnBalanceChange;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawPieChart();
    }

    private void OnBalanceChange(decimal balance, decimal ytd)
    {
        DrawPieChart();
    }

    private void DrawPieChart()
    {
        List<(decimal Value, Color Color)> valueColorPairs = accountCategoryControls
                .Where(acc => acc.BankAccounts.Count > 0)
                .ToList()
                .Select(acc => (acc.Total, GetAccountTheme(acc.Category).BackColor))
                .ToList();

        decimal total = 0;
        foreach (var (value, _) in valueColorPairs)
            total += value;

        // Set up drawing parameters
        int pieRadius         = (int)(Math.Min(ClientSize.Width, ClientSize.Height) / 2.2);
        int innerCircleRadius = 75;
        float startAngle      = 0;

        // Draw pie slices
        using Graphics g = CreateGraphics();

        for (int i = 0; i < valueColorPairs.Count; i++)
        {
            float sweepAngle = 360f * (float)valueColorPairs[i].Value / (float)total; // Subtract gap angle

            float sliceCenterAngle  = startAngle + sweepAngle / 2;
            Point pieCenter         = new(Width / 2 - pieRadius, Height / 2 - pieRadius);
            Point innerCircleCenter = new(Width / 2 - innerCircleRadius, Height / 2 - innerCircleRadius);

            using (Brush brush = new SolidBrush(valueColorPairs[i].Color))
            {
                g.FillPie(brush, pieCenter.X, pieCenter.Y, 2 * pieRadius, 2 * pieRadius, startAngle, sweepAngle);
                g.DrawPie(new Pen(ThemePalette.ControlBackColor, 10), pieCenter.X, pieCenter.Y, 2 * pieRadius, 2 * pieRadius, startAngle, sweepAngle);
                g.FillEllipse(new SolidBrush(BackColor), innerCircleCenter.X, innerCircleCenter.Y, innerCircleRadius * 2, innerCircleRadius * 2);
            }

            startAngle += sweepAngle; // Add gap angle for next slice
        }
    }
}
