using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookkeeping_Software
{
    public partial class Cover_Page : Form
    {
        public Point mouseLocation;
        public Cover_Page()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void Cover_Page_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Cover_Page_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bookkeeping.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookkeeping.Minimize(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximizee(this, btn);
        }
    }
}

