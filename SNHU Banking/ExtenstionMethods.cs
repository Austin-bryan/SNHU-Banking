using static System.Windows.Forms.Control;

namespace SNHU_Banking;

public static class ExtenstionMethods
{
    public static List<Control> ToList(this ControlCollection cc)
    {
        List<Control> controls = new();
        foreach (Control control in cc)
            controls.Add(control);
        return controls;
    }
    //public static List<Control> ToList(this ControlCollection cc) => [.. cc];
}
