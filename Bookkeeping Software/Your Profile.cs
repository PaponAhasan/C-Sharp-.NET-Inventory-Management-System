using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bookkeeping_Software
{
    public partial class Your_Profile : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public static string CN,FN,LN,E,BD,P,G,UN,nP,cnP,RL;
        public static int count = 0;
        string F, M, O;
       // bool F, M, O;

        public Point mouseLocation;

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

        private void UplodePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PathImage.Text = opnfd.FileName;
                UplodePicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        public Your_Profile()
        {
            InitializeComponent();
        }

        private void Your_Profile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Your_Profile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
        
        private void Your_Profile_Load(object sender, EventArgs e)
        {
           // lblImage.Visible = false;

            string Query = "Select * from Users Where Email = '" + Login.CEmail + "' ";

            ObjDBAccess.readDatathroughAdapter(Query, dtUsers);
           // DataSet ds = new DataSet();
            if (dtUsers.Rows.Count == 1)
            {
                //CN,FN,LN,E,BD,P,G;
                CN = dtUsers.Rows[0]["CompanyName"].ToString();
                FN = dtUsers.Rows[0]["FName"].ToString();
                LN = dtUsers.Rows[0]["LName"].ToString();
                E = dtUsers.Rows[0]["Email"].ToString();
                P = dtUsers.Rows[0]["Phone"].ToString();
                BD = dtUsers.Rows[0]["BDay"].ToString();
                M = dtUsers.Rows[0]["GMale"].ToString();
                F = dtUsers.Rows[0]["GFemale"].ToString();
                O = dtUsers.Rows[0]["GOther"].ToString();
                UN = dtUsers.Rows[0]["Users"].ToString();
                nP = dtUsers.Rows[0]["Password"].ToString();
                cnP = dtUsers.Rows[0]["CPassword"].ToString();
                RL = dtUsers.Rows[0]["Roles"].ToString();

                MemoryStream ms = new MemoryStream((byte[])dtUsers.Rows[0]["Image"]);
                UplodePicture.Image = new Bitmap(ms);

                // CPass = dtUsers.Rows[0]["CPassword"].ToString();
            }

            TxtCompany.Text = CN;
            TxtEname.Text = E;
            TxtPhone.Text = P;
            lblName.Text = "Welcome " + UN;
            TxtFname.Text = FN;
            TxtLName.Text = LN;
            TxtBirthDay.Text = BD;
            TxtUserName.Text = UN;
            txtRoles.Text = RL;
            //TxtNewPassword.Text = nP;
            //TxtConfirmNewPassword.Text = cnP;
            if (M == "True")
            {
                Male.Checked = true;
                G = "Male";
            }
            if (F == "True")
            {
                Female.Checked = true;
                G = "Female";
            }
            if (O == "True")
            {
                Other.Checked = true;
                G = "Other";
            }
            //Female.Text = F;
            //Other.Text = O;

            //TxtCompany.Text = Login.CName;
            //TxtEname.Text = Login.CEmail;
            //TxtPhone.Text = Login.Phone;
            //lblName.Text = "Welcome " + Login.UName;
            //TxtFname.Text = TxtFname.Text;
            //TxtLName.Text = 
            //TxtBirthDay.Text =

            // Text = Properties.Settings.Default.Title;
            // TxtCompany.Text = Properties.Settings.Default.Company_Name;
            // TxtFname.Text = Properties.Settings.Default.Fname;
            // TxtLName.Text = Properties.Settings.Default.LName;
            // TxtEname.Text = Properties.Settings.Default.Company_Email;
            // TxtBirthDay.Text = Properties.Settings.Default.Bday;
            // TxtPhone.Text = Properties.Settings.Default.Phone;
            // Male.Checked = Properties.Settings.Default.M;
            //Female.Checked = Properties.Settings.Default.F;
            // Other.Checked = Properties.Settings.Default.O;
            // this.Location = new Point(Properties.Settings.Default.Px, Properties.Settings.Default.Py);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //TxtCompany.Text = Login.CName;
            //TxtEname.Text = Login.CEmail;
            //TxtPhone.Text = Login.Phone;
            //lblName.Text = "Welcome " + Login.UName;
            //TxtFname.Text = 
            //TxtLName.Text = 
            //TxtBirthDay.Text =
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                SqlCommand deleteCommand;

                string Query2 = "DELETE from Bills Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query2);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query3 = "DELETE from Dashboard Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query3);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query4 = "DELETE from Invoices Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query4);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query5 = "DELETE from Items Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query5);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query6 = "DELETE from Revenues Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query6);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query7 = "DELETE from Cuestomers Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query7);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query8 = "DELETE from Payaments Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query8);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query9 = "DELETE from Vendors Where IID = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query9);
                ObjDBAccess.executeQuery(deleteCommand);

                string Query1 = "DELETE from Users Where Id = '" + Login.Uid + "' ";
                deleteCommand = new SqlCommand(Query1);

                int row = ObjDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Deleted Successfully.");
                    this.Close();
                    Login f = new Login();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Error Occurred. Try Again");
                }
            }

        }

        private void Your_Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Properties.Settings.Default.M = Male.Checked;
            //Properties.Settings.Default.F = Female.Checked;
            //Properties.Settings.Default.O = Other.Checked;
            //Properties.Settings.Default.Company_Name = TxtCompany.Text;
            //Properties.Settings.Default.Fname = TxtFname.Text;
            //Properties.Settings.Default.LName = TxtLName.Text;
            //Properties.Settings.Default.Company_Email = TxtEname.Text;
            //Properties.Settings.Default.Bday = TxtBirthDay.Text;
            //Properties.Settings.Default.Phone = TxtPhone.Text;
            //Properties.Settings.Default.Px = this.Location.X;
            //Properties.Settings.Default.Py = this.Location.Y;
            //Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.Show();
        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCompany.Text = "";
            TxtFname.Text = "";
            TxtLName.Text = "";
            TxtEname.Text = "";
            TxtBirthDay.Text = "";
            TxtPhone.Text = "";
            TxtOldPassword.Text = "";
            TxtConfirmNewPassword.Text = "";
            TxtBirthDay.Text = "";
            TxtUserName.Text = "";
            TxtNewPassword.Text = "";
            txtRoles.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            Other.Checked = false;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PathImage.Text = opnfd.FileName;
                UplodePicture.Image = new Bitmap(opnfd.FileName);
            }

        }
        private void Sign_Click(object sender, EventArgs e)
        {

            string CoName = TxtCompany.Text;
            string Fnm = TxtFname.Text;
            string Lnm = TxtLName.Text;
            string CoEmail = TxtEname.Text;
            string UBDay = TxtBirthDay.Text;
            string Ph = TxtPhone.Text;
            string UsName = TxtUserName.Text;
             bool MG = Male.Checked;
             bool FG = Female.Checked;
             bool OG = Other.Checked;
            string NPassword = TxtNewPassword.Text;
            string Opassword = TxtOldPassword.Text;
            string RL = txtRoles.Text;
            string IPath = PathImage.Text;

            if (CoName.Equals(""))
            {
                MessageBox.Show("Enter Fild Your Company Name");
            }
            else if (Ph.Equals("") )
            {
                MessageBox.Show("Enter Fild Your Phone Number");
            }
            else if (TxtOldPassword.Text.Equals(""))
            {
                MessageBox.Show("Enter Fild Your Present Password");
            }
            else if (txtRoles.Text.Equals(""))
            {
                MessageBox.Show("Enter Fild Your Roles");
            }
            else if (CoEmail != Login.CEmail)
            {
                MessageBox.Show("Don't change your Email Address.");
            }
            else if(Opassword != Login.Pass)
            {
                MessageBox.Show("Incorret Your Present Pasword.");
            }
            else if(TxtNewPassword.Text != TxtConfirmNewPassword.Text)
            {
                MessageBox.Show("New Password do not match.");
            }
            else
            {
                //insert Image Database
                ImageConverter img = new ImageConverter();
                byte[] image = (byte[])img.ConvertTo(UplodePicture.Image, Type.GetType("System.Byte[]"));

                string Query;
                if (TxtConfirmNewPassword.Text.Equals("") || TxtNewPassword.Text.Equals(""))
                {
                    Query = "Update Users SET CompanyName = '" + @CoName + "' , FName = '" + @Fnm + "' , LName = '" + @Lnm + "' , BDay = '" + @UBDay + "' , Phone = '" + @Ph + "',GMale = '" + @MG + "',GFemale = '" + @FG + "',GOther = '" + @OG + "',Users = '" + UsName + "',Password = '" + Opassword + "',CPassword = '" + Opassword + "',Roles = '" + RL + "',FileName = '" + IPath + "',Image = @image Where Id = '" + Login.Uid + "' ";

                }
                else
                {
                    Query = "Update Users SET CompanyName = '" + @CoName + "' , FName = '" + @Fnm + "' , LName = '" + @Lnm + "' , BDay = '" + @UBDay + "' , Phone = '" + @Ph + "',GMale = '" + @MG + "',GFemale = '" + @FG + "',GOther = '" + @OG + "',Users = '" + UsName + "',Password = '" + NPassword + "',CPassword = '" + NPassword + "',Roles = '" + RL + "', FileName = '" + IPath + "',Image = @image Where Id = '" + Login.Uid + "' ";

                }
                SqlCommand updateCommand = new SqlCommand(Query);

                updateCommand.Parameters.AddWithValue("@CoName", CoName);
                updateCommand.Parameters.AddWithValue("@Fnm", Fnm);
                updateCommand.Parameters.AddWithValue("@Lnm", Lnm);
                updateCommand.Parameters.AddWithValue("@CoEmail", CoEmail);
                updateCommand.Parameters.AddWithValue("@UBDay", UBDay);
                updateCommand.Parameters.AddWithValue("@Ph", Ph);
                updateCommand.Parameters.AddWithValue("@MG", MG);
                updateCommand.Parameters.AddWithValue("@FG", FG);
                updateCommand.Parameters.AddWithValue("@OG", OG);
                updateCommand.Parameters.AddWithValue("@UsName", UsName);
                updateCommand.Parameters.AddWithValue("@RL", RL);
                updateCommand.Parameters.AddWithValue("@Image", image);
                updateCommand.Parameters.AddWithValue("@IPath", IPath);

                int row = ObjDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    //MessageBox.Show("Account Info Update Successfully.");
                    lblUpdate.Text = "Account Info Update Successfully.";
                }

                //Save Image Folder
                if (PathImage.Text != "")
                {
                    //File.Copy(PathImage.Text, Path.Combine(@"D:\GitHub\Web_Development\C#\C# Windows Form Application\Accounting Software\New folder\Bookkeeping Software\Bookkeeping Software\Images\", Path.GetFileName(PathImage.Text)), true);
                    //lblImage.Text = "Image Save successfully";
                }
                //else lblImage.Text = "Please , Choose Image";

                //CN = TxtCompany.Text;
                //FN = TxtFname.Text;
                //LN = TxtLName.Text;
                // E = TxtEname.Text;
                // BD = TxtBirthDay.Text;
                // P = TxtPhone.Text;
                //if (Male.Checked) G = "Male";
                //if (Female.Checked) G = "Female";
                //if (Other.Checked) G = "Other";

                //if (count > 0)
                // {
                //this.Hide();
                //Your_Profile f = new Your_Profile();
                //f.Show();
                //ShowProfile o = new ShowProfile(UplodePicture.Image);
                //o.Hide();
                //ShowProfile x = new ShowProfile(UplodePicture.Image);
                //x.Show();
                //}
                //else
                //{
                ShowProfile fro = new ShowProfile(UplodePicture.Image);
                    fro.Show();
                //}
                //count++;

            }
            //Dashboard f = new Dashboard();
            //f.Show();
            //this.Text = txtFname.Text;
            //label.Text = txtFname.Text;
        }
    }
}
