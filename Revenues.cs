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
    public partial class Revenues : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Revenues()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFrom.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NewRevenue());
            //NewRevenue N = new NewRevenue();
            //N.Show();
        }

        private void Revenues_Load(object sender, EventArgs e)
        {
            string Query = "Select ID,Date,Amount,Customer,Description,Receivable,Category from Revenues where IID = '" + Login.Uid + "' ";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewRevenues.DataSource = dtUsers;
            ObjDBAccess.closeConn();

            txtbx.Text = Login.Uid;

            //string tid = txtbx.Text;
            ////string query = "Select IID from Dashboard Where IID = '" + Login.Uid + "' ";
            ////ObjDBAccess.readDatathroughAdapter(query, dtUsers);
            ////if (dtUsers.Rows.Count == 1)
            ////{
            ////    //...
            //////}
            //////else
            ////{
            //    SqlCommand insertCommand = new SqlCommand("insert into Dashboard(IID) values(@tid)");
            //    insertCommand.Parameters.AddWithValue("@tid", tid);
            //    int row = ObjDBAccess.executeQuery(insertCommand);
            //    ObjDBAccess.closeConn();
            //    //}
            }

        private void button2_Click(object sender, EventArgs e)
        {

            string Query = "Select ID,Date,Amount,Customer,Description,Receivable,Category from Revenues";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");


            // Profit
            int Revenues = 0;
            for (int i = 0; i < DataGridViewRevenues.Rows.Count; i++)
            {
                Revenues += Convert.ToInt32(DataGridViewRevenues.Rows[i].Cells[2].Value);
            }

            int Receivable = 0;

            for (int i = 0; i < DataGridViewRevenues.Rows.Count; i++)
            {
                Receivable += Convert.ToInt32(DataGridViewRevenues.Rows[i].Cells[5].Value);
            }

            //Revenues = Convert.ToInt32(Invoices.Total_Sum) - Revenues;


            //string Total_Receivables = Revenues.ToString();
            string Total_INCOME = Revenues.ToString();
            string Receivables = Receivable.ToString();

            string query = "Update Dashboard SET TINCOME = '" + @Total_INCOME + "',Receivables = '" + @Receivables + "' Where Email = '" + Login.CEmail + "' ";

            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@Total_INCOME", Total_INCOME);
            updateCommand.Parameters.AddWithValue("@Receivables", Receivables);
            int row = ObjDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                //MessageBox.Show("Account Info Update Successfully.");
                //blUpdate.Text = "Account Info Update Successfully.";
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new RevenueSearch());
            //RevenueSearch R = new RevenueSearch();
            //R.Show();
        }
    }
}
