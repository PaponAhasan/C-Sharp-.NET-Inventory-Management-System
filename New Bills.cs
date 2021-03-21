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
using System.Drawing.Printing;

namespace Bookkeeping_Software
{
    public partial class New_Bills : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument printdoc = new PrintDocument();
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Point mouseLocation;
        public New_Bills()
        {
            InitializeComponent();
        }

        private void New_Bills_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            
        }

        private void New_Bills_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBiil_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureBiil.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void BillPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                BillPicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtBill.Text == "" || txtPrice.Text == "" || txtBill.Text == "" || txtID.Text == "")
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
                string IName = txtName.Text;
                string ITax = txtTax.Text;
                string IVendor = txtVendor.Text;
                string IBillDate = txtBill.Text;
                string IBillNumber = txtBillNumber.Text;
                string ISelectCategor = txtCategory.Text;
                string IQuantity = txtQuantity.Text;
                string IPrice = txtPrice.Text;
                string ITotal = txtTotal.Text;

                SqlCommand insertCommand = new SqlCommand("insert into Bills(Vendor,Name,BillDate,BillNumber,Quantity,Price,Tax,Category,Total,IID) values(@IVendor,@IName,@IBillDate,@IBillNumber,@IQuantity,@IPrice,@ITax,@ISelectCategor,@ITotal,@Iid)");

                insertCommand.Parameters.AddWithValue("@IVendor", IVendor);
                insertCommand.Parameters.AddWithValue("@IName", IName);
                insertCommand.Parameters.AddWithValue("@IBillDate", IBillDate);
                insertCommand.Parameters.AddWithValue("@IBillNumber", IBillNumber);
                insertCommand.Parameters.AddWithValue("@IQuantity", IQuantity);
                insertCommand.Parameters.AddWithValue("@IPrice", IPrice);
                insertCommand.Parameters.AddWithValue("@ITax", ITax);
                insertCommand.Parameters.AddWithValue("@ISelectCategor", ISelectCategor);
                insertCommand.Parameters.AddWithValue("@ITotal", ITotal);
                insertCommand.Parameters.AddWithValue("@Iid", Iid);

                int row = ObjDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Vendor Add Successfully.");
                }
                this.Hide();
            }
        }

        private void txtVendor_Enter(object sender, EventArgs e)
        {
            txtVendor.Text = "";
        }

        private void txtVendor_Leave(object sender, EventArgs e)
        {
            if (txtVendor.Text == "")
                txtVendor.Text = "-Select Vendor -";
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

        private void txtBill_Enter(object sender, EventArgs e)
        {
            txtBill.Text = "";
        }

        private void txtBill_Leave(object sender, EventArgs e)
        {
            if (txtBill.Text == "")
                txtBill.Text = "2020 - 07 - 04";
        }

        private void txtBillNumber_Enter(object sender, EventArgs e)
        {
            txtBillNumber.Text = "";
        }

        private void txtBillNumber_Leave(object sender, EventArgs e)
        {
            if (txtBillNumber.Text == "") txtBillNumber.Text = "Enter Invoice Number";
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
                txtQuantity.Text = "000";
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.Text = "";
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if(txtPrice.Text == "")
                txtPrice.Text = "$0.00";
        }

        private void txtTax_Enter(object sender, EventArgs e)
        {
            txtTax.Text = "";
        }

        private void txtTax_Leave(object sender, EventArgs e)
        {
            if (txtTax.Text == "")
                txtTax.Text = "-Select Tax-";
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            txtTotal.Text = "";
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
                txtTotal.Text = "$0.00";
        }

        private void New_Bills_Load(object sender, EventArgs e)
        {
            txtID.Text = Login.Uid;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getPrintarea(pnl);
            prntprvw.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printpage);
            prntprvw.ShowDialog();
        }

        public void printdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        Bitmap memoryimg;

        public void getPrintarea(Panel DG)
        {
            memoryimg = new Bitmap(DG.Width, DG.Height);
            DG.DrawToBitmap(memoryimg, new Rectangle(0, 0, DG.Width, DG.Height));
        }
    }
}
