using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindor_toys
{
    public partial class Setting_CMP : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OI2O0B7\\SQLEXPRESS;Initial Catalog=GTDB;Integrated Security=True");
        int RecID;
        public Setting_CMP()
        {
            InitializeComponent();
            show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int slryDateRange = int.Parse(set_SryCycleDateRange.Text);
            int OT = int.Parse(set_OT.Text);
            int empId = int.Parse(set_empid.Text.ToString());
            int govTax = int.Parse(set_govtax.Text.ToString());

            Setting set1 = new Setting();
            set1.AddRecord(set_SlryCycleBeginDate.Value, set_SlryCycleEndDate.Value, slryDateRange, OT , empId , govTax);
            MessageBox.Show("Record added successfullly");
            show();
        }

        void show()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Setting", conn);
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
                


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                RecID = int.Parse(selectedRow.Cells[0].ToString());
                set_empid.Text = selectedRow.Cells[1].Value.ToString();
                set_SlryCycleBeginDate.Text = selectedRow.Cells[2].ToString();
                set_SlryCycleEndDate.Text = selectedRow.Cells[3].Value.ToString();
                set_SryCycleDateRange.Text = selectedRow.Cells[4].Value.ToString();
                set_OT.Text = selectedRow.Cells[5].Value.ToString();
                set_govtax.Text = selectedRow.Cells[6].Value.ToString();





            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                int RECID = int.Parse(selectedRow.Cells[0].Value.ToString());
                Setting set2 = new Setting();
                set2.RemoveRecord(RECID);
                show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int slryDateRange = int.Parse(set_SryCycleDateRange.Text);
            int OT = int.Parse(set_OT.Text);
            int empId = int.Parse(set_empid.Text.ToString());
            int govTax = int.Parse(set_govtax.ToString());

            Setting set3 = new Setting();
            set3.AddRecord(set_SlryCycleBeginDate.Value, set_SlryCycleEndDate.Value, slryDateRange, OT , empId ,govTax);
            MessageBox.Show("Record Updated successfullly");
            show();
        }
    }
}
