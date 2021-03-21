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
    public partial class BillSearch : Form
    {
        public Point mouseLocation;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public BillSearch()
        {
            InitializeComponent();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SearchBox_DoubleClick(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void BillSearch_Load(object sender, EventArgs e)
        {
           
        }

        private void BillSearch_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "") SearchBox.Text = "Search";
        }

        private void BillSearch_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            
        }

        private void BillSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var dt = DataGridViewBill.DataSource as DataTable;
            dt.Rows.Clear();
            DataGridViewBill.DataSource = dt;
            //DataGridViewItems.Columns.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Bills where BillDate LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' or Name LIKE '" + SearchBox.Text + "%' or Vendor LIKE '" + SearchBox.Text + "%'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewBill.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Bills where BillDate LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' or Name LIKE '" + SearchBox.Text + "%' or Vendor LIKE '" + SearchBox.Text + "%'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewBill.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }
    }
}
