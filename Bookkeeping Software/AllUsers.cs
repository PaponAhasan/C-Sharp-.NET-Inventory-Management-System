using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bookkeeping_Software
{
    public partial class AllUsers : Form
    {
        public Point mouseLocation;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public AllUsers()
        {
            InitializeComponent();
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            string Query = "Select Users,Email,Roles,Phone from Users where Id = '" + Login.Uid + "' ";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            dataGridViewUsers.DataSource = dtUsers;
            ObjDBAccess.closeConn();
        }

        private void AllUsers_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void AllUsers_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        //private void label8_Click(object sender, EventArgs e)
        //{
            //this.Close();
        //}

        private void Close_Click(object sender, EventArgs e)
        {
            //Bookkeeping.Exit();
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void MIN_Click(object sender, EventArgs e)
        {
            Bookkeeping.Minimize(this);
        }

        private void MAX_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximize(this, btn);
        }
    }
}