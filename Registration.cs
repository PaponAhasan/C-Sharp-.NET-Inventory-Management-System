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
using System.IO;

namespace Bookkeeping_Software
{
    public partial class Signup : Form
    {
        public static string CompanyEmail;
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Point mouseLocation;
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Entry()
        {
            SqlCommand insertCommand = new SqlCommand("insert into Dashboard(Email) values(@CompanyEmail)");
            insertCommand.Parameters.AddWithValue("@CompanyEmail", CompanyEmail);
            ObjDBAccess.executeQuery(insertCommand);
            ObjDBAccess.closeConn();
        }
        private void Sign_Click(object sender, EventArgs e)
        {

            if (TxtCName.Text == "" || TxtCEmail.Text == "" || TxtPassword.Text == "" || TxtCPassword.Text == "")
                MessageBox.Show("Please fill out this fields.");
            else if (TxtPassword.Text != TxtCPassword.Text) MessageBox.Show("Password do not match.");
            else
            {
                string CompanyName = TxtCName.Text;
                 CompanyEmail = TxtCEmail.Text;
                string UserName = TxtUserName.Text;
                string PhoneNumber = TxtPhone.Text;
                string Password = TxtPassword.Text;
                string ConfirmPassword = TxtCPassword.Text;
                string IPath = PathImage.Text;
                string query = "Select Email from Users Where Email = '" + CompanyEmail + "' ";
                ObjDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    lblAccount.Text = "Already have an account";
                    RS.Text = "";
                    DialogResult dialog = MessageBox.Show("Please Try Again", "Already have an account!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.OK)
                    {
                        Login L = new Login();
                        L.Show();
                        this.Close();
                    }
                }
                else
                {

                    //Image Save Folder
                    //if (PathImage.Text != "")
                    //{
                        //File.Copy(PathImage.Text, Path.Combine(@"D:\GitHub\Web_Development\C#\C# Windows Form Application\Accounting Software\New folder\Bookkeeping Software\Bookkeeping Software\Images\", Path.GetFileName(PathImage.Text)), true);
                       // lblImage.Text = "Image Save successfully";
                   // }
                    //else lblImage.Text = "Please , Choose Image";

                    //insert Image Database
                    ImageConverter img = new ImageConverter();
                    byte[] image = (byte[])img.ConvertTo(pictureBoxUplode.Image, Type.GetType("System.Byte[]"));


                    //Insert User profile
                    SqlCommand insertCommand = new SqlCommand("insert into Users(Email,CompanyName,Users,Phone,Password,CPassword,Image,FileName) values(@CompanyEmail,@CompanyName,@UserName,@PhoneNumber,@Password,@ConfirmPassword,@Image,@IPath)");
                    //insertCommand = new SqlCommand("insert into Dashboard(Email) values(@CompanyEmail)");

                    insertCommand.Parameters.AddWithValue("@CompanyEmail", CompanyEmail);
                    insertCommand.Parameters.AddWithValue("@CompanyName", CompanyName);
                    insertCommand.Parameters.AddWithValue("@UserName", UserName);
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    insertCommand.Parameters.AddWithValue("@Password", Password);
                    insertCommand.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword);
                    insertCommand.Parameters.AddWithValue("@Image", image);
                    insertCommand.Parameters.AddWithValue("@IPath", IPath);

                    int row = ObjDBAccess.executeQuery(insertCommand);

                    if (row == 1)
                    {
                        RS.Text = "Your registration is successfull";
                        lblAccount.Text = "";
                    }
                    ObjDBAccess.closeConn();
                    Entry();
                }
            }
                    //if(query == CompanyEmail)
                    //{
                    // lblAccount.Text = "Already have an account";
                    //}



                    //if ()
                    //{
                    //string CEmail = dtUsers.Rows[0]["Email"].ToString();
                //ObjDBAccess.closeConn();
                //DialogResult dialog = MessageBox.Show("Please Try Again", "!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //if (dialog == DialogResult.OK)
                //{
                //    this.Close();
                //    Login L = new Login();
                //    L.Show();
                //}
               // ObjDBAccess.executeQuery();
                //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            //lblImage.Visible = false;
            //string ComEmail = TxtCEmail.Text;
            SqlCommand insertCommand = new SqlCommand("insert into Dashboard(Email) values(@CompanyEmail)");
            insertCommand.Parameters.AddWithValue("@CompanyEmail", CompanyEmail);
            //int row = ObjDBAccess.executeQuery(insertCommand);
        }

        private void Signup_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Signup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PathImage.Text = opnfd.FileName;
                pictureBoxUplode.Image = new Bitmap(opnfd.FileName);
            }

            //if (PathImage.Text != "")
            //{
            //    File.Copy(PathImage.Text, Path.Combine(@"D:\GitHub\Web_Development\C#\C# Windows Form Application\Accounting Software\New folder\Bookkeeping Software\Bookkeeping Software\Images\", Path.GetFileName(PathImage.Text)), true);
            //    lblImage.Text = "Image Save successfully";
            //}
            //else lblImage.Text = "Please , Choose Image";
        }

        private void pictureBoxUplode_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PathImage.Text = opnfd.FileName;
                pictureBoxUplode.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //newform.WindowState = FormWindowState.Maximized;
            Bookkeeping.DoMaximizee(this, btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookkeeping.Minimize(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bookkeeping.Exit();
        }
    }
}
