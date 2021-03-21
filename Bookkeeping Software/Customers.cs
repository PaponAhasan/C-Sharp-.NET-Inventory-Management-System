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
    public partial class Customers : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Customers()
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

        private void btnNcustomersOpen_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCuestomer());
           // NewCuestomer O = new NewCuestomer();
            //O.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new CuestomerSearch());
            //CuestomerSearch C = new CuestomerSearch();
            //C.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Image,Email,Phone,Website,Address from Cuestomers where IID = '" + Login.Uid + "' ";
            //string Query = "Select * from Bills";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewCustomers.DataSource = dtUsers;
            ObjDBAccess.closeConn();

            txtbx.Text = Login.Uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Image,Email,Phone,Website,Address from Cuestomers";
            //string Query = "Select * from Bills";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");
        }
    }
}
