namespace Grifindor_toys
{
    partial class Employe_CMP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.e_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.e_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.e_monthlysalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.e_gender = new System.Windows.Forms.ComboBox();
            this.e_dob = new System.Windows.Forms.DateTimePicker();
            this.e_joindate = new System.Windows.Forms.DateTimePicker();
            this.e_overtime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.e_allowances = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e_search = new System.Windows.Forms.TextBox();
            this.e_btnsearch = new System.Windows.Forms.Button();
            this.e_btnadd = new System.Windows.Forms.Button();
            this.e_btnupdate = new System.Windows.Forms.Button();
            this.e_address = new System.Windows.Forms.RichTextBox();
            this.EMPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.e_address);
            this.panel1.Controls.Add(this.e_btnupdate);
            this.panel1.Controls.Add(this.e_btnadd);
            this.panel1.Controls.Add(this.e_joindate);
            this.panel1.Controls.Add(this.e_dob);
            this.panel1.Controls.Add(this.e_gender);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.e_allowances);
            this.panel1.Controls.Add(this.e_overtime);
            this.panel1.Controls.Add(this.e_monthlysalary);
            this.panel1.Controls.Add(this.e_phone);
            this.panel1.Controls.Add(this.e_lname);
            this.panel1.Controls.Add(this.e_fname);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 316);
            this.panel1.TabIndex = 0;
            // 
            // e_fname
            // 
            this.e_fname.Location = new System.Drawing.Point(46, 63);
            this.e_fname.Name = "e_fname";
            this.e_fname.Size = new System.Drawing.Size(145, 20);
            this.e_fname.TabIndex = 0;
            this.e_fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frist name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // e_lname
            // 
            this.e_lname.Location = new System.Drawing.Point(247, 63);
            this.e_lname.Name = "e_lname";
            this.e_lname.Size = new System.Drawing.Size(145, 20);
            this.e_lname.TabIndex = 0;
            this.e_lname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "DOB";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // e_phone
            // 
            this.e_phone.Location = new System.Drawing.Point(247, 151);
            this.e_phone.Name = "e_phone";
            this.e_phone.Size = new System.Drawing.Size(145, 20);
            this.e_phone.TabIndex = 0;
            this.e_phone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Join date";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // e_monthlysalary
            // 
            this.e_monthlysalary.Location = new System.Drawing.Point(656, 151);
            this.e_monthlysalary.Name = "e_monthlysalary";
            this.e_monthlysalary.Size = new System.Drawing.Size(145, 20);
            this.e_monthlysalary.TabIndex = 0;
            this.e_monthlysalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Monthly salary";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // e_gender
            // 
            this.e_gender.FormattingEnabled = true;
            this.e_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.e_gender.Location = new System.Drawing.Point(448, 61);
            this.e_gender.Name = "e_gender";
            this.e_gender.Size = new System.Drawing.Size(145, 21);
            this.e_gender.TabIndex = 2;
            // 
            // e_dob
            // 
            this.e_dob.Location = new System.Drawing.Point(46, 151);
            this.e_dob.Name = "e_dob";
            this.e_dob.Size = new System.Drawing.Size(145, 20);
            this.e_dob.TabIndex = 3;
            // 
            // e_joindate
            // 
            this.e_joindate.Location = new System.Drawing.Point(448, 151);
            this.e_joindate.Name = "e_joindate";
            this.e_joindate.Size = new System.Drawing.Size(145, 20);
            this.e_joindate.TabIndex = 3;
            // 
            // e_overtime
            // 
            this.e_overtime.Location = new System.Drawing.Point(46, 256);
            this.e_overtime.Name = "e_overtime";
            this.e_overtime.Size = new System.Drawing.Size(145, 20);
            this.e_overtime.TabIndex = 0;
            this.e_overtime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Overtime rates";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // e_allowances
            // 
            this.e_allowances.Location = new System.Drawing.Point(247, 256);
            this.e_allowances.Name = "e_allowances";
            this.e_allowances.Size = new System.Drawing.Size(145, 20);
            this.e_allowances.TabIndex = 0;
            this.e_allowances.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Allowances";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMPID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.EDIT,
            this.DELETE});
            this.dataGridView1.Location = new System.Drawing.Point(30, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 216);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // e_search
            // 
            this.e_search.Location = new System.Drawing.Point(30, 352);
            this.e_search.Name = "e_search";
            this.e_search.Size = new System.Drawing.Size(203, 20);
            this.e_search.TabIndex = 0;
            this.e_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // e_btnsearch
            // 
            this.e_btnsearch.Location = new System.Drawing.Point(239, 352);
            this.e_btnsearch.Name = "e_btnsearch";
            this.e_btnsearch.Size = new System.Drawing.Size(86, 23);
            this.e_btnsearch.TabIndex = 2;
            this.e_btnsearch.Text = "Search";
            this.e_btnsearch.UseVisualStyleBackColor = true;
            this.e_btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // e_btnadd
            // 
            this.e_btnadd.BackColor = System.Drawing.Color.LimeGreen;
            this.e_btnadd.FlatAppearance.BorderSize = 0;
            this.e_btnadd.Location = new System.Drawing.Point(485, 253);
            this.e_btnadd.Name = "e_btnadd";
            this.e_btnadd.Size = new System.Drawing.Size(86, 23);
            this.e_btnadd.TabIndex = 2;
            this.e_btnadd.Text = "ADD";
            this.e_btnadd.UseVisualStyleBackColor = false;
            this.e_btnadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // e_btnupdate
            // 
            this.e_btnupdate.Location = new System.Drawing.Point(588, 254);
            this.e_btnupdate.Name = "e_btnupdate";
            this.e_btnupdate.Size = new System.Drawing.Size(86, 23);
            this.e_btnupdate.TabIndex = 2;
            this.e_btnupdate.Text = "UPDATE";
            this.e_btnupdate.UseVisualStyleBackColor = true;
            this.e_btnupdate.Click += new System.EventHandler(this.e_btnupdate_Click);
            // 
            // e_address
            // 
            this.e_address.Location = new System.Drawing.Point(656, 63);
            this.e_address.Name = "e_address";
            this.e_address.Size = new System.Drawing.Size(299, 34);
            this.e_address.TabIndex = 4;
            this.e_address.Text = "";
            // 
            // EMPID
            // 
            this.EMPID.HeaderText = "EMPID";
            this.EMPID.Name = "EMPID";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FNAME";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LASTNAME";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "GENDER";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ADDRESS";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DOB";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PHONE";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "JOINDATE";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "MSALARY";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "OT";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ALLOWANCES";
            this.Column10.Name = "Column10";
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.Name = "EDIT";
            this.EDIT.Text = "EDIT";
            this.EDIT.UseColumnTextForButtonValue = true;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            // 
            // Employe_CMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.e_btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.e_search);
            this.Name = "Employe_CMP";
            this.Size = new System.Drawing.Size(977, 641);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox e_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox e_monthlysalary;
        private System.Windows.Forms.TextBox e_phone;
        private System.Windows.Forms.TextBox e_lname;
        private System.Windows.Forms.DateTimePicker e_joindate;
        private System.Windows.Forms.DateTimePicker e_dob;
        private System.Windows.Forms.ComboBox e_gender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox e_allowances;
        private System.Windows.Forms.TextBox e_overtime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox e_search;
        private System.Windows.Forms.Button e_btnsearch;
        private System.Windows.Forms.Button e_btnupdate;
        private System.Windows.Forms.Button e_btnadd;
        private System.Windows.Forms.RichTextBox e_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}
