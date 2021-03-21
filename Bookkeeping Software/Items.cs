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
    public partial class Items : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Items()
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

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NewItems());
            // this.Hide();
            //NewItems f = new NewItems();
            //f.Show();
            // openChildForm(new NewItems());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new ItemSearch());
            //ItemSearch I = new ItemSearch();
            //I.Show();
            //this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Tax,Description,PurchasePrice,SalePrice,Category from Items where IID = '" + Login.Uid +"' ";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewItems.DataSource = dtUsers;
            ObjDBAccess.closeConn();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Name,Tax,Description,PurchasePrice,SalePrice,Category from Items";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");

        }
    }
}
