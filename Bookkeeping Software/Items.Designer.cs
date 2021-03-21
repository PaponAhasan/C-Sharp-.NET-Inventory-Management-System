namespace Bookkeeping_Software
{
    partial class Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DataGridViewItems = new System.Windows.Forms.DataGridView();
            this.btnSearch = new ePOSOne.btnProduct.Button_WOC();
            this.panelChildFrom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItems)).BeginInit();
            this.panelChildFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(671, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "+ Create Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(700, 456);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGridViewItems
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.DataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewItems.EnableHeadersVisualStyles = false;
            this.DataGridViewItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.DataGridViewItems.Location = new System.Drawing.Point(30, 66);
            this.DataGridViewItems.Name = "DataGridViewItems";
            this.DataGridViewItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewItems.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewItems.Size = new System.Drawing.Size(744, 383);
            this.DataGridViewItems.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ButtonColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(326, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(84)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Size = new System.Drawing.Size(116, 29);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.Controls.Add(this.DataGridViewItems);
            this.panelChildFrom.Controls.Add(this.label3);
            this.panelChildFrom.Controls.Add(this.button2);
            this.panelChildFrom.Controls.Add(this.label1);
            this.panelChildFrom.Controls.Add(this.btnSearch);
            this.panelChildFrom.Controls.Add(this.button1);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(0, 0);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(800, 500);
            this.panelChildFrom.TabIndex = 24;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelChildFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItems)).EndInit();
            this.panelChildFrom.ResumeLayout(false);
            this.panelChildFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DataGridViewItems;
        private ePOSOne.btnProduct.Button_WOC btnSearch;
        private System.Windows.Forms.Panel panelChildFrom;
    }
}