namespace Bookkeeping_Software
{
    partial class NewPayment
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PictureItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(167, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "*";
            this.label12.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(186, 12);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 22);
            this.txtID.TabIndex = 45;
            this.txtID.Text = "Enter Your Valid ID";
            this.txtID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(27, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "New Payment";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SelectCategory);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PictureItem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ItemPicture);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBill);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVendor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(30, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 362);
            this.panel1.TabIndex = 43;
            // 
            // SelectCategory
            // 
            this.SelectCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategory.ForeColor = System.Drawing.Color.DarkGray;
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Fruits",
            "Vegetables",
            "Fishs",
            "Meat",
            "Other Various"});
            this.SelectCategory.Location = new System.Drawing.Point(30, 313);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(294, 27);
            this.SelectCategory.TabIndex = 39;
            this.SelectCategory.Text = "SelectCategory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(330, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(17, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(17, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "*";
            // 
            // PictureItem
            // 
            this.PictureItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PictureItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PictureItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PictureItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureItem.ForeColor = System.Drawing.Color.Silver;
            this.PictureItem.Location = new System.Drawing.Point(636, 310);
            this.PictureItem.Name = "PictureItem";
            this.PictureItem.Size = new System.Drawing.Size(67, 33);
            this.PictureItem.TabIndex = 35;
            this.PictureItem.Text = "Browse";
            this.PictureItem.UseVisualStyleBackColor = true;
            this.PictureItem.Click += new System.EventHandler(this.PictureItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(339, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Picture";
            // 
            // ItemPicture
            // 
            this.ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPicture.Location = new System.Drawing.Point(343, 310);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(295, 33);
            this.ItemPicture.TabIndex = 32;
            this.ItemPicture.TabStop = false;
            this.ItemPicture.Click += new System.EventHandler(this.ItemPicture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(27, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Category";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.ForeColor = System.Drawing.Color.Silver;
            this.txtBill.Location = new System.Drawing.Point(342, 233);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(361, 33);
            this.txtBill.TabIndex = 29;
            this.txtBill.Text = "Enter Payable";
            this.txtBill.Enter += new System.EventHandler(this.txtBill_Enter);
            this.txtBill.Leave += new System.EventHandler(this.txtBill_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(340, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Payable";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Silver;
            this.txtAmount.Location = new System.Drawing.Point(30, 233);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(294, 33);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.Text = "Enter Amount";
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(27, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Amount";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Silver;
            this.txtDescription.Location = new System.Drawing.Point(30, 123);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(673, 67);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.Text = "Enter Description";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // txtVendor
            // 
            this.txtVendor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendor.ForeColor = System.Drawing.Color.Silver;
            this.txtVendor.Location = new System.Drawing.Point(342, 46);
            this.txtVendor.Multiline = true;
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(361, 33);
            this.txtVendor.TabIndex = 23;
            this.txtVendor.Text = "- Select Vendor -";
            this.txtVendor.Enter += new System.EventHandler(this.txtVendor_Enter);
            this.txtVendor.MouseLeave += new System.EventHandler(this.txtVendor_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(340, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vendor";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Silver;
            this.txtDate.Location = new System.Drawing.Point(30, 46);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(294, 33);
            this.txtDate.TabIndex = 21;
            this.txtDate.Text = "2020-07-07";
            this.txtDate.Enter += new System.EventHandler(this.txtDate_Enter);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(30, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 53);
            this.panel2.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.button2.Location = new System.Drawing.Point(518, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.TabIndex = 34;
            this.button2.Text = "X  Cancle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(616, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewPayment";
            this.Load += new System.EventHandler(this.NewPayment_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPayment_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewPayment_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PictureItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ItemPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}