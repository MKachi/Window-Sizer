using System;
using System.Runtime.InteropServices;

namespace WindowSizer.Base
{
    public struct Rect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    };

    public static class User32
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string windowName);
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr handle, ref Rect rect);
        [DllImport("user32.dll")]
        public static extern int SetWindowPos(IntPtr handle, int insertAfter, int x, int y, int width, int height, int flags);
        [DllImport("user32.dll")]
        public static extern int SetWindowText(IntPtr handle, string title);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr handle);
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr handle, int index, int newLong);
        [DllImport("user32.dll")]
        public static extern int ShowWindow(IntPtr handle, int cmd);
    }
}
