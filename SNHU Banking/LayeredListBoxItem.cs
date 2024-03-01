namespace SNHU_Banking;

public class LayeredListBoxItem(string text, bool isCategory = false, int? categoryIndex = null)
{
    public int? CategoryIndex         => categoryIndex;
    public bool IsCategory            => isCategory;
    public override string ToString() => text;
}