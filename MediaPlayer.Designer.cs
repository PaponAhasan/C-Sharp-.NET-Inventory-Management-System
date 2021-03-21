namespace Bookkeeping_Software
{
    partial class MediaPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnMedia = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 36);
            this.panel1.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(19, 38);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(788, 408);
            this.Media.TabIndex = 4;
            this.Media.Enter += new System.EventHandler(this.Media_Enter);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 449);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(807, 95);
            this.listBox.TabIndex = 5;
            this.listBox.Visible = false;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged_1);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.White;
            this.btnMedia.BorderColor = System.Drawing.Color.White;
            this.btnMedia.ButtonColor = System.Drawing.Color.Green;
            this.btnMedia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(692, 410);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnMedia.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMedia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedia.Size = new System.Drawing.Size(107, 35);
            this.btnMedia.TabIndex = 6;
            this.btnMedia.Text = "Browse";
            this.btnMedia.TextColor = System.Drawing.Color.White;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 547);
            this.ControlBox = false;
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.ListBox listBox;
        private ePOSOne.btnProduct.Button_WOC btnMedia;
    }
}