namespace SNHU_Banking;

// Using C#12's feature Primary Category.
// This is just used as a POD for the drop down menu
public class LayeredListBoxItem(string text, bool isCategory = false, int? categoryIndex = null)
{
    public int? CategoryIndex         => categoryIndex;
    public bool IsCategory            => isCategory;
    public override string ToString() => text;
}