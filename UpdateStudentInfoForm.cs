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
    public partial class UpdateStudentInfoForm : Form
    {
        public UpdateStudentInfoForm()
        {
            InitializeComponent();
        }

        private void UpdateSearchBtn_Click(object sender, EventArgs e)
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                Conn.Open();
                string getDetailsQuery = "Select Student_No, NIC, DOB From Student Where NIC=@NIC";
                try
                {
                    SqlCommand cmd = new SqlCommand(getDetailsQuery, Conn);
                    cmd.Parameters.AddWithValue("@NIC", NicUpdateTxt.Text.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) { 
                        NameLbl.Visible = true;
                        NicLbl.Visible = true;
                        DobLbl.Visible = true;
                        NameTxt.Visible = true;
                        NicTxt.Visible = true;
                        DobDatePicker.Visible = true;
                        UpdateStudentDataBtn.Visible = true;

                        string OriginalName = reader["Student_No"].ToString();
                        string OriginalNic = reader["NIC"].ToString();
                        string OriginalDob = reader["DOB"].ToString();

                        NameTxt.Text = OriginalName;
                        NicTxt.Text = OriginalNic;
                        DobDatePicker.Text = OriginalDob;
                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
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
