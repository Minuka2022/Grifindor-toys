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
    public partial class Employe_CMP : UserControl
    {
        public Employe_CMP()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            int phone = Int32.Parse(e_phone.Text);
            DateTime joindate = DateTime.Parse(e_joindate.Text);
            int monthlysalary = Int32.Parse(e_monthlysalary.Text);
            int overtime = Int32.Parse(e_overtime.Text);
            int allowances = Int32.Parse(e_allowances.Text);

            emp.AddEmployee(e_fname.Text, e_lname.Text, e_gender.Text , e_address.Text , e_dob.Text , phone , joindate, monthlysalary, overtime, allowances);

            MessageBox.Show("Record successfully added");

            e_fname.Clear();
            e_lname.Clear();
            e_address.Clear();


        }
    }
}
