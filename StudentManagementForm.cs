namespace StudentManagementSystem
{
    public partial class StudentManagementForm : Form
    {

        StudentInformationForm StInfo;
        AddStudent StAdd;
        UpdateStudentInfoForm StUpdate;
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StInfo == null)
            {
                StInfo = new StudentInformationForm();
                StInfo.MdiParent = this;
                StInfo.FormClosed += new FormClosedEventHandler(StInfo_FormClosed);
                StInfo.Show();

            }
            else
            {
                StInfo.Activate();
            }

        }
        void StInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            StInfo = null;
        }


        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StAdd == null)
            {
                StAdd = new AddStudent();
                StAdd.MdiParent = this;
                StAdd.FormClosed += new FormClosedEventHandler(StAdd_FormClosed);
                StAdd.Show();
            }
            else
            {
                StAdd.Activate();
            }
        }

        void StAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            StAdd = null;
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(StUpdate == null)
            {
                StUpdate = new UpdateStudentInfoForm();
                StUpdate.MdiParent = this;
                StUpdate.FormClosed += new FormClosedEventHandler(StUpdate_FormClosed);
                StUpdate.Show();
            }
            else
            {
                StUpdate.Activate();
            }
        }

        void StUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            StUpdate = null;
        }
    }
}
