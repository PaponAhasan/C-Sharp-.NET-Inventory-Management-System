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
    public partial class Vendors : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Vendors()
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
            openChildForm(new NewVendor());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new VendorSearch());
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Email,Phone,Website,Address from Vendors where IID = '" + Login.Uid + "' ";
            //string Query = "Select * from Bills";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewVendor.DataSource = dtUsers;
            ObjDBAccess.closeConn();

            txtbx.Text = Login.Uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Email,Phone,Website,Address from Vendors";
           // string Query = "Select * from Bills";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");
        }
    }
}
