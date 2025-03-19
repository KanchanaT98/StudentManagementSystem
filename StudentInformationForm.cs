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
    public partial class StudentInformationForm : Form
    {
        //string ConnectionString = "Data Source=NOV-DEV-INTERN\\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public StudentInformationForm()
        {
            InitializeComponent();
        }

        private void StudentInformationForm_Load(object sender, EventArgs e)
        {
            //StudentNoCmb.Text = "Select Student No";

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    Conn.Open();
                    var getDetailsQuery = "Select Student_No, NIC, DOB from Student where NIC = @NIC";
                    SqlCommand cmd = new SqlCommand(getDetailsQuery, Conn);
                    cmd.Parameters.AddWithValue("@NIC", SearchNicTxt.Text.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        NameLbl.Visible = true;
                        NicLbl.Visible = true;
                        DobLbl.Visible = true;
                        NameTxt.Visible = true;
                        NicTxt.Visible = true;
                        DobTxt.Visible = true;
                        DeleteLink.Visible = true;

                        NameTxt.Text = reader["Student_No"].ToString();
                        NicTxt.Text = reader["NIC"].ToString();
                        DobTxt.Text = reader["DOB"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Data to Show");
                    }
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
        }

        private void DeleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(ConnectionString))
                {
                    Conn.Open();
                    string deleteStudentQuery = "Delete from Student Where NIC = @NIC";
                    SqlCommand cmd = new SqlCommand(deleteStudentQuery, Conn);
                    cmd.Parameters.AddWithValue("@NIC", NicTxt.Text.ToString());

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Record Deleted");
                        SearchNicTxt.Clear();
                        NameTxt.Clear();
                        NicTxt.Clear();
                        DobTxt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error occured");
                    }

                    Conn.Close();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        //private void StudentNoCmb_Click(object sender, EventArgs e)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        var StudentNoQuery = "Select StudentId,NIC from Student";

        //        try
        //        {
        //            using (SqlCommand cmd = new SqlCommand(StudentNoQuery, conn))
        //            {
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {

        //                    DataTable StuNo = new DataTable();
        //                    StuNo.Load(reader);
        //                    StudentNoCmb.DataSource = StuNo;
        //                    StudentNoCmb.DisplayMember = "NIC";
        //                    StudentNoCmb.ValueMember = "StudentId";
        //                }
        //            }
        //            conn.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Error");
        //        }
        //    }
        //}

        //private void StudentNoCmb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (StudentNoCmb.SelectedValue != null) {
        //        using (SqlConnection Conn = new SqlConnection(ConnectionString))
        //        {
        //            try
        //            {
        //                Conn.Open();
        //                //LoadStudentDetails(Conn);
        //                var StudentDetailsQuery = "Select Student_No, NIC, DOB from Student Where NIC=@Nic";
        //                SqlCommand cmd = new SqlCommand(StudentDetailsQuery, Conn);
        //                int selectedStdId = Convert.ToInt32((StudentNoCmb.SelectedValue as DataRowView)?["NIC"] ?? StudentNoCmb.SelectedValue);
        //                cmd.Parameters.AddWithValue("@Nic", selectedStdId);

        //                SqlDataReader reader = cmd.ExecuteReader();

        //                if (reader.Read())
        //                {
        //                    DataTable dt = new DataTable();
        //                    dt.Load(reader);

        //                    NameLbl.Visible = true;
        //                    NicLbl.Visible = true;
        //                    DobLbl.Visible = true;
        //                    NameTxt.Visible = true;
        //                    NicTxt.Visible = true;
        //                    DobTxt.Visible = true;
        //                    DeleteLink.Visible = true;

        //                    NameTxt.Text = reader["Student_No"].ToString();
        //                    NicTxt.Text = reader["NIC"].ToString();
        //                    DobTxt.Text = reader["DOB"].ToString();

        //                }
        //                else
        //                {
        //                    MessageBox.Show("No Data to Show");
        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message, "Error");
        //            }
        //        }
        //    }
        //}


    }
}
