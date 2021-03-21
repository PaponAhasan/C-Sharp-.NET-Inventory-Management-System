using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookkeeping_Software
{
    public partial class Bills : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument printdoc = new PrintDocument();
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Bills()
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
            openChildForm(new New_Bills());
            //New_Bills B = new New_Bills();
            //B.Show();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            string Query = "Select ID,Vendor,Name,BillDate,BillNumber,Quantity,Price,Tax,Category,Total from Bills where IID = '" + Login.Uid + "' ";
            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            DataGridViewBills.DataSource = dtUsers;
            ObjDBAccess.closeConn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "Select ID,Vendor,Name,BillDate,BillNumber,Quantity,Price,Tax,Category,Total from Bills";
            int changes = ObjDBAccess.executeDataAdapter(dtUsers, Query);
            MessageBox.Show("Update Successfully.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new BillSearch());
            //BillSearch B = new BillSearch();
            //B.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.DataGridViewBills);
        }

        public void Print(DataGridView DG)
        {
            PrinterSettings ps = new PrinterSettings();
            DataGridViewBills = DG;
            getPrintarea(DG);
            prntprvw.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printpage);
            prntprvw.ShowDialog();
        }

        public void printdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.DataGridViewBills.Width / 2), this.DataGridViewBills.Location.Y);
        }

        Bitmap memoryimg;

        public void getPrintarea(DataGridView DG)
        {
            memoryimg = new Bitmap(DG.Width, DG.Height);
            DG.DrawToBitmap(memoryimg, new Rectangle(0, 0, DG.Width, DG.Height));
        }
    }
}
