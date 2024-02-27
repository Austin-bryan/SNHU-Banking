namespace SNHU_Banking;

public partial class Line : UserControl
{
    public Line() => InitializeComponent();

    private void Line_Paint(object sender, PaintEventArgs e) => pictureBox1.Width = Width;
}