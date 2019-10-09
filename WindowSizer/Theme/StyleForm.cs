using System.Drawing;
using System.Windows.Forms;

namespace WindowSizer.Theme
{
    public partial class StyleForm : UserControl
    {
        public TitleBar TitleBar { get; private set; }
        private Panel _line;

        public StyleForm()
        {
            InitializeComponent();
        }

        public void Init(Form form)
        {
            TitleBar = new TitleBar(form);
            form.Controls.Add(TitleBar);
            TitleBar.Location = new Point(0, 0);
            TitleBar.Width = form.Width;
            TitleBar.BringToFront();
            TitleBar.TitleText = form.Text;

            _line = new Panel();
            form.Controls.Add(_line);
            _line.Location = new Point(0, 0);
            _line.Width = form.Width;
            _line.Height = form.Height;
            _line.BorderStyle = BorderStyle.FixedSingle;
            _line.SendToBack();

            this.Hide();
        }

        private void StyleForm_Load(object sender, System.EventArgs e)
        {
            if (!(ParentForm is null))
            {
                Init(ParentForm);
            }
        }
    }
}
