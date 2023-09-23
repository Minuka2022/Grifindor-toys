namespace Grifindor_toys
{
    partial class Setting_CMP
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.set_SryCycleDateRange = new System.Windows.Forms.TextBox();
            this.set_OT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.set_SlryCycleBeginDate = new System.Windows.Forms.DateTimePicker();
            this.set_SlryCycleEndDate = new System.Windows.Forms.DateTimePicker();
            this.set_empid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.set_govtax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RECOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCycleBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCycleEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryCycleDataRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GOVTAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.set_SlryCycleEndDate);
            this.panel1.Controls.Add(this.set_SlryCycleBeginDate);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.set_govtax);
            this.panel1.Controls.Add(this.set_empid);
            this.panel1.Controls.Add(this.set_OT);
            this.panel1.Controls.Add(this.set_SryCycleDateRange);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 251);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Salary cycle date range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Salary cycle end date";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Salary cycle begin date";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // set_SryCycleDateRange
            // 
            this.set_SryCycleDateRange.Location = new System.Drawing.Point(475, 84);
            this.set_SryCycleDateRange.Name = "set_SryCycleDateRange";
            this.set_SryCycleDateRange.Size = new System.Drawing.Size(145, 20);
            this.set_SryCycleDateRange.TabIndex = 11;
            this.set_SryCycleDateRange.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // set_OT
            // 
            this.set_OT.Location = new System.Drawing.Point(682, 84);
            this.set_OT.Name = "set_OT";
            this.set_OT.Size = new System.Drawing.Size(145, 20);
            this.set_OT.TabIndex = 11;
            this.set_OT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Overtime rate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RECOID,
            this.EMPID,
            this.SalaryCycleBeginDate,
            this.SalaryCycleEndDate,
            this.SalaryCycleDataRange,
            this.OvertimeRate,
            this.GOVTAX,
            this.EDIT,
            this.DELETE});
            this.dataGridView1.Location = new System.Drawing.Point(42, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 292);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(42, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 20);
            this.textBox6.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // set_SlryCycleBeginDate
            // 
            this.set_SlryCycleBeginDate.Location = new System.Drawing.Point(54, 84);
            this.set_SlryCycleBeginDate.Name = "set_SlryCycleBeginDate";
            this.set_SlryCycleBeginDate.Size = new System.Drawing.Size(157, 20);
            this.set_SlryCycleBeginDate.TabIndex = 20;
            // 
            // set_SlryCycleEndDate
            // 
            this.set_SlryCycleEndDate.Location = new System.Drawing.Point(266, 84);
            this.set_SlryCycleEndDate.Name = "set_SlryCycleEndDate";
            this.set_SlryCycleEndDate.Size = new System.Drawing.Size(153, 20);
            this.set_SlryCycleEndDate.TabIndex = 21;
            // 
            // set_empid
            // 
            this.set_empid.Location = new System.Drawing.Point(54, 166);
            this.set_empid.Name = "set_empid";
            this.set_empid.Size = new System.Drawing.Size(145, 20);
            this.set_empid.TabIndex = 11;
            this.set_empid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Employee ID";
            // 
            // set_govtax
            // 
            this.set_govtax.Location = new System.Drawing.Point(266, 166);
            this.set_govtax.Name = "set_govtax";
            this.set_govtax.Size = new System.Drawing.Size(145, 20);
            this.set_govtax.TabIndex = 11;
            this.set_govtax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Goverment Tax rate";
            // 
            // RECOID
            // 
            this.RECOID.HeaderText = "RECOID";
            this.RECOID.Name = "RECOID";
            // 
            // EMPID
            // 
            this.EMPID.HeaderText = "EMPID";
            this.EMPID.Name = "EMPID";
            // 
            // SalaryCycleBeginDate
            // 
            this.SalaryCycleBeginDate.HeaderText = "SalaryCycleBeginDate";
            this.SalaryCycleBeginDate.Name = "SalaryCycleBeginDate";
            // 
            // SalaryCycleEndDate
            // 
            this.SalaryCycleEndDate.HeaderText = "SalaryCycleEndDate";
            this.SalaryCycleEndDate.Name = "SalaryCycleEndDate";
            // 
            // SalaryCycleDataRange
            // 
            this.SalaryCycleDataRange.HeaderText = "SalaryCycleDataRange";
            this.SalaryCycleDataRange.Name = "SalaryCycleDataRange";
            // 
            // OvertimeRate
            // 
            this.OvertimeRate.HeaderText = "OvertimeRate";
            this.OvertimeRate.Name = "OvertimeRate";
            // 
            // GOVTAX
            // 
            this.GOVTAX.HeaderText = "GOVTAX";
            this.GOVTAX.Name = "GOVTAX";
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
            // Setting_CMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Setting_CMP";
            this.Size = new System.Drawing.Size(977, 641);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox set_SryCycleDateRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox set_OT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker set_SlryCycleEndDate;
        private System.Windows.Forms.DateTimePicker set_SlryCycleBeginDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox set_govtax;
        private System.Windows.Forms.TextBox set_empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCycleBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCycleEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryCycleDataRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GOVTAX;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}
