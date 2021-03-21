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
    public partial class ItemSearch : Form
    {
        public Point mouseLocation;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public ItemSearch()
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

        private void ItemSearch_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "") SearchBox.Text = "Search";
        }

        private void ItemSearch_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void DataGridViewInvoices_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var dt = DataGridViewInvoices.DataSource as DataTable;
            dt.Rows.Clear();
            DataGridViewInvoices.DataSource = dt;
            //DataGridViewItems.Columns.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Items where (Name LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewInvoices.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Items where (Name LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewInvoices.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void ItemSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Tax,Description,PurchasePrice,SalePrice,Category from Items";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");
        }
    }
}
