using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowSizer.Forms
{
    public struct WindowInfo
    {
        public IntPtr Handle { get; set; }
        public Process Process { get; set; }

        public WindowInfo(IntPtr handle, Process process)
        {
            Handle = handle;
            Process = process;
        }
    }

    public partial class Main : Form
    {
        private Dictionary<string, WindowInfo> _windows = new Dictionary<string, WindowInfo>();
        private IntPtr _selectedHandle = IntPtr.Zero;

        public Main()
        {
            InitializeComponent();
        }
        private void UserSettingMode_CheckedChanged(object sender, EventArgs e)
        {
            WindowWidth.Enabled = UserSettingMode.Checked;
            WindowHeight.Enabled = UserSettingMode.Checked;
            WindowHideTaskBar.Enabled = !UserSettingMode.Checked;
            WindowPosX.Enabled = UserSettingMode.Checked;
            WindowPosY.Enabled = UserSettingMode.Checked;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(WindowSearchBox.Text);
            _windows.Clear();
            WindowList.Items.Clear();

            if (processes.Length > 0)
            {
                for (int i = 0; i < processes.Length; ++i)
                {
                    string name = processes[i].MainWindowTitle + $" [PID : {processes[i].Id}]";
                    WindowList.Items.Add(name);
                    _windows.Add(name, new WindowInfo(processes[i].MainWindowHandle, processes[i]));
                }
            }
        }
        private void SelectWindow_Click(object sender, EventArgs e)
        {

        }
        private void WindowActive_Click(object sender, EventArgs e)
        {

        }
        private void WindowMiniSize_Click(object sender, EventArgs e)
        {

        }
        private void WindowClose_Click(object sender, EventArgs e)
        {

        }
        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
