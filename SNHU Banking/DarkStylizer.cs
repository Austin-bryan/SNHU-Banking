using System.Runtime.InteropServices;

namespace SNHU_Banking;

// Purpose: Since my application is black themed, I wanted a black title bar, but didn't want to create a custom title bar again. 
// This is used to achieve that. 
public static class DarkStylizer
{
    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

    public static bool UseDarkMode(IntPtr handle, bool enabled)
    {
        const int USE_DARK_MODE_BEFORE_20H1 = 19;
        const int USE_DARK_MODE = 20;

        if (!IsWindows10OrGreater(17763))
            return false;

        int attribute = IsWindows10OrGreater(18985) ? USE_DARK_MODE : USE_DARK_MODE_BEFORE_20H1;
        int useImmersiveDarkMode = enabled ? 1 : 0;
        return DwmSetWindowAttribute(handle, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;

        static bool IsWindows10OrGreater(int build = -1) => Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
    }
}