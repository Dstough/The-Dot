using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace Temp
{
    public partial class DotForm : Form
    {
        private int dotSize = 10;

        public DotForm()
        {
            InitializeComponent();

            var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using var myBrush = new SolidBrush(Color.Gray);
            using var formGraphics = this.CreateGraphics();

            formGraphics.FillEllipse(myBrush, new Rectangle(Screen.PrimaryScreen.Bounds.Width / 2 - dotSize, Screen.PrimaryScreen.Bounds.Height / 2 - dotSize, dotSize, dotSize));
        }

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
    }
}