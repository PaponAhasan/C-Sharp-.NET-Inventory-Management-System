using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookkeeping_Software
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            foreach (char T in openFileDialog.FileName)
            {
                Media.URL = openFileDialog.FileName;
                listBox.Items.Add(T);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Media_Enter(object sender, EventArgs e)
        {
            //openFileDialog.FileName = "Browse Video or Mp3 File";
            //openFileDialog.ShowDialog();
        }

        private void listBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Media.URL = listBox.Text;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "Browse Video or Mp3 File";
            openFileDialog.ShowDialog();
        }
    }
}
