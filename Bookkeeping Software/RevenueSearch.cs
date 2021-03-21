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
    public partial class RevenueSearch : Form
    {
        public Point mouseLocation;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public RevenueSearch()
        {
            InitializeComponent();
        }

        private void RevenueSearch_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void RevenueSearch_MouseMove(object sender, MouseEventArgs e)
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

        private void RevenueSearch_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "") SearchBox.Text = "Search";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Revenues where ( Date LIKE '" + SearchBox.Text + "%' or Customer LIKE '" + SearchBox.Text + "%'  or ID LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewRevenue.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string Query = "Select * from Revenues where ( Date LIKE '" + SearchBox.Text + "%' or Customer LIKE '" + SearchBox.Text + "%'  or ID LIKE '" + SearchBox.Text + "%') and IID = '" + Login.Uid + "'";
                //string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
                //ObjDBAccess.readDatathroughReader(Query);
                DataGridViewRevenue.DataSource = dtUsers;
                ObjDBAccess.closeConn();
            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var dt = DataGridViewRevenue.DataSource as DataTable;
            dt.Rows.Clear();
            DataGridViewRevenue.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Date,Amount,Customer,Description,Receivable,Category from Revenues";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");


            //// Profit
            //int Revenues = 0;
            //for (int i = 0; i < DataGridViewRevenue.Rows.Count; i++)
            //{
            //    Revenues += Convert.ToInt32(DataGridViewRevenue.Rows[i].Cells[2].Value);
            //}

            ////Revenues = Convert.ToInt32(Invoices.Total_Sum) - Revenues;


            ////string Total_Receivables = Revenues.ToString();
            //string Total_INCOME = Revenues.ToString();

            //string query = "Update Dashboard SET TINCOME = '" + @Total_INCOME + "' Where Email = '" + Login.CEmail + "' ";

            //SqlCommand updateCommand = new SqlCommand(query);

            //updateCommand.Parameters.AddWithValue("@Total_INCOME", Total_INCOME);
            //int row = ObjDBAccess.executeQuery(updateCommand);
            //if (row == 1)
            //{
            //    //MessageBox.Show("Account Info Update Successfully.");
            //    //blUpdate.Text = "Account Info Update Successfully.";
            //}

        }
    }
}
