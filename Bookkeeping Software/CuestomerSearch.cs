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
    public partial class CuestomerSearch : Form
    {
        public Point mouseLocation;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public CuestomerSearch()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Cuestomers where ( Name LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' or Email LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewInvoices.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Cuestomers where ( Name LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' or Email LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewInvoices.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var dt = DataGridViewInvoices.DataSource as DataTable;
            dt.Rows.Clear();
            DataGridViewInvoices.DataSource = dt;
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

        private void CuestomerSearch_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "") SearchBox.Text = "Search";
        }
    }
}
