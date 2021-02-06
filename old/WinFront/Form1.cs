using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFront
{
    public partial class BrowserWindow : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public BrowserWindow()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Close Button
        private void WindowCloseButton_MouseEnter(object sender, EventArgs e) { WindowCloseButton.BackColor = Color.Red; }
        private void WindowCloseButton_MouseLeave(object sender, EventArgs e) { WindowCloseButton.BackColor = Color.Black; }
        private void WindowCloseButton_Click(object sender, EventArgs e) { Environment.Exit(0); }

        //MaximizeButton
        private void WindowMinMaxButton_MouseEnter(object sender, EventArgs e) { WindowMinMaxButton.BackColor = Color.Gray; }
        private void WindowMinMaxButton_MouseLeave(object sender, EventArgs e) { WindowMinMaxButton.BackColor = Color.Black; }
        private void WindowMinMaxButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void WindowMinButton_MouseEnter(object sender, EventArgs e) { WindowMinButton.BackColor = Color.Gray; }
        private void WindowMinButton_MouseLeave(object sender, EventArgs e) { WindowMinButton.BackColor = Color.Black; }
        private void WindowMinButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
    }
}
