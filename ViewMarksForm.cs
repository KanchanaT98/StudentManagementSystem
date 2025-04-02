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
    public partial class ViewMarksForm : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public ViewMarksForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    Conn.Open();
                    string searchMarkQuery = "Select Mark From Marks Join Student On Student_Id=StudentId Join Semester On Semester_Id=SemesterId Join Subject On Subject_Id=SubjectId Where Student_No=@Name And Semester=@Sem And Subject=@Subject";

                    SqlCommand cmd = new SqlCommand(searchMarkQuery, Conn);
                    cmd.Parameters.AddWithValue("@Name", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@Sem", SemesterTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@Subject", SubjectTxt.Text.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MarkTxt.Text = reader["Mark"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Data Found");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
