using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

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


        public void AddEmployee(string fname , string lname , string gender , string address , string DOB , int phone ,  DateTime JoinDate , int Monthslry , int overtimeRate , int allowances)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OI2O0B7\\SQLEXPRESS;Initial Catalog=GTDB;Integrated Security=True");
                string sql = "INSERT INTO Employee(Fname , Lname , Gender , Address , Phone , JoinDate , MonthSlry , OvertimeRate , Allowances) values ('" + fname + "','" + lname + "' , '" + gender + "' , '" + address + "' , '" + DOB + "' , '" + phone + "' , '" + JoinDate + "' , '" + Monthslry + "' , '" + overtimeRate + "' , '" + allowances + "') ";

                conn.Open();

                SqlCommand qry = new SqlCommand(sql, conn);
                qry.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("ERROR OCCURD");
            }



        }
    }
}
