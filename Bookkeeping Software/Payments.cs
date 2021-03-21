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
    public partial class Payments : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Payments()
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
            openChildForm(new NewPayment());
            //NewPayment P = new NewPayment();
            //P.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new PaymentSearch());
            //PaymentSearch S = new PaymentSearch();
            //S.Show();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            string Query = "Select ID,Date,Amount,Vendor,Description,Payables,Category from Payments where IID = '" + Login.Uid + "' ";
            //string Query = "Select * from Payments ";
            
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewPayments.DataSource = dtUsers;
            ObjDBAccess.closeConn();

            txtbx.Text = Login.Uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Query = "Select ID,Date,Amount,Vendor,Description,Payables,Category from Payments";
            //string Query = "Select * from Payments ";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");


            int Payments = 0;
            for (int i = 0; i < DataGridViewPayments.Rows.Count; i++)
            {
                Payments += Convert.ToInt32(DataGridViewPayments.Rows[i].Cells[2].Value);
            }

            int Payables = 0;
            for (int i = 0; i < DataGridViewPayments.Rows.Count; i++)
            {
                Payables += Convert.ToInt32(DataGridViewPayments.Rows[i].Cells[5].Value);
            }

            string Total_EXPENSES = Payments.ToString();
            string Total_Payables = Payables.ToString();

            string query = "Update Dashboard SET TEXPENSES = '" + @Total_EXPENSES + "',Payables = '" + @Total_Payables +"' Where Email = '" + Login.CEmail + "' ";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@Total_EXPENSES", Total_EXPENSES);
            updateCommand.Parameters.AddWithValue("@Total_Payables", Total_Payables);
            int row = ObjDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                //MessageBox.Show("Account Info Update Successfully.");
                //blUpdate.Text = "Account Info Update Successfully.";
            }
        }
    }
}
