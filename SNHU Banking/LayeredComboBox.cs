using System;

namespace SNHU_Banking;

public partial class LayeredComboBox : UserControl
{
    public override string Text => mainButton.Text.TrimStart(' ');
    public string DefaultItem
    {
        get => _defaultItem;
        set
        {
            value = value.Replace(Padding, "");
            _defaultItem = Padding + value;
        }
    }
    public bool IsDefaultOption => Text == DefaultItem;

    public delegate void SelectionChangeHandler(int newIndex, int? newCategoryIndex);
    public event SelectionChangeHandler OnSelectionChange;

    public const string Padding = "      ";
    private readonly Dictionary<int, int> categoryIndexToItemIndex = [];
    private string _defaultItem = Padding + "Pick an Item";
    private int hoveredIndex;

    public LayeredComboBox()
    {
        InitializeComponent();
        listBox.DrawItem += listBox_DrawItem;

        mainButton.Location = Point.Empty;
        listBox.DrawMode = DrawMode.OwnerDrawFixed;
    }

    public void AddCategory(string text)
    {
        LayeredListBoxItem llbi = new(text, true);
        int itemIndex = listBox.Items.Add(llbi);
        categoryIndexToItemIndex.Add(itemIndex, categoryIndexToItemIndex.Count);
        AdjustHeight();
    }
    public void SetColor((Color foreColor, Color backColor) colors) => SetColor(colors.foreColor, colors.backColor);
    public void SetColor(Color foreColor, Color backColor)
    {
        mainButton.BackColor = backColor;
        sideBar.BackColor    = Color.FromArgb(255, (int)(backColor.R * 0.666), (int)(backColor.G * 0.666), (int)(backColor.B * 0.666));
        mainButton.ForeColor = foreColor;
    }
    public void AddItem(string text, int? categoryIndex = null)
    {
        LayeredListBoxItem item;

        if (categoryIndex != null)
        {
            int categoryInsertIndex;

            if (categoryIndexToItemIndex.ContainsKey(categoryIndex.Value + 1))
            {
                categoryInsertIndex = categoryIndexToItemIndex[categoryIndex.Value + 1];

                categoryIndexToItemIndex.Keys
                    .Where(k => k > categoryIndex)
                    .ToList()
                    .ForEach(k => categoryIndexToItemIndex[k]++);
            }
            else categoryInsertIndex = listBox.Items.Count;

            item = new LayeredListBoxItem(Padding + text, false, categoryIndex);
            //item = new LayeredListBoxItem("    " + text, false, categoryIndex);
            listBox.Items.Insert(categoryInsertIndex, item);
        }
        else
        {
            item = new LayeredListBoxItem(text);
            listBox.Items.Add(item);
        }
        AdjustHeight();
    }
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        mainButton.Text = DefaultItem;
    }
    private void AdjustHeight()
    {
        const int height = 15;
        listBox.Height = Math.Min(listBox.Items.Count * height, height * 5) + 15;
    }
    public void SelectItem(int index)
    {
        foreach (var categoryIndex in categoryIndexToItemIndex.Values)
            if (index >= categoryIndex)
                index++;

        listBox.SelectedIndex = index;
        mainButton.Text = listBox.Items[index].ToString();
        OnSelectionChange?.Invoke(index, (listBox.Items[index] as LayeredListBoxItem).CategoryIndex);
    }
    
    private void mainButton_Paint(object sender, PaintEventArgs e)
    {
        (mainButton.Width, mainButton.Height, listBox.Width) = (Width, Height, Width - 4);

        const int thickness = 4;
        const int height    = 6;
        const int width     = 6;

        Point root = new((int)(Width - width * 2 - thickness * 2 - 5), (int)(mainButton.Height * 0.4));
        Point[] points =
        [
            new(root.X - thickness, root.Y),
            root,
            new(root.X + width, root.Y + height),
            new(root.X + width * 2, root.Y),
            new(root.X + width * 2 + thickness, root.Y),
            new(root.X + width, root.Y + height + thickness),
        ];

        e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(40, 40, 40)), points);

        int offset       = 5;
        sideBar.Location = new Point(offset, offset);
        sideBar.Height   = mainButton.Height - offset * 2;
    }
    private void mainButton_Click(object sender, EventArgs e)
    {
        listBox.Visible = !listBox.Visible;

        // In order to not get clipped by the panel the control is in, its parent must be MainForm, then drawn on top
        // That then requires adding the location of all its parents so that the offset is correct. 
        // This is agnostic to what the panel layout is, as it stops until it reaches MainForm
        Point parentOffset = Location;
        Control parent     = Parent;

        while (parent is not null and not Form)
        {
            parentOffset = new Point(parentOffset.X + parent.Location.X, parentOffset.Y + parent.Location.Y);
            parent       = parent.Parent;
        }

        listBox.Parent   = parent;
        listBox.Location = new Point(parentOffset.X + 2, parentOffset.Y + mainButton.Height + 2);
        listBox.BringToFront();
    }
    private void listBox_MouseMove(object sender, MouseEventArgs e)
    {
        int index = listBox.IndexFromPoint(e.Location);
        if (index != hoveredIndex)
        {
            hoveredIndex = index;
            listBox.Invalidate(); // Redraw the list box to apply the hover effect
        }
    }
    private void listBox_DrawItem(object? sender, DrawItemEventArgs e)
    {
        if (e.Index < 0 || e.Index >= listBox.Items.Count)
            return;

        var item        = (LayeredListBoxItem)listBox.Items[e.Index];
        var fontStyle   = item.IsCategory ? FontStyle.Bold : FontStyle.Regular;
        var font        = new Font(e.Font.FontFamily, 9, fontStyle);
        bool isHovered  = e.Index == hoveredIndex;
        Color color     = Color.White;
        Color backColor = item.IsCategory || !isHovered
                            ? Color.FromArgb(80, 80, 80)
                            : Color.FromArgb(110, 110, 110);

        using (Brush backBrush = new SolidBrush(backColor))
            e.Graphics.FillRectangle(backBrush, e.Bounds);
        e.Graphics.DrawString(listBox.Items[e.Index].ToString(), font, new SolidBrush(color), e.Bounds);

        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            e.DrawFocusRectangle();
    }
    private void listBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (categoryIndexToItemIndex.ContainsValue(hoveredIndex))
            return;
        mainButton.Text = listBox.Items[hoveredIndex].ToString();

        OnSelectionChange?.Invoke(hoveredIndex, (listBox.Items[hoveredIndex] as LayeredListBoxItem).CategoryIndex);
    }
    private void LayeredComboBox_Leave(object sender, EventArgs e) => listBox.Visible = false;
}