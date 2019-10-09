using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowSizer.Theme
{
    public partial class TitleBar : UserControl
    {
        public delegate void FormCloseEvent();
        public event FormCloseEvent CloseEvent = null;
        public bool IsMoved { get; set; }

        private Form _target;
        private bool _hold;
        private Point _formLocation;
        private Point _lastLocation;
        private Point _curLocation;

        public string TitleText
        {
            get
            {
                return TitleName.Text;
            }

            set
            {
                TitleName.Text = value;
            }
        }

        [DllImport("user32.dll")]
        public extern static void GetCursorPos(out Point point);

        public TitleBar(Form target)
        {
            InitializeComponent();

            IsMoved = true;
            _target = target;
            TitleName.MouseDown += MouseDownEvent;
            TitleName.MouseUp += MouseUpEvent;
            TitleName.MouseMove += MouseMoveEvent;
            this.MouseDown += MouseDownEvent;
            this.MouseUp += MouseUpEvent;
            this.MouseMove += MouseMoveEvent;

            this.Location = new Point(0, 0);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (CloseEvent != null)
            {
                CloseEvent.Invoke();
                return;
            }
            _target.Close();
            _target.Dispose();
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (!IsMoved)
            {
                return;
            }

            _hold = true;
            GetCursorPos(out _curLocation);
            _formLocation = _target.Location;
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            _hold = false;
        }
        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (_hold)
            {
                GetCursorPos(out _lastLocation);
                _formLocation.X -= (_curLocation.X - _lastLocation.X);
                _formLocation.Y -= (_curLocation.Y - _lastLocation.Y);
                _target.Location = _formLocation;
                _curLocation = _lastLocation;
            }
        }
    }
}
