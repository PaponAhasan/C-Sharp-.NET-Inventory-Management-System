using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Bookkeeping_Software
{
    public partial class Dashboard : Form
    {
        Bookkeeping BG = new Bookkeeping();
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Point mouseLocation;
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void DashBoardClose()
        {
            this.Close();
            //if (count == 1) this.Close();
        }
        // Sales and Purchases panel visible or not visible
        public void customizeDesign()
        {
            panelSales.Visible = false;
            panelPurchases.Visible = false;
            //..
        }
        public void hideSubMenu()
        {
            if(panelSales.Visible == true)
            {
                panelSales.Visible = false;
            }
            if(panelPurchases.Visible == true)
            {
                panelPurchases.Visible = false;
            }
        }
        public void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSales);
        }

        #region Sales
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Invoices());
        }

        private void btnRevenues_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Revenues());
        }
        #endregion
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Customers());
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPurchases);
        }
        #region Purchases
        private void btnBills_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Bills());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Payments());
        }

        #endregion
        private void btnVendors_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Vendors());
        }
        private void btnBanking_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new MediaPlayer());
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        //

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
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

        private void btnItems_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           // openChildForm(new NewItems());
            openChildForm(new Items());
        }

        //
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Dashboard f = new Dashboard();
            //f.Show();
            //this.Hide();
        }


        //Cash Flow
        private void button1_Click(object sender, EventArgs e)
        {
            this.chart.Series["Income"].Points.AddXY("Jan",33);
            this.chart.Series["Expenses"].Points.AddXY("Jan", 20);
            this.chart.Series["Profit"].Points.AddXY("Jan", 24);

            this.chart.Series["Income"].Points.AddXY("Feb",24);
            this.chart.Series["Expenses"].Points.AddXY("Feb", 33);
            this.chart.Series["Profit"].Points.AddXY("Feb", 20);

            this.chart.Series["Income"].Points.AddXY("Mar",32);
            this.chart.Series["Expenses"].Points.AddXY("Mar", 24);
            this.chart.Series["Profit"].Points.AddXY("Mar", 33);

            this.chart.Series["Income"].Points.AddXY("Apr",20);
            this.chart.Series["Expenses"].Points.AddXY("Apr", 24);
            this.chart.Series["Profit"].Points.AddXY("Apr", 33);

            this.chart.Series["Income"].Points.AddXY("May", 33);
            this.chart.Series["Expenses"].Points.AddXY("May", 20);
            this.chart.Series["Profit"].Points.AddXY("May", 24);

            this.chart.Series["Income"].Points.AddXY("Jun", 24);
            this.chart.Series["Expenses"].Points.AddXY("Jun", 33);
            this.chart.Series["Profit"].Points.AddXY("Jun", 20);

            this.chart.Series["Income"].Points.AddXY("July", 20);
            this.chart.Series["Expenses"].Points.AddXY("July", 24);
            this.chart.Series["Profit"].Points.AddXY("July", 32);

            this.chart.Series["Income"].Points.AddXY("Aug", 24);
            this.chart.Series["Expenses"].Points.AddXY("Aug", 23);
            this.chart.Series["Profit"].Points.AddXY("Aug", 10);

            this.chart.Series["Income"].Points.AddXY("Sep", 28);
            this.chart.Series["Expenses"].Points.AddXY("Sep", 12);
            this.chart.Series["Profit"].Points.AddXY("Sep", 13);

            //this.chart.Series["Income"].Points.AddXY("Oct", 14);
            //this.chart.Series["Expenses"].Points.AddXY("Oct", 5);
            //this.chart.Series["Profit"].Points.AddXY("Oct", 25);

            //this.chart.Series["Income"].Points.AddXY("Nov", 24);
            //this.chart.Series["Expenses"].Points.AddXY("Nov", 23);
            //this.chart.Series["Profit"].Points.AddXY("Nov", 10);

            //this.chart.Series["Income"].Points.AddXY("Dec", 28);
            //this.chart.Series["Expenses"].Points.AddXY("Dec", 70);
            //this.chart.Series["Profit"].Points.AddXY("Dec", 36);

        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //SearchBox.Text = "";
            if (SearchBox.Text != "")
            {

            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void panelTop_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "") SearchBox.Text = "Search";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ProfileView f = new ProfileView();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProfileView f = new ProfileView();
            f.Show();
        }

       

        //Form MOve Fill
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        // Move Form Main Form
        private void panelChildFrom_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelChildFrom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
        // Move Form Top Form
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        //Logout
        private void label15_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            Dashboard newform = (Dashboard)Application.OpenForms["Dashboard"];
            newform.Close();
        }

        //General
        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Your_Profile f = new Your_Profile();
            f.Show();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void buttonSearch_Enter(object sender, EventArgs e)
        {

        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {

        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblProfile.Text = Login.UName;
            My_Store.Text = Login.CName + " "; 


            string Query = "Select * from Dashboard Where Email = '" + Login.CEmail + "' ";

            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            if (dtUsers.Rows.Count == 1)
            {
                string TotalIncome  = dtUsers.Rows[0]["TINCOME"].ToString();
                //string TotalPROFIT = dtUsers.Rows[0]["TPROFIT"].ToString();
                string TotalEXPENSES = dtUsers.Rows[0]["TEXPENSES"].ToString();

                string TotalReceivables = dtUsers.Rows[0]["Receivables"].ToString();
                string TotalPayables = dtUsers.Rows[0]["Payables"].ToString();
                //string TotalUpcoming = dtUsers.Rows[0]["Upcoming"].ToString();

                int iOne = 0;
                int iTwo = 0;
                Int32.TryParse(TotalIncome, out iOne);
                Int32.TryParse(TotalEXPENSES, out iTwo);
                // return (iOne + iTwo).ToString();
                string TotalPROFIT = (iOne - iTwo).ToString();

                // int TIncome = Int32.Parse(TotalIncome);
                // int TExpenses = Int32.Parse(TotalEXPENSES);
                //int TPROFIT = TIncome - TExpenses;
                //string TotalPROFIT = TPROFIT.ToString();

                //int TIncome, TExpenses, TPROFIT;
                // TIncome = Convert.ToInt32(TotalIncome);
                // TExpenses = Convert.ToInt32(TotalEXPENSES);
                // TPROFIT = TIncome - TExpenses;
                //string TotalPROFIT = TPROFIT.ToString();

                //textBox1.Text = TotalIncome;
                if(TotalIncome == "")
                {
                    lblTotalIncome.Text = "$0 " + TotalIncome + ".00";
                }
                else  lblTotalIncome.Text = "$"+ TotalIncome + ".00";

                if(TotalReceivables == "" && TotalIncome == "")
                {
                    lblReceivables.Text = "$0" + TotalReceivables + ".00" + " / " + "$0" + TotalIncome + ".00";
                }
                else if(TotalReceivables == "")
                {
                    lblReceivables.Text = "$0" + TotalReceivables + ".00" + " / " + "$" + TotalIncome + ".00";
                }
                else lblReceivables.Text = "$" + TotalReceivables + ".00" + " / " + "$" + TotalIncome + ".00";


                if (TotalPROFIT == "")
                {
                    lblProfit.Text = "$0 " + TotalPROFIT + ".00";
                }
                else lblProfit.Text = "$" + TotalPROFIT + ".00";

                if(TotalReceivables == "" && TotalPROFIT == "")
                {
                    lblUpcoming.Text = "$0" + TotalReceivables + ".00" + " / " + "$0" + TotalPROFIT + ".00";
                }
                else if (TotalReceivables == "")
                {
                    lblUpcoming.Text = "$0" + TotalReceivables + ".00" + " / " + "$" + TotalPROFIT + ".00";
                }
                else lblUpcoming.Text = "$" + TotalReceivables + ".00" + " / " + "$" + TotalPROFIT + ".00";


                if (TotalEXPENSES == "")
                {
                    lblTExpenses.Text = "$0" + TotalEXPENSES + ".00";
                }
                else lblTExpenses.Text = "$" + TotalEXPENSES + ".00";

                if (TotalPayables == "" && TotalEXPENSES == "")
                {
                    lblPayables.Text = "$0" + TotalPayables + ".00" + " / " + "$0" + TotalEXPENSES + ".00";
                }
                else if (TotalPayables == "")
                {
                    lblPayables.Text = "$0" + TotalPayables + ".00" + " / " + "$" + TotalEXPENSES + ".00";
                }
                else lblPayables.Text = "$" + TotalPayables + ".00" + " / " + "$" + TotalEXPENSES + ".00";
            }
        }


        private void SearchBox_Leave(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // string Query = "Select * from Items where Name LIKE '" + SearchBox.Text + "%' or IID LIKE '" + SearchBox.Text + "%' or ID LIKE '" + SearchBox.Text + "%' ";
            //ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

            //DataGridViewItems.DataSource = dtUsers;
            //ObjDBAccess.closeConn();
            if (SearchBox.Text != "")
            {

            }
            else if (SearchBox.Text == "") SearchBox.Text = "Enter Search Text";
        }

        private void pbxNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no notification");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //this.Close();
           // Application.Exit();
            Bookkeeping.Exit();
        }

        private void MIN_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            Bookkeeping.Minimize(this);
        }

        private void MAX_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //Dashboard newform = (Dashboard)Application.OpenForms["Dashboard"];

            PictureBox btn = (PictureBox)sender;
           //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximize(this,btn);
        }

        //public static string sum;
        private void lblTotalIncome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
