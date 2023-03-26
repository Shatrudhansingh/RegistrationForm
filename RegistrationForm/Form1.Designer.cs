namespace RegistrationForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtsem = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbbranch = new System.Windows.Forms.ComboBox();
            this.btnnewreset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvstudentdetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucknow University Lucknow Utter Pradesh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(490, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registration Form";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Address:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sem/Year:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Branch:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search student  by name";
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtname.Location = new System.Drawing.Point(512, 241);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 26);
            this.txtname.TabIndex = 1;
            // 
            // txtadd
            // 
            this.txtadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtadd.Location = new System.Drawing.Point(512, 281);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(286, 26);
            this.txtadd.TabIndex = 1;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtphone.Location = new System.Drawing.Point(512, 327);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(286, 26);
            this.txtphone.TabIndex = 1;
            // 
            // txtsem
            // 
            this.txtsem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsem.Location = new System.Drawing.Point(512, 364);
            this.txtsem.Name = "txtsem";
            this.txtsem.Size = new System.Drawing.Size(286, 26);
            this.txtsem.TabIndex = 1;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.Location = new System.Drawing.Point(512, 452);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(286, 26);
            this.txtsearch.TabIndex = 1;
            // 
            // cbbranch
            // 
            this.cbbranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbranch.FormattingEnabled = true;
            this.cbbranch.Items.AddRange(new object[] {
            "BA(Art)",
            "BA(Honors)",
            "Bsc(Maths)",
            "Bsc(Bio)",
            "Msc(IT)"});
            this.cbbranch.Location = new System.Drawing.Point(512, 405);
            this.cbbranch.Name = "cbbranch";
            this.cbbranch.Size = new System.Drawing.Size(286, 28);
            this.cbbranch.TabIndex = 2;
            // 
            // btnnewreset
            // 
            this.btnnewreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnewreset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnnewreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewreset.Location = new System.Drawing.Point(903, 243);
            this.btnnewreset.Name = "btnnewreset";
            this.btnnewreset.Size = new System.Drawing.Size(172, 53);
            this.btnnewreset.TabIndex = 3;
            this.btnnewreset.Text = "New/Reset";
            this.btnnewreset.UseVisualStyleBackColor = false;
            this.btnnewreset.Click += new System.EventHandler(this.btnnewreset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(903, 314);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(172, 53);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(903, 380);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(172, 53);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(903, 452);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(172, 53);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dgvstudentdetails
            // 
            this.dgvstudentdetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvstudentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudentdetails.Location = new System.Drawing.Point(171, 505);
            this.dgvstudentdetails.Name = "dgvstudentdetails";
            this.dgvstudentdetails.ReadOnly = true;
            this.dgvstudentdetails.RowHeadersWidth = 62;
            this.dgvstudentdetails.RowTemplate.Height = 28;
            this.dgvstudentdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstudentdetails.Size = new System.Drawing.Size(952, 192);
            this.dgvstudentdetails.TabIndex = 4;
            this.dgvstudentdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudentdetails_CellClick);
            this.dgvstudentdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudentdetails_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 700);
            this.Controls.Add(this.dgvstudentdetails);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnnewreset);
            this.Controls.Add(this.cbbranch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtsem);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtsem;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbbranch;
        private System.Windows.Forms.Button btnnewreset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvstudentdetails;
    }
}