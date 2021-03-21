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
    public partial class ShowProfile : Form
    {

        public Point mouseLocation;
        public ShowProfile(Image pic1)
        {
            InitializeComponent();
            pictureBox.Image = pic1;
            CN.Text = Your_Profile.CN;
            FN.Text = Your_Profile.FN;
            LN.Text = Your_Profile.LN;
            E.Text = Your_Profile.E;
            BD.Text = Your_Profile.BD;
            P.Text = Your_Profile.P;
            G.Text = Your_Profile.G;
        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Your_Profile f = new Your_Profile();
            //f.Show();
        }

        private void ShowProfile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void ShowProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bookkeeping.Minimize(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximize(this, btn);
        }
    }
    
}
