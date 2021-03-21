namespace Bookkeeping_Software
{
    partial class PaymentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new ePOSOne.btnProduct.Button_WOC();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(474, 16);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 36);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(218, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 27);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchBox.Location = new System.Drawing.Point(249, 26);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(192, 15);
            this.SearchBox.TabIndex = 35;
            this.SearchBox.Text = "Search";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.DoubleClick += new System.EventHandler(this.SearchBox_DoubleClick);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // DataGridViewPayments
            // 
            dataGridViewCellStyle11.NullValue = null;
            this.DataGridViewPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.DataGridViewPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPayments.DefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridViewPayments.EnableHeadersVisualStyles = false;
            this.DataGridViewPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.DataGridViewPayments.Location = new System.Drawing.Point(33, 72);
            this.DataGridViewPayments.Name = "DataGridViewPayments";
            this.DataGridViewPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewPayments.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DataGridViewPayments.Size = new System.Drawing.Size(736, 361);
            this.DataGridViewPayments.TabIndex = 33;
            this.DataGridViewPayments.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataGridViewPayments_MouseMove);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSearch.ButtonColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(202, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OnHoverBorderColor = System.Drawing.Color.White;
            this.buttonSearch.OnHoverButtonColor = System.Drawing.Color.White;
            this.buttonSearch.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSearch.Size = new System.Drawing.Size(260, 41);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Tag = "";
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextColor = System.Drawing.Color.White;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(695, 455);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PaymentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.DataGridViewPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PaymentSearch";
            this.Leave += new System.EventHandler(this.PaymentSearch_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaymentSearch_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox SearchBox;
        private ePOSOne.btnProduct.Button_WOC buttonSearch;
        private System.Windows.Forms.DataGridView DataGridViewPayments;
        private System.Windows.Forms.Button button2;
    }
}