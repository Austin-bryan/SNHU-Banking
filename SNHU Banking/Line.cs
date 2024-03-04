namespace SNHU_Banking;

// This is just a line control, but its wider than the one pixel panel so its easier to use
public partial class Line : UserControl
{
    public Line() => InitializeComponent();

    private void Line_Paint(object sender, PaintEventArgs e) => pictureBox1.Width = Width;
}