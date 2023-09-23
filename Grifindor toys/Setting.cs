using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grifindor_toys
{
    internal class Setting
    {
        public DateTime SalaryCycleBeginDate { get; set; }
        public DateTime SalaryCycleEndDate { get; set; }
        public int SalaryCycleDateRange { get; set; }
        public int OT { get; set; }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OI2O0B7\\SQLEXPRESS;Initial Catalog=GTDB;Integrated Security=True");
        public void AddRecord(DateTime SlryBeginDate , DateTime SlryEndDate , int SlryDateRange , int OT , int EmpID , int GovermentTax)
        {
            try
            {

                using (conn)
                {
                    conn.Open();

                    string sql = "INSERT INTO Setting(SalaryCycleBeginDate , SalaryCycleEndDate , SalaryCycleDateRange , OT , EmpID , GovermentTax) " +
                                 "VALUES (@SalaryCycleBeginDate , @SalaryCycleEndDate , @SalaryCycleDateRange , @OT , @EmpID , @GovermentTax)";

                    using (SqlCommand qry = new SqlCommand(sql, conn))
                    {
                        qry.Parameters.AddWithValue("@SalaryCycleBeginDate", SlryBeginDate);
                        qry.Parameters.AddWithValue("@SalaryCycleEndDate", SlryEndDate);
                        qry.Parameters.AddWithValue("@SalaryCycleDateRange", SlryDateRange);
                        qry.Parameters.AddWithValue("@OT", OT);
                        qry.Parameters.AddWithValue("@EmpID", EmpID);
                        qry.Parameters.AddWithValue("@GovermentTax",GovermentTax);


                        qry.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR OCCURRED: " + ex.Message);
            }
        }
        public void RemoveRecord(int RecID)
        {
            conn.Open();
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "DELETE FROM Setting WHERE RecID = '" + RecID + "' ";
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
        public void UpdateRecord(DateTime SlryBeginDate, DateTime SlryEndDate, int SlryDateRange, int OT , int EmpID ,  int GovermentTax)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE Employee SET SalaryCycleBeginDate = '" + SlryBeginDate + "' , SalaryCycleEndDate = '" + SlryEndDate + "' , SalaryCycleDateRange = '" + SlryDateRange + "' , OT = '" + OT + "' , EmpID = '" + EmpID + "' , GovermentTax = '" + "' , EmpID = '" + EmpID+GovermentTax+"'  ";
                SqlCommand sc = new SqlCommand(sql, conn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                {
                    MessageBox.Show("Record updated");

                }
                else
                {
                    MessageBox.Show("Record not updated");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurd" + ex.Message);
            }
        }


   
    }
}
