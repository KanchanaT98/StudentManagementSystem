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
    public partial class UpdateMarksForm : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public UpdateMarksForm()
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
                    string StudentExistStoredProcedure = "CheckStudentAvailability";
                    SqlCommand cmd = new SqlCommand(StudentExistStoredProcedure, Conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Name", NameTxt.Text.ToString()));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No Marks recorded for this Student");
                        }
                        reader.Close();
                        Conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void LoadData()
        {
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    SearchBtn.Visible = false;
                    SemesterLbl.Visible = true;
                    SemesterCmb.Visible = true;
                    SubjectLbl.Visible = true;
                    SubjectCmb.Visible = true;
                    MarkLbl.Visible = true;
                    MarkTxt.Visible = true;
                    UpdateBtn.Visible = true;
                    ClearLbl.Visible = true;

                    Conn.Open();
                    string GetSemesterDetailsStoredProcedure = "GetSemesters";
                    using (SqlCommand cmd = new SqlCommand(GetSemesterDetailsStoredProcedure, Conn))
                    {

                        SqlDataReader StudentReader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(StudentReader);

                        SemesterCmb.DataSource = dt;
                        SemesterCmb.ValueMember = "SemesterId";
                        SemesterCmb.DisplayMember = "Semester";

                        StudentReader.Close();

                    }

                    string GetSubjectDetailsStoredProcedure = "GetSubjects";
                    using (SqlCommand cmd = new SqlCommand(GetSubjectDetailsStoredProcedure, Conn))
                    {

                        SqlDataReader StudentReader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(StudentReader);

                        SubjectCmb.DataSource = dt;
                        SubjectCmb.ValueMember = "SubjectId";
                        SubjectCmb.DisplayMember = "Subject";

                        StudentReader.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    string isMarkExistQuery = "Select * From Marks Where Semester_Id=@SemesterId AND Subject_Id=@SubjectId";
                    Conn.Open();
                    using (SqlCommand cmd = new SqlCommand(isMarkExistQuery, Conn))
                    {
                        cmd.Parameters.AddWithValue("@SemesterId", SemesterCmb.SelectedValue);
                        cmd.Parameters.AddWithValue("@SubjectId", SubjectCmb.SelectedValue);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (!reader.Read())
                        {
                            MessageBox.Show("Marks does not exist for this Semester or Subject");
                            return;
                        }
                        reader.Close();
                    }
                    UpdateMarks(Conn);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error");
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void UpdateMarks(SqlConnection Conn)
        {
            try
            {
                string UpdateMarkStoredProcedure = "UpdateMark";
                using (SqlCommand cmd = new SqlCommand(UpdateMarkStoredProcedure, Conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int updatedMark = Convert.ToInt16(MarkTxt.Text);
                    cmd.Parameters.Add(new SqlParameter("@Mark", updatedMark));
                    cmd.Parameters.Add(new SqlParameter("@Name", NameTxt.Text));
                    cmd.Parameters.Add(new SqlParameter("@SemesterId", SemesterCmb.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@SubjectId", SubjectCmb.SelectedValue));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Marks Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("This student does not have any marks recorded for this Semester or subject");
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }

        

        private void ClearLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NameTxt.Clear();
            SearchBtn.Visible = true;
            SemesterLbl.Visible = false;
            SemesterCmb.Visible = false;
            SemesterCmb.DataSource = null;
            SubjectLbl.Visible = false;
            SubjectCmb.Visible = false;
            SubjectCmb.DataSource = null;
            MarkLbl.Visible = false;
            MarkTxt.Visible = false;
            MarkTxt.Clear();
            UpdateBtn.Visible = false;
            ClearLbl.Visible = false;
        }
    }
}
