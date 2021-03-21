using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookkeeping_Software
{
    public partial class ProfileView : Form
    {
        public Point mouseLocation;
        Bookkeeping BG = new Bookkeeping();
        public ProfileView()
        {
            InitializeComponent();
        }

        private void ProfileView_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void ProfileView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Your_Profile L = new Your_Profile();
            L.Show();
            this.Close();
            Dashboard newform = (Dashboard)Application.OpenForms["Dashboard"];
            newform.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Close();
            Dashboard newform = (Dashboard)Application.OpenForms["Dashboard"];
            newform.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AllUsers L = new AllUsers();
            L.Show();
            this.Close();
            Dashboard newform = (Dashboard)Application.OpenForms["Dashboard"];
            newform.Close();
        }
    }
}
