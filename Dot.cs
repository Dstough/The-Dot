using System;
using System.Drawing;
using System.Windows.Forms;

namespace Temp
{
    public partial class DotForm : Form
    {
        private int dotSize = 7;
        private int heightOffset = -30;
        private int widthOffset = 0;

        public DotForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using var myBrush = new Pen(Color.Red);
            using var formGraphics = this.CreateGraphics();

            formGraphics.DrawEllipse(myBrush, new Rectangle(Screen.PrimaryScreen.Bounds.Width / 2 - dotSize + widthOffset, Screen.PrimaryScreen.Bounds.Height / 2 - dotSize + heightOffset , dotSize, dotSize));
        }

    }
}