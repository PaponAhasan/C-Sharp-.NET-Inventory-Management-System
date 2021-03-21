using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bookkeeping_Software
{
    public partial class PaymentSearch : Form
    {
        public Point mouseLocation;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public PaymentSearch()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentSearch_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            
        }

        private void DataGridViewPayments_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SearchBox_DoubleClick(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void PaymentSearch_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "") SearchBox.Text = "Search";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Payments where ( Date LIKE '" + SearchBox.Text + "%' or Vendor LIKE '" + SearchBox.Text + "%'  or ID LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewPayments.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Payments where ( Date LIKE '" + SearchBox.Text + "%' or Vendor LIKE '" + SearchBox.Text + "%'  or ID LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewPayments.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var dt = DataGridViewPayments.DataSource as DataTable;
            dt.Rows.Clear();
            DataGridViewPayments.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Date,Amount,Vendor,Description,Payables,Category from Payments";
            //string Query = "Select * from Payments ";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");


            //int Payments = 0;
            //for (int i = 0; i < DataGridViewPayments.Rows.Count; i++)
            //{
            //    Payments += Convert.ToInt32(DataGridViewPayments.Rows[i].Cells[2].Value);
            //}

            //string Total_EXPENSES = Payments.ToString();

            //string query = "Update Dashboard SET TEXPENSES = '" + @Total_EXPENSES + "' Where Email = '" + Login.CEmail + "' ";
            //SqlCommand updateCommand = new SqlCommand(query);
            //updateCommand.Parameters.AddWithValue("@Total_EXPENSES", Total_EXPENSES);
            //int row = ObjDBAccess.executeQuery(updateCommand);
            //if (row == 1)
            //{
            //    //MessageBox.Show("Account Info Update Successfully.");
            //    //blUpdate.Text = "Account Info Update Successfully.";
            //}
        }
    }
}
