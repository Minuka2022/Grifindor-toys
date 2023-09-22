namespace Grifindor_toys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.beginForm1 = new Grifindor_toys.BeginForm();
            this.setting_CMP1 = new Grifindor_toys.Setting_CMP();
            this.salar_CMPy1 = new Grifindor_toys.Salar_CMPy();
            this.employe_CMP1 = new Grifindor_toys.Employe_CMP();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 633);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 114);
            this.button3.TabIndex = 0;
            this.button3.Text = "Setting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 114);
            this.button2.TabIndex = 0;
            this.button2.Text = "Salary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 114);
            this.button1.TabIndex = 0;
            this.button1.Text = "Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grifindo Toys";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // beginForm1
            // 
            this.beginForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beginForm1.BackgroundImage")));
            this.beginForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beginForm1.Location = new System.Drawing.Point(206, 0);
            this.beginForm1.Name = "beginForm1";
            this.beginForm1.Size = new System.Drawing.Size(977, 641);
            this.beginForm1.TabIndex = 4;
            // 
            // setting_CMP1
            // 
            this.setting_CMP1.Location = new System.Drawing.Point(206, 0);
            this.setting_CMP1.Name = "setting_CMP1";
            this.setting_CMP1.Size = new System.Drawing.Size(977, 641);
            this.setting_CMP1.TabIndex = 3;
            // 
            // salar_CMPy1
            // 
            this.salar_CMPy1.Location = new System.Drawing.Point(206, 0);
            this.salar_CMPy1.Name = "salar_CMPy1";
            this.salar_CMPy1.Size = new System.Drawing.Size(977, 641);
            this.salar_CMPy1.TabIndex = 2;
            // 
            // employe_CMP1
            // 
            this.employe_CMP1.Location = new System.Drawing.Point(206, 0);
            this.employe_CMP1.Name = "employe_CMP1";
            this.employe_CMP1.Size = new System.Drawing.Size(977, 641);
            this.employe_CMP1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 633);
            this.Controls.Add(this.beginForm1);
            this.Controls.Add(this.setting_CMP1);
            this.Controls.Add(this.salar_CMPy1);
            this.Controls.Add(this.employe_CMP1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Employe_CMP employe_CMP1;
        private Salar_CMPy salar_CMPy1;
        private Setting_CMP setting_CMP1;
        private BeginForm beginForm1;
        private System.Windows.Forms.Label label1;
    }
}

