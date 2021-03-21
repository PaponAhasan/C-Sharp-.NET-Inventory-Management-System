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
    public partial class Invoices : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument printdoc = new PrintDocument();
        public static string Total_Sum;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public static DataGridView dgv = new DataGridView();
        public Invoices()
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NewInvoices());
            //NewInvoices N = new NewInvoices();
            //N.Show();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {

            string Query = "Select ID,Customer,Name,InvoiceDate,InvoiceNumber,Quantity,Price,Tax,Category,Total from Invoices where IID = '" + Login.Uid + "' ";
            //string Query = "Select * from Bills";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewInvoices.DataSource = dtUsers;
            ObjDBAccess.closeConn();

            txtbx.Text = Login.Uid;
        }

        private void InvoiceUpdate_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Customer,Name,InvoiceDate,InvoiceNumber,Quantity,Price,Tax,Category,Total from Invoices";
            //string Query = "Select * from Bills";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");


            // Total Income Insert
            //int sum = 0;
            //for (int i = 0; i < DataGridViewInvoices.Rows.Count; i++)
            //{
             // sum += Convert.ToInt32(DataGridViewInvoices.Rows[i].Cells[9].Value);
            //}

            //Total_Sum = sum.ToString();
            //string ID = txtbx.Text;
            //string query="Update Dashboard SET TINCOME = '" + @Total_Sum + "' Where IID = '" + Login.Uid + "' ";
           
            //SqlCommand updateCommand = new SqlCommand(query);

            //updateCommand.Parameters.AddWithValue("@Total_Sum", Total_Sum);
            //int row = ObjDBAccess.executeQuery(updateCommand);
            //if (row == 1)
            //{
               // MessageBox.Show("Account Info Update Successfully.");
               //blUpdate.Text = "Account Info Update Successfully.";
            //}


            //SqlCommand insertCommand = new SqlCommand("insert into Dashboard(TINCOME,IID) values(@Total_Sum,@ID)");
            //insertCommand.Parameters.AddWithValue("@Total_Sum", Total_Sum);
            //insertCommand.Parameters.AddWithValue("@ID", ID);
            //int row = ObjDBAccess.executeQuery(insertCommand);

            //string query = "Update Dashboard SET TINCOME = '" + @Total_Sum + "',IID = '" + Login.Uid + "' Where IID = '" + Login.Uid + "' ";
            //SqlCommand updateCommand = new SqlCommand(query);
            //updateCommand.Parameters.AddWithValue("@Total_Sum", Total_Sum);
            //updateCommand.Parameters.AddWithValue("Login.Uid", Login.Uid);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new InvoicesSearch());
           // InvoicesSearch search = new InvoicesSearch();
            //search.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.DataGridViewInvoices);
        }

        public void Print(DataGridView DG)
        {
            PrinterSettings ps = new PrinterSettings();
            DataGridViewInvoices = DG;
            getPrintarea(DG);
            prntprvw.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printpage);
            prntprvw.ShowDialog();
        }

        public void printdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.DataGridViewInvoices.Width / 2), this.DataGridViewInvoices.Location.Y);
        }

        Bitmap memoryimg;

        public void getPrintarea(DataGridView DG)
        {
            memoryimg = new Bitmap(DG.Width, DG.Height);
            DG.DrawToBitmap(memoryimg, new Rectangle(0, 0, DG.Width, DG.Height));
        }
    }
}
