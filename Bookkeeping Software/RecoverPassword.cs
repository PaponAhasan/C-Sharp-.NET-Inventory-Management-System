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
    public partial class RecoverPassword : Form
    {
        public Point mouseLocation;
        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void REmail_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void REmail_Enter(object sender, EventArgs e)
        {
            REmail.Text = "";
        }

        private void REmail_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void RecoverPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void RecoverPassword_MouseDown(object sender, MouseEventArgs e)
        {

            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximizee(this, btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookkeeping.Minimize(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bookkeeping.Exit();
        }
    }
}
