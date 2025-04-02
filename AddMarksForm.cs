using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AddMarksForm : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public AddMarksForm()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection Conn = new SqlConnection(ConnectionString)){
                try
                {
                    Conn.Open();
                    string AddmarkStoredProcedure = "AddMarks";
                    SqlCommand cmd = new SqlCommand(AddmarkStoredProcedure, Conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Name", NameTxt.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@Semester", SemesterTxt.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@Subject", SubjectTxt.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@Mark", MarkTxt.Text.ToString()));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Marks Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
                finally
                {
                    Conn.Close();
                }
            }

        }
    }
}
