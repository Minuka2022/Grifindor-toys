using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Drawing;

namespace Grifindor_toys
{
    internal class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public int Phone { get; set; }
        public DateTime JoinDate { get; set; }
        public int MonthlySalary { get; set; }
        public int OvertimeRate { get; set; }
        public int Allowances { get; set; }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OI2O0B7\\SQLEXPRESS;Initial Catalog=GTDB;Integrated Security=True");

        public void AddEmployee(string fname, string lname, string gender, string address, string DOB, int phone, DateTime JoinDate, int Monthslry, int overtimeRate, int allowances)
        {
            try
            {
                
                using (conn)
                {
                    conn.Open();

                    string sql = "INSERT INTO Employee(Fname, Lname, Gender, Address, DOB, Phone, JoinDate, MonthSlry, OvertimeRate, Allowances) " +
                                 "VALUES (@Fname, @Lname, @Gender, @Address, @DOB, @Phone, @JoinDate, @MonthSlry, @OvertimeRate, @Allowances)";

                    using (SqlCommand qry = new SqlCommand(sql, conn))
                    {
                        qry.Parameters.AddWithValue("@Fname", fname);
                        qry.Parameters.AddWithValue("@Lname", lname);
                        qry.Parameters.AddWithValue("@Gender", gender);
                        qry.Parameters.AddWithValue("@Address", address);
                        qry.Parameters.AddWithValue("@DOB", DOB);
                        qry.Parameters.AddWithValue("@Phone", phone);
                        qry.Parameters.AddWithValue("@JoinDate", JoinDate);
                        qry.Parameters.AddWithValue("@MonthSlry", Monthslry);
                        qry.Parameters.AddWithValue("@OvertimeRate", overtimeRate);
                        qry.Parameters.AddWithValue("@Allowances", allowances);

                        qry.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR OCCURRED: " + ex.Message);
            }
        }


        public void UpdateEmployee(string fname, string lname, string gender, string address, string DOB, int phone, DateTime JoinDate, int Monthslry, int overtimeRate, int allowances)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE Employee SET Fname = '" + fname + "' , Lname = '" + lname + "' , Gender = '" + gender + "' , Address = '" + address + "' , DOB = '" + DOB + "' , Phone = '" + phone + "' , JoinDate = '" + JoinDate + "' , MonthSlry = '" + Monthslry + "' , OvertimeRate = '" + overtimeRate + "' , Allowances = '" + allowances + "' ";
                SqlCommand sc = new SqlCommand(sql, conn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                {
                    MessageBox.Show("Apartment updated");

                }
                else
                {
                    MessageBox.Show("Apartment not updateds");
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error occurd" + ex.Message);
            }
        }


        public void DeleteEmployee(int empID)
        {
            conn.Open();
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "DELETE FROM Employee WHERE EmpID = '" + empID + "' ";
                SqlCommand de = new SqlCommand(qry, conn);
                int i = de.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Record deleted");

                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();

            }
        }

        
        

    }
}
