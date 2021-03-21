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
    public partial class NewCuestomer : Form
    {
        public static string Iid;
        DBAccess ObjDBAccess = new DBAccess();
        public Point mouseLocation;
        public NewCuestomer()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Please field required.");
            }
            else if (txtID.Text != Login.Uid)
            {
                MessageBox.Show("Enter Your valid ID.");
            }
            else
            {
                ImageConverter img = new ImageConverter();
                byte[] image = (byte[])img.ConvertTo(BrowsePicture.Image, Type.GetType("System.Byte[]"));

                string Iid = txtID.Text;
                string IName = txtName.Text;
                string IEmail = txtEmail.Text;
                string IAddress = txtAddress.Text;
                string IPhone = txtPhone.Text;
                string IWebsite = txtWebsite.Text;
                string IPath = PathImage.Text;

                SqlCommand insertCommand = new SqlCommand("insert into Cuestomers(Name,Email,Phone,Website,Address,IID,Image,FileName) values(@IName,@IEmail,@IPhone,@IWebsite,@IAddress,@Iid,@Image,@IPath)");

                insertCommand.Parameters.AddWithValue("@IName", IName);
                insertCommand.Parameters.AddWithValue("@IEmail", IEmail);
                insertCommand.Parameters.AddWithValue("@IAddress", IAddress);
                insertCommand.Parameters.AddWithValue("@IPhone", IPhone);
                insertCommand.Parameters.AddWithValue("@IWebsite", IWebsite);
                insertCommand.Parameters.AddWithValue("@Iid", Iid);
                insertCommand.Parameters.AddWithValue("@Image", image);
                insertCommand.Parameters.AddWithValue("@IPath", IPath);

                int row = ObjDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Cuestomer Add Successfully.");
                }
                this.Hide();
            }
        }

        private void NewCuestomer_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void NewCuestomer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void PictureInvoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PathImage.Text = opnfd.FileName;
                BrowsePicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void InvoicePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PathImage.Text = opnfd.FileName;
                BrowsePicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void NewCuestomer_Load(object sender, EventArgs e)
        {
            txtID.Text = Login.Uid;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "") txtEmail.Text = "Enter Email";
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text=="") txtName.Text = "Enter Name";
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            txtPhone.Text = "";
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if(txtPhone.Text == "") txtPhone.Text = "Enter Phone Number";
        }

        private void txtWebsite_Enter(object sender, EventArgs e)
        {
            txtWebsite.Text = "";
        }

        private void txtWebsite_Leave(object sender, EventArgs e)
        {
            if (txtWebsite.Text == "") txtWebsite.Text = "Enter Website";
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.Text = "";
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") txtAddress.Text = "Enter Address";
        }
    }
}
