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

        string ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public UpdateStudentInfoForm()
        {
            InitializeComponent();
        }

        private void UpdateSearchBtn_Click(object sender, EventArgs e)
        {
            //SqlDataReader reader = GetDetails();
            //if (reader.Read())
            //{
            //    NameLbl.Visible = true;
            //    NicLbl.Visible = true;
            //    DobLbl.Visible = true;
            //    NameTxt.Visible = true;
            //    NicTxt.Visible = true;
            //    DobDatePicker.Visible = true;
            //    UpdateStudentDataBtn.Visible = true;

            //    string OriginalName = reader["Student_No"].ToString();
            //    string OriginalNic = reader["NIC"].ToString();
            //    string OriginalDob = reader["DOB"].ToString();

            //    NameTxt.Text = OriginalName;
            //    NicTxt.Text = OriginalNic;
            //    DobDatePicker.Text = OriginalDob;
            //}
            //else
            //{
            //    MessageBox.Show("Error Occured");
            //}
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                Conn.Open();
                string getDetailsQuery = "Select Student_No, NIC, DOB From Student Where NIC=@NIC";
                try
                {
                    SqlCommand cmd = new SqlCommand(getDetailsQuery, Conn);
                    cmd.Parameters.AddWithValue("@NIC", NicUpdateTxt.Text.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        //private SqlDataReader GetDetails()
        //{
        //    using (SqlConnection Conn = new SqlConnection(ConnectionString))
        //    {
        //        Conn.Open();
        //        string getDetailsQuery = "Select Student_No, NIC, DOB From Student Where NIC=@NIC";
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand(getDetailsQuery, Conn);
        //            cmd.Parameters.AddWithValue("@NIC", NicUpdateTxt.Text.ToString());

        //            SqlDataReader reader = cmd.ExecuteReader();
        //            return reader;
        //            //if (reader.Read())
        //            //{
        //            //    NameLbl.Visible = true;
        //            //    NicLbl.Visible = true;
        //            //    DobLbl.Visible = true;
        //            //    NameTxt.Visible = true;
        //            //    NicTxt.Visible = true;
        //            //    DobDatePicker.Visible = true;
        //            //    UpdateStudentDataBtn.Visible = true;

        //            //    string OriginalName = reader["Student_No"].ToString();
        //            //    string OriginalNic = reader["NIC"].ToString();
        //            //    string OriginalDob = reader["DOB"].ToString();

        //            //    NameTxt.Text = OriginalName;
        //            //    NicTxt.Text = OriginalNic;
        //            //    DobDatePicker.Text = OriginalDob;
        //            //}
        //            //else
        //            //{
        //            //    MessageBox.Show("Error Occured");
        //            //}

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Error");
        //            return null;
        //        }
        //    }
        //}

        private void UpdateStudentDataBtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    bool IsEditted = false;
                    Conn.Open();
                    string getDetailsQuery = "Select Student_No, NIC, DOB From Student Where NIC=@NIC";
                    
                    SqlCommand cmd = new SqlCommand(getDetailsQuery, Conn);
                    cmd.Parameters.AddWithValue("@NIC", NicUpdateTxt.Text.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    string OriginalName = reader["Student_No"].ToString();
                    string OriginalNic = reader["NIC"].ToString();
                    string OriginalDob = reader["DOB"].ToString();

                    if (OriginalName != NameTxt.Text)
                    {
                        string UpdateNameQuery = "Update Student Set Student_No=@Name Where NIC=@NIC";
                        SqlCommand cmd1 = new SqlCommand(UpdateNameQuery, Conn);
                        cmd1.Parameters.AddWithValue("@NIC",NicUpdateTxt.Text.ToString());
                        cmd1.Parameters.AddWithValue("@Name", NameTxt.Text.ToString());
                        reader.Close();
                        int updatedRows1 = cmd1.ExecuteNonQuery();
                        IsEditted = true;

                    }

                    if (OriginalNic != NicTxt.Text)
                    {
                        string UpdateNicQuery = "Update Student Set NIC=@NICNew Where NIC=@NIC";
                        SqlCommand cmd2 = new SqlCommand(UpdateNicQuery, Conn);
                        cmd2.Parameters.AddWithValue("@NIC", NicTxt.Text);
                        cmd2.Parameters.AddWithValue("@NICNew", NicTxt.Text.ToString());
                        reader.Close();
                        int updatedRows2 = cmd2.ExecuteNonQuery();
                        IsEditted = true;

                    }

                    if (OriginalDob != DobDatePicker.Text.ToString())
                    {
                        string UpdateNameQuery = "Update Student Set DOB=@DOB Where NIC=@NIC";
                        SqlCommand cmd3 = new SqlCommand(UpdateNameQuery, Conn);
                        cmd3.Parameters.AddWithValue("@NIC", NicUpdateTxt.Text.ToString());
                        cmd3.Parameters.AddWithValue("@DOB", DobDatePicker.Value);
                        reader.Close();
                        cmd3.ExecuteNonQuery();
                        IsEditted = true;
                    }

                    if (IsEditted)
                    {
                        MessageBox.Show("Data Successfully Editted");
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
