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
    public partial class NewPayment : Form
    {
        public static string Iid;
        DBAccess ObjDBAccess = new DBAccess();
        public Point mouseLocation;
        public NewPayment()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NewPayment_Load(object sender, EventArgs e)
        {
            txtID.Text = Login.Uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPayment_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            
        }

        private void NewPayment_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void ItemPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureItem.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void PictureItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureItem.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "" || txtAmount.Text == "" || txtVendor.Text == "")
            {
                MessageBox.Show("Please field required.");
            }
            else if (txtID.Text != Login.Uid)
            {
                MessageBox.Show("Enter Your valid ID.");
            }
            else
            {
                string Iid = txtID.Text;
                string IVendor = txtVendor.Text;
                string IDate = txtDate.Text;
                string IAmount = txtAmount.Text;
                string IDescription = txtDescription.Text;
                string IBill = txtBill.Text;
                string ISelectCategor = SelectCategory.Text;

                SqlCommand insertCommand = new SqlCommand("insert into Payments(Date,Amount,Vendor,Description,Payables,Category,IID) values(@IDate,@IAmount,@IVendor,@IDescription,@IBill,@ISelectCategor,@Iid)");

                insertCommand.Parameters.AddWithValue("@IDate", IDate);
                insertCommand.Parameters.AddWithValue("@IVendor", IVendor);
                insertCommand.Parameters.AddWithValue("@IDescription", IDescription);
                insertCommand.Parameters.AddWithValue("@IAmount", IAmount);
                insertCommand.Parameters.AddWithValue("@IBill", IBill);
                insertCommand.Parameters.AddWithValue("@ISelectCategor", ISelectCategor);
                insertCommand.Parameters.AddWithValue("@Iid", Iid);

                int row = ObjDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Payment Add Successfully.");
                }
                this.Hide();
            }
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {
            txtDate.Text = "";
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            if (txtDate.Text == "") txtDate.Text = "20202-07-07";
        }

        private void txtVendor_Enter(object sender, EventArgs e)
        {
            txtVendor.Text = "";
        }

        private void txtVendor_MouseLeave(object sender, EventArgs e)
        {
            if (txtVendor.Text == "") txtVendor.Text = "-Select Vendor-";
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            txtDescription.Text = "";
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
                txtDescription.Text = "Enter Description";
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
                txtAmount.Text = "Enter Amount";
        }

        private void txtBill_Enter(object sender, EventArgs e)
        {
            txtBill.Text = "";
        }

        private void txtBill_Leave(object sender, EventArgs e)
        {
            if (txtBill.Text == "") txtBill.Text = "Enter Bill";
        }
    }
}
