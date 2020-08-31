using System;
using System.Windows.Forms;
using System.Drawing;

namespace Temp
{
    partial class DotForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            this.BackColor = System.Drawing.Color.FromArgb(0, 255, 0);
            this.TransparencyKey = System.Drawing.Color.FromArgb(0, 255, 0);
            //this.DoubleBuffered = true;
            this.Text = "The Dot";
        }
    }
}