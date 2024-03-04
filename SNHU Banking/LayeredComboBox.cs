namespace SNHU_Banking;

// Purpose: This class is a multilayered drop down menu. I didn't like the built in drop down menu and to improve the asthetics and add categories. 
// The name isn't good. I used a layered combox, but it should be layered drop down menu, but if I change it now it'll make the variable
// names inconsistent, and I'd rather be consistent. Had a more time, I'd fix this.
public partial class LayeredComboBox : UserControl
{
    // I use padding to put the text off center for asthetics. I have to always trim that to get the raw text
    public override string Text => mainButton.Text.TrimStart(' ');
    public bool IsDefaultOption => Text == DefaultItem.TrimStart(' ');

    // Items are what each clickable button in the drop down menu is.
    // The default option is the one that shows before something is selected
    public string DefaultItem
    {
        get => _defaultItem;
        set
        {
            value = value.Replace(padding, "");
            _defaultItem = padding + value;
        }
    }

    public delegate void SelectionChangeHandler(int newIndex, int? newCategoryIndex);
    public event SelectionChangeHandler OnSelectionChange;

    private const string padding = "      ";    // Used to offset the text

    // Categories are indexed 0, 1, 2, the values from (int)EAccountCategory, however I also need to know the index
    // of where they are stored in the listbox. This handles that mapping. 
    private readonly Dictionary<int, int> categoryIndexToItemIndex = [];   
    private string _defaultItem = padding + "Pick an Item";
    private int hoveredIndex;

    public LayeredComboBox()
    {
        InitializeComponent();
        listBox.DrawItem += listBox_DrawItem;

        mainButton.Location = Point.Empty;
        listBox.DrawMode = DrawMode.OwnerDrawFixed;
    }

    // Adds a category Item. Categories can't be selected, have no hover events, but have children that can be clicked on
    public void AddCategory(string text)
    {
        var llbi      = new LayeredListBoxItem(text, isCategory: true, categoryIndex: categoryIndexToItemIndex.Values.Count);
        int itemIndex = listBox.Items.Add(llbi);
        
        categoryIndexToItemIndex.Add(itemIndex, llbi.CategoryIndex ?? 0);
        AdjustHeight();
    }
    // Items are selectable, hoverable and are children of categories. 
    // I coded this to allow an item not belong to a category, but the two places I use this, I use categories
    public void AddItem(string text, int? categoryIndex = null)
    {
        LayeredListBoxItem item;

        if (categoryIndex != null)
        {
            int categoryInsertIndex;

            // This inserts the new item right before the next category, the bottom of the category it belongs in
            if (categoryIndexToItemIndex.ContainsKey(categoryIndex.Value + 1))
            {
                categoryInsertIndex = categoryIndexToItemIndex[categoryIndex.Value + 1];

                // Since all categories are now pushed up, I need to increment the map to make the mapping up to date
                categoryIndexToItemIndex.Keys
                    .Where(k => k > categoryIndex)
                    .ToList()
                    .ForEach(k => categoryIndexToItemIndex[k]++);
            }
            // If the item is in the last category, insert at the back
            else categoryInsertIndex = listBox.Items.Count;

            item = new LayeredListBoxItem(padding + text, false, categoryIndex);
            listBox.Items.Insert(categoryInsertIndex, item);
        }
        else // This isn't actually used, because all instances have categories
        {
            item = new LayeredListBoxItem(text);
            listBox.Items.Add(item);
        }
        AdjustHeight();
    }
    // Given an index, this will select and fire the selection event
    public void SelectItem(int index)
    {
        foreach (var categoryIndex in categoryIndexToItemIndex.Values)
            if (index >= categoryIndex)
                index++;

        listBox.SelectedIndex = index;
        mainButton.Text = listBox.Items[index].ToString();
        OnSelectionChange?.Invoke(index, (listBox.Items[index] as LayeredListBoxItem).CategoryIndex);
    }
    public void SetColor((Color foreColor, Color backColor) colors) => SetColor(colors.foreColor, colors.backColor);
    public void SetColor(Color foreColor, Color backColor)
    {
        mainButton.BackColor = backColor;
        sideBar.BackColor    = Color.FromArgb(255, (int)(backColor.R * 0.666), (int)(backColor.G * 0.666), (int)(backColor.B * 0.666));
        mainButton.ForeColor = foreColor;
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
    private void mainButton_Paint (object sender, PaintEventArgs e)
    {
        // Here, I apply what I learn from my drawing program to draw the downward arrow in the menu
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

        e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(30, 30, 30)), points);

        int offset       = 5;
        sideBar.Location = new Point(offset, offset);
        sideBar.Height   = mainButton.Height - offset * 2;
    }
    private void mainButton_Click (object sender, EventArgs e)
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
    private void listBox_DrawItem (object? sender, DrawItemEventArgs e)
    {
        if (e.Index < 0 || e.Index >= listBox.Items.Count)
            return;

        // Draws the item, setting the color if its hovered or not.
        var item        = (LayeredListBoxItem)listBox.Items[e.Index];
        var fontStyle   = item.IsCategory ? FontStyle.Bold : FontStyle.Regular;
        var font        = new Font(e.Font.FontFamily, 9, fontStyle);
        bool isHovered  = e.Index == hoveredIndex;
        Color color     = Color.White;
        Color backColor = item.IsCategory || !isHovered
                            ? Color.FromArgb(70, 70, 70)
                            : Color.FromArgb(100, 100, 100);

        using (Brush backBrush = new SolidBrush(backColor))
            e.Graphics.FillRectangle(backBrush, e.Bounds);
        e.Graphics.DrawString(listBox.Items[e.Index].ToString(), font, new SolidBrush(color), e.Bounds);

        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            e.DrawFocusRectangle();
    }
    private void listBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (hoveredIndex == -1)     // If the user clicks on the listbox, but not on any item, return
            return;
        if (categoryIndexToItemIndex.ContainsValue(hoveredIndex))   // Dont click on categories
            return;
        // Select the item
        mainButton.Text = listBox.Items[hoveredIndex].ToString();
        OnSelectionChange?.Invoke(hoveredIndex, (listBox.Items[hoveredIndex] as LayeredListBoxItem).CategoryIndex);
    }
    private void LayeredComboBox_Leave(object sender, EventArgs e) => listBox.Visible = false;
}