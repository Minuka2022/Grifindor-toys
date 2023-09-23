using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindor_toys
{
    public partial class Employe_CMP : UserControl
    {
        int empID;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OI2O0B7\\SQLEXPRESS;Initial Catalog=GTDB;Integrated Security=True");
        public Employe_CMP()
        {
            InitializeComponent();
            show();
            
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
            string dob = e_dob.Value.ToString("yyyy-MM-dd");
            string Joindate = e_joindate.Value.ToString("yyyy-MM-dd");

            int monthlysalary = Int32.Parse(e_monthlysalary.Text);
            int overtime = Int32.Parse(e_overtime.Text);
            int allowances = Int32.Parse(e_allowances.Text);

            emp.AddEmployee(e_fname.Text, e_lname.Text, e_gender.Text, e_address.Text, dob,  phone,e_joindate.Value, monthlysalary, overtime, allowances);

            MessageBox.Show("Record successfully added");
            show();

            e_fname.Clear();
            e_lname.Clear();
            e_address.Clear();
          
        }


        void show()
        {
            
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = dr[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = dr[10].ToString();
            }   
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                empID = int.Parse(selectedRow.Cells[0].Value.ToString());
                e_fname.Text = selectedRow.Cells[1].Value.ToString();
                e_lname.Text = selectedRow.Cells[2].Value.ToString();
                e_gender.Text = selectedRow.Cells[3].Value.ToString();
                e_address.Text = selectedRow.Cells[4].Value.ToString();
                e_dob.Text = selectedRow.Cells[5].Value.ToString();
                e_phone.Text = selectedRow.Cells[6].Value.ToString();
                e_joindate.Text = selectedRow.Cells[7].Value.ToString();
                e_monthlysalary.Text = selectedRow.Cells[8].Value.ToString();
                e_overtime.Text = selectedRow.Cells[9].Value.ToString();
                e_allowances.Text = selectedRow.Cells[10].Value.ToString();


            }else if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                int EMPID= int.Parse(selectedRow.Cells[0].Value.ToString());
                Employee emp2 = new Employee();
                emp2.DeleteEmployee(EMPID);
                show();
            }
        }

        private void e_btnupdate_Click(object sender, EventArgs e)
        {
            Employee emp3 = new Employee();
            int phone = Int32.Parse(e_phone.Text);
            string dob = e_dob.Value.ToString("yyyy-MM-dd");
            string Joindate = e_joindate.Value.ToString("yyyy-MM-dd");

            int monthlysalary = Int32.Parse(e_monthlysalary.Text);
            int overtime = Int32.Parse(e_overtime.Text);
            int allowances = Int32.Parse(e_allowances.Text);

            emp3.UpdateEmployee(e_fname.Text, e_lname.Text, e_gender.Text, e_address.Text, dob, phone, e_joindate.Value, monthlysalary, overtime, allowances);
            MessageBox.Show("Record successfully updated", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = e_search.Text;

            string searchQuery = "SELECT * FROM Employee WHERE EmpID like '%" + searchText + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(searchQuery, conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = dr[9].ToString();
                dataGridView1.Rows[n].Cells[10].Value = dr[10].ToString();
            }

        }


    }
}
