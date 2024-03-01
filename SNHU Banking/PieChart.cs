using static SNHU_Banking.ThemePalette;
namespace SNHU_Banking;

public partial class PieChart : UserControl
{
    private readonly List<AccountCategoryControl> accountCategoryControls = [];

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

    private void OnBalanceChange(decimal balance, decimal ytd) => DrawPieChart();

    private void DrawPieChart()
    {
        // Pair the values and colors for each account category
        List<(decimal Value, Color Color)> valueColorPairs = accountCategoryControls
                .Where(acc => acc.BankAccounts.Count > 0)
                .Select(acc => (acc.Total, GetAccountTheme(acc.Category).BackColor))
                .ToList();

        decimal total = 0;
        foreach (var (value, _) in valueColorPairs)
            total += value;

        // Set up drawing parameters
        int pieRadius    = (int)(Math.Min(ClientSize.Width, ClientSize.Height) / 2.2);
        int holeRadius   = 75;
        float startAngle = 0;

        using Graphics g = CreateGraphics();

        for (int i = 0; i < valueColorPairs.Count; i++)
        {
            // Makes pie slice wider as value increases
            float sweepAngle = 360f * (float)valueColorPairs[i].Value / (float)total;

            Point pieCenter  = new(Width / 2 - pieRadius, Height / 2 - pieRadius);      // Used for pie slices
            Point holeCenter = new(Width / 2 - holeRadius, Height / 2 - holeRadius);    // Used to draw a hole in the pie

            using (Brush brush = new SolidBrush(valueColorPairs[i].Color))
            {
                // Draws pie slices
                g.FillPie(brush, pieCenter.X, pieCenter.Y, 2 * pieRadius, 2 * pieRadius, startAngle, sweepAngle);
                
                // Adds a gap between slices
                g.DrawPie(new Pen(ThemePalette.ControlBackColor, 7), pieCenter.X, pieCenter.Y, 2 * pieRadius, 2 * pieRadius, startAngle, sweepAngle);

                // Fills a whole in the center
                g.FillEllipse(new SolidBrush(BackColor), holeCenter.X, holeCenter.Y, holeRadius * 2, holeRadius * 2);
            }

            startAngle += sweepAngle; // Add gap angle for next slice
        }
    }
}
