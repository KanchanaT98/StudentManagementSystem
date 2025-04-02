namespace StudentManagementSystem
{
    public partial class StudentManagementForm : Form
    {

        StudentInformationForm StInfo;
        AddStudent StAdd;
        UpdateStudentInfoForm StUpdate;

        AddMarksForm AddMarks;
        ViewMarksForm ViewMarks;
        UpdateMarksForm updateMarks;

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
            if (StUpdate == null)
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

        private void AddMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AddMarks == null)
            {
                AddMarks = new AddMarksForm();
                AddMarks.MdiParent = this;
                AddMarks.FormClosed += new FormClosedEventHandler(AddMarksForm_Closed);
                AddMarks.Show();
            }
        }

        private void AddMarksForm_Closed(object sender, FormClosedEventArgs e)
        {
            AddMarks = null;
        }

        private void ViewMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ViewMarks == null)
            {
                ViewMarks = new ViewMarksForm();
                ViewMarks.MdiParent = this;
                ViewMarks.FormClosed += new FormClosedEventHandler(ViewMarksForm_Closed);
                ViewMarks.Show();
            }
        }

        private void ViewMarksForm_Closed(object sender, FormClosedEventArgs e)
        {
            ViewMarks = null;
        }

        private void UpdateMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updateMarks == null)
            {
                updateMarks = new UpdateMarksForm();
                updateMarks.MdiParent = this;
                updateMarks.FormClosed += new FormClosedEventHandler(UpdateMarksForm_Closed);
                updateMarks.Show();
            }
        }

        private void UpdateMarksForm_Closed(object sender, FormClosedEventArgs e)
        {
            updateMarks = null;
        }
    }
}
