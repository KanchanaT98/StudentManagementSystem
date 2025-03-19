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
    public partial class AddStudent : Form
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    Conn.Open();
                    string AddStudentQuery = "Insert Into Student(Student_No,NIC,DOB) Values (@Name, @NIC, @DOB)";
                    SqlCommand cmd = new SqlCommand(AddStudentQuery, Conn);
                    cmd.Parameters.AddWithValue("@Name", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@NIC", NicTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@DOB", DobPicker.Value);

                    //SqlDataReader reader = cmd.ExecuteReader();
                    //reader.Close();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Student Successfully Added");
                        NameTxt.Clear();
                        NicTxt.Clear();
                        DobPicker.ResetText();
                    }
                    Conn.Close();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
