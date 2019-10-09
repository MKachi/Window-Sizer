using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using WindowSizer.Base;
using System.Linq;

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
        private List<WindowInfo> _windows = new List<WindowInfo>();
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
            Process[] processes = Process.GetProcesses();
            Process[] findProcess = (from process in processes
                                     where process.MainWindowTitle.Contains(WindowSearchBox.Text)
                                     select process).ToArray();

            _windows.Clear();
            WindowList.Items.Clear();

            if (findProcess.Length > 0)
            {
                for (int i = 0; i < findProcess.Length; ++i)
                {
                    string name = findProcess[i].MainWindowTitle + $" [PID : {findProcess[i].Id}]";
                    WindowList.Items.Add(name);
                    _windows.Add(new WindowInfo(findProcess[i].MainWindowHandle, findProcess[i]));
                }
            }
        }
        private void SelectWindow_Click(object sender, EventArgs e)
        {
            if (_selectedHandle.Equals(IntPtr.Zero))
            {
                return;
            }
            User32.SetForegroundWindow(_selectedHandle);
        }
        private void WindowActive_Click(object sender, EventArgs e)
        {
            if (_selectedHandle.Equals(IntPtr.Zero))
            {
                return;
            }
            User32.ShowWindow(_selectedHandle, 9);
            User32.SetForegroundWindow(_selectedHandle);
        }
        private void WindowMiniSize_Click(object sender, EventArgs e)
        {
            if (_selectedHandle.Equals(IntPtr.Zero))
            {
                return;
            }
            User32.ShowWindow(_selectedHandle, 2);
            User32.SetForegroundWindow(_selectedHandle);
        }
        private void WindowClose_Click(object sender, EventArgs e)
        {
            if (_selectedHandle.Equals(IntPtr.Zero))
            {
                return;
            }
            Process process = _windows[WindowList.SelectedIndex].Process;
            process.CloseMainWindow();
        }
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (_selectedHandle.Equals(IntPtr.Zero))
            {
                return;
            }

            if (UserSettingMode.Checked)
            {
                int temp;
                if (WindowWidth.Text.Equals(string.Empty))
                {
                    MessageBox.Show("넓이를 지정해주세요.", "Window Sizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (WindowHeight.Text.Equals(string.Empty))
                {
                    MessageBox.Show("높이를 지정해주세요.", "Window Sizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (WindowPosX.Text.Equals(string.Empty))
                {
                    MessageBox.Show("X 좌표를 지정해주세요.", "Window Sizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (WindowPosY.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Y 좌표를 지정해주세요.", "Window Sizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!int.TryParse(WindowPosX.Text, out temp))
                {
                    MessageBox.Show("X 좌표의 값이 올바르지 않습니다.", "Window Sizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!int.TryParse(WindowPosY.Text, out temp))
                {
                    MessageBox.Show("Y 좌표의 값이 올바르지 않습니다.", "Window Sizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!UserSettingMode.Checked)
            {
                WindowLib.SetFullScreenWindowMode(_selectedHandle, WindowTitleHide.Checked, !WindowHideTaskBar.Checked);
                return;
            }

            if (FullScreenMode.Checked)
            {
                WindowLib.SetWindowSize(_selectedHandle, int.Parse(WindowWidth.Text), int.Parse(WindowHeight.Text), int.Parse(WindowPosX.Text), int.Parse(WindowPosY.Text), WindowTitleHide.Checked);
                return;
            }
        }

        private void WindowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_windows.Count <= WindowList.SelectedIndex)
            {
                return;
            }
            _selectedHandle = _windows[WindowList.SelectedIndex].Handle;
        }
    }
}