using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Valet_Parking_System.SubForms.Widgets
{
    public partial class RoundedWidget : UserControl
    {
        private string Heading = "None";
        private string Value = "0";
        private int cornerRadius = 20;

        [Category("Custom Settings")]
        [Description("Corner radius in pixels (6-40).")]
        [Browsable(true)]
        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = Math.Clamp(value, 6, 40);
                UpdateRegion();
                Invalidate();
            }
        }

        [Category("Custom Settings")]
        [Description("Heading text shown at the top of the widget.")]
        [Browsable(true)]
        public string SetHeading
        {
            get => Heading;
            set
            {
                Heading = value;
                if (HeadingLabel != null) HeadingLabel.Text = value;
                Invalidate();
            }
        }

        [Category("Custom Settings")]
        [Description("Numeric or status value shown in the widget.")]
        [Browsable(true)]
        public string SetValue
        {
            get => Value;
            set
            {
                Value = value;
                if (ValueLabel != null) ValueLabel.Text = value;
                Invalidate();
            }
        }

        public RoundedWidget()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            BorderStyle = BorderStyle.None;
            BackColor = Color.White;
            UpdateRegion();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent?.BackColor ?? Color.LightGray);

            RectangleF rect = ClientRectangle;
            using (GraphicsPath path = GetRoundedRectPath(rect, CornerRadius))
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                g.FillPath(brush, path);
            }

            base.OnPaint(e);
        }

        private void UpdateRegion()
        {
            using (GraphicsPath path = GetRoundedRectPath(ClientRectangle, CornerRadius))
            {
                Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedRectPath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2f;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);           // Top-left
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);   // Top-right
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);  // Bottom-right
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);   // Bottom-left
            path.CloseFigure();
            return path;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}
