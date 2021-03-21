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
    public partial class Login : Form
    {
        public static string CName,CEmail,UName,Phone,Pass,CPass,Uid;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Point mouseLocation;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                Properties.Settings.Default.Email = Email.Text;
                Properties.Settings.Default.Password = Password.Text;
                Properties.Settings.Default.Save();
            }
            if (checkBox.Checked == false)
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            string UEmail = Email.Text;
            string UPassword = Password.Text;
            if (UEmail.Equals(""))
            {
                label.Text = "Please Enter email";
            }
            else if (UPassword.Equals(""))
            {
                label.Text = "Please Enter Password";
            }

            else
            {
                string Query = "Select * from Users Where Email = '" + UEmail + "' AND Password = '" + UPassword + " ' ";

                ObjDBAccess.readDatathroughAdapter(Query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    Uid =  dtUsers.Rows[0]["Id"].ToString();
                    CName = dtUsers.Rows[0]["CompanyName"].ToString();
                    CEmail = dtUsers.Rows[0]["Email"].ToString();
                    UName = dtUsers.Rows[0]["Users"].ToString();
                    Phone = dtUsers.Rows[0]["Phone"].ToString();
                    Pass = dtUsers.Rows[0]["Password"].ToString();
                    CPass = dtUsers.Rows[0]["CPassword"].ToString();

                    this.Hide();
                    Dashboard f = new Dashboard();
                    f.Show();
                }
                else
                {
                    label.Text = "Invalid email or password";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Email.Text = "";
            Password.Text = "";
            label.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup f = new Signup();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecoverPassword f = new RecoverPassword();
            f.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.Email != string.Empty)
            {

                Email.Text = Properties.Settings.Default.Email;
                Password.Text = Properties.Settings.Default.Password;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bookkeeping.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookkeeping.Minimize(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximizee(this, btn);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
