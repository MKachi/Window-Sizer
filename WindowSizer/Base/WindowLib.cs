using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowSizer.Base
{
    public static class WindowLib
    {
        public static void SetFullScreenWindowMode(IntPtr handle, bool hideTitle, bool showStartMenu)
        {
            if (hideTitle)
            {
                User32.SetWindowLong(handle, -16, 276824064);
            }
            else
            {
                User32.SetWindowLong(handle, -16, 349044736);
            }

            Rectangle rect;
            if (showStartMenu)
            {
                rect = Screen.PrimaryScreen.WorkingArea;
            }
            else
            {
                rect = Screen.PrimaryScreen.Bounds;
            }
            User32.SetWindowPos(handle, 0,
                rect.Location.X,
                rect.Location.Y,
                rect.Width,
                rect.Height, 0);
            User32.SetForegroundWindow(handle);
        }
        public static void SetWindowSize(IntPtr handle, int width, int height, int x, int y, bool hideTitle = false)
        {
            if (hideTitle)
            {
                User32.SetWindowLong(handle, -16, 276824064);
            }
            else
            {
                User32.SetWindowLong(handle, -16, 349044736);
            }
            User32.SetWindowPos(handle, 0, x, y, width, height, 0);
            User32.SetForegroundWindow(handle);
        }
    }
}
