using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindor_toys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setting_CMP2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beginForm1.Show();
            employe_CMP1.Hide();
            salar_CMPy1.Hide();
            setting_CMP1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beginForm1.Hide();
            employe_CMP1.Show();
            salar_CMPy1.Hide();
            setting_CMP1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beginForm1.Hide();
            employe_CMP1.Hide();
            salar_CMPy1.Show();
            setting_CMP1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            beginForm1.Hide();
            employe_CMP1.Hide();
            salar_CMPy1.Hide();
            setting_CMP1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            beginForm1.Show();
            employe_CMP1.Hide();
            salar_CMPy1.Hide();
            setting_CMP1.Hide();
        }
    }
}
