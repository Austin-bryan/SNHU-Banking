using static System.Windows.Forms.Control;

namespace SNHU_Banking;

public static class ExtenstionMethods
{
    // Allows me to convert ControlCollection to List so I can use LINQ
    public static List<Control> ToList(this ControlCollection c)
    {
        List<Control> controls = [];
        foreach (Control control in c)
            controls.Add(control);
        return controls;
    }

    // This method does the exact same as above, in 6 characters instead of 6 lines!!
    // I believe this was added in C# 12 or 11.
    // Unforuntely, it doesn't work! For whatever reason, it handles each element as object,
    // then says it cant cast object to control, 
    // even though ControlCollection stores controls. Heart breaking. 

    //public static List<Control> ToList(this ControlCollection c) => [..c];
}
