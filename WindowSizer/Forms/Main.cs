using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowSizer.Forms
{
    public struct WindowInfo
    {
        public string Title { get; set; }
        public IntPtr Handle { get; set; }
        public Process Process { get; set; }

        public WindowInfo(string title, IntPtr handle, Process process)
        {
            Title = title;
            Handle = handle;
            Process = process;
        }
    }

    public partial class Main : Form
    {
        private List<WindowInfo> _windows = new List<WindowInfo>();
        private IntPtr _selectedHandle = IntPtr.Zero;

        public Main()
        {
            InitializeComponent();
        }

        private void FindGameProcess()
        {
            Process[] processes = Process.GetProcesses();
        }
    }
}
