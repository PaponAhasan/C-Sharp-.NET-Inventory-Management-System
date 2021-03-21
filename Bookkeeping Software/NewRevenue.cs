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
    public partial class NewRevenue : Form
    {
        public static string Iid;
        DBAccess ObjDBAccess = new DBAccess();
        public Point mouseLocation;
        public NewRevenue()
        {
            InitializeComponent();
        }

        private void NewRevenue_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void NewRevenue_MouseMove(object sender, MouseEventArgs e)
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

        private void NewRevenue_Load(object sender, EventArgs e)
        {
            txtID.Text = Login.Uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "" || txtAmount.Text == "" || txtInvoice.Text == "")
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
                string ICuestomer = txtCustomer.Text;
                string IDate = txtDate.Text;
                string IAmount = txtAmount.Text;
                string IDescription = txtDescription.Text;
                string IInvoice = txtInvoice.Text;
                string ISelectCategor = SelectCategory.Text;

                SqlCommand insertCommand = new SqlCommand("insert into Revenues(Date,Amount,Customer,Description,Receivable,Category,IID) values(@IDate,@IAmount,@ICuestomer,@IDescription,@IInvoice,@ISelectCategor,@Iid)");

                insertCommand.Parameters.AddWithValue("@IDate", IDate);
                insertCommand.Parameters.AddWithValue("@ICuestomer", ICuestomer);
                insertCommand.Parameters.AddWithValue("@IDescription", IDescription);
                insertCommand.Parameters.AddWithValue("@IAmount", IAmount);
                insertCommand.Parameters.AddWithValue("@IInvoice", IInvoice);
                insertCommand.Parameters.AddWithValue("@ISelectCategor", ISelectCategor);
                insertCommand.Parameters.AddWithValue("@Iid", Iid);

                int row = ObjDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Revenue Add Successfully.");
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

        private void txtCustomer_Enter(object sender, EventArgs e)
        {
            txtCustomer.Text = "";
        }

        private void txtCustomer_Leave(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "") txtCustomer.Text = "-Select Customer-";
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

        private void txtInvoice_Enter(object sender, EventArgs e)
        {
            txtInvoice.Text = "";
        }

        private void txtInvoice_Leave(object sender, EventArgs e)
        {
            if (txtInvoice.Text == "") txtInvoice.Text = "Enter Receivable";
        }
    }
}
