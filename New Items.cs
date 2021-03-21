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
    public partial class NewItems : Form
    {
        public static string Iid;
        DBAccess ObjDBAccess = new DBAccess();
        public Point mouseLocation;
        public NewItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtTax.Text == "" || txtSale.Text == "" || txtPurchase.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Please field required.");
            }
            else if(txtID.Text != Login.Uid){
                MessageBox.Show("Enter Your valid ID.");
            }
            else
            {
                string Iid = txtID.Text;
                string IName = txtName.Text;
                string ITax = txtTax.Text;
                string IDescription = txtDescription.Text;
                string ISalePrice = txtSale.Text;
                string IPurchase = txtPurchase.Text;
                string ISelectCategor = SelectCategory.Text;

                SqlCommand insertCommand = new SqlCommand("insert into Items(Name,Tax,Description,SalePrice,PurchasePrice,Category,IID) values(@IName,@ITax,@IDescription,@ISalePrice,@IPurchase,@ISelectCategor,@Iid)");

                insertCommand.Parameters.AddWithValue("@IName", IName);
                insertCommand.Parameters.AddWithValue("@ITax", ITax);
                insertCommand.Parameters.AddWithValue("@IDescription", IDescription);
                insertCommand.Parameters.AddWithValue("@ISalePrice", ISalePrice);
                insertCommand.Parameters.AddWithValue("@IPurchase", IPurchase);
                insertCommand.Parameters.AddWithValue("@ISelectCategor", ISelectCategor);
                insertCommand.Parameters.AddWithValue("@Iid", Iid);

                int row = ObjDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Item Add Successfully.");
                }
                this.Hide();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                txtName.Text = "Enter Name";
        }

        private void txtTax_Enter(object sender, EventArgs e)
        {
            txtTax.Text = "";
        }
        private void txtTax_Leave(object sender, EventArgs e)
        {
            if (txtTax.Text == "")
                txtTax.Text = "- Select Tax -";
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
        private void txtSale_Enter(object sender, EventArgs e)
        {
           txtSale.Text = "";
        }
        private void txtSale_Leave(object sender, EventArgs e)
        {
            if (txtSale.Text == "")
                txtSale.Text = "Enter Sale Price";
        }
        private void txtPurchase_Enter(object sender, EventArgs e)
        {
           txtPurchase.Text = "";
        }
        private void txtPurchase_Leave(object sender, EventArgs e)
        {
            if (txtPurchase.Text == "")
                txtPurchase.Text = "Enter Purchase Price";
        }
        private void Select_Category_Enter(object sender, EventArgs e)
        {
            SelectCategory.Text = "";
        }
        private void SelectCategory_Leave(object sender, EventArgs e)
        {
            if (SelectCategory.Text == "")
                SelectCategory.Text = "SelectCategory";
        }
        private void Picture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           ItemPicture.Text = "";
        }
        private void txtID_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text == "")
               txtID.Text = "Enter Your Valid ID";
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            //if (txtName.Text == "") txtName.Text = "Enter Name";
            //if (txtTax.Text == "") txtTax.Text = "- Select Tax -";
            //if (txtDescription.Text == "") txtDescription.Text = "Enter Description";
            //if (txtSale.Text == "") txtSale.Text = "Enter Sale Price";
            //if (txtPurchase.Text == "") txtPurchase.Text = "Enter Purchase Price";
            //if (Select_Category.Text == "") Select_Category.Text = "_ Select Category _";
            //if (Picture.Text == "") Picture.Text = "Picture";
        }

        private void NewItems_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void NewItems_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureItem.Image = new Bitmap(opnfd.FileName);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewItems_Load(object sender, EventArgs e)
        {
            txtID.Text = Login.Uid;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
