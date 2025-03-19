namespace StudentManagementSystem
{
    partial class UpdateStudentInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateFormLbl = new Label();
            StudentNicLbl = new Label();
            NameLbl = new Label();
            NameTxt = new TextBox();
            NicTxt = new TextBox();
            NicLbl = new Label();
            DobLbl = new Label();
            DobDatePicker = new DateTimePicker();
            UpdateStudentDataBtn = new Button();
            UpdateSearchBtn = new Button();
            NicUpdateTxt = new TextBox();
            SuspendLayout();
            // 
            // UpdateFormLbl
            // 
            UpdateFormLbl.AutoSize = true;
            UpdateFormLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateFormLbl.Location = new Point(106, 35);
            UpdateFormLbl.Name = "UpdateFormLbl";
            UpdateFormLbl.Size = new Size(251, 32);
            UpdateFormLbl.TabIndex = 0;
            UpdateFormLbl.Text = "Update Student Data";
            // 
            // StudentNicLbl
            // 
            StudentNicLbl.AutoSize = true;
            StudentNicLbl.Location = new Point(198, 109);
            StudentNicLbl.Name = "StudentNicLbl";
            StudentNicLbl.Size = new Size(73, 15);
            StudentNicLbl.TabIndex = 1;
            StudentNicLbl.Text = "Student_NIC";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(198, 164);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(39, 15);
            NameLbl.TabIndex = 3;
            NameLbl.Text = "Name";
            NameLbl.Visible = false;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(297, 160);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(288, 23);
            NameTxt.TabIndex = 4;
            NameTxt.Visible = false;
            // 
            // NicTxt
            // 
            NicTxt.Location = new Point(297, 218);
            NicTxt.Name = "NicTxt";
            NicTxt.Size = new Size(288, 23);
            NicTxt.TabIndex = 6;
            NicTxt.Visible = false;
            // 
            // NicLbl
            // 
            NicLbl.AutoSize = true;
            NicLbl.Location = new Point(198, 222);
            NicLbl.Name = "NicLbl";
            NicLbl.Size = new Size(27, 15);
            NicLbl.TabIndex = 5;
            NicLbl.Text = "NIC";
            NicLbl.Visible = false;
            // 
            // DobLbl
            // 
            DobLbl.AutoSize = true;
            DobLbl.Location = new Point(198, 275);
            DobLbl.Name = "DobLbl";
            DobLbl.Size = new Size(31, 15);
            DobLbl.TabIndex = 7;
            DobLbl.Text = "DOB";
            DobLbl.Visible = false;
            // 
            // DobDatePicker
            // 
            DobDatePicker.Location = new Point(297, 271);
            DobDatePicker.Name = "DobDatePicker";
            DobDatePicker.Size = new Size(286, 23);
            DobDatePicker.TabIndex = 8;
            DobDatePicker.Visible = false;
            // 
            // UpdateStudentDataBtn
            // 
            UpdateStudentDataBtn.BackColor = Color.GreenYellow;
            UpdateStudentDataBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateStudentDataBtn.Location = new Point(347, 345);
            UpdateStudentDataBtn.Name = "UpdateStudentDataBtn";
            UpdateStudentDataBtn.Size = new Size(113, 31);
            UpdateStudentDataBtn.TabIndex = 9;
            UpdateStudentDataBtn.Text = "Update";
            UpdateStudentDataBtn.UseVisualStyleBackColor = false;
            UpdateStudentDataBtn.Visible = false;
            UpdateStudentDataBtn.Click += UpdateStudentDataBtn_Click;
            // 
            // UpdateSearchBtn
            // 
            UpdateSearchBtn.Location = new Point(611, 104);
            UpdateSearchBtn.Name = "UpdateSearchBtn";
            UpdateSearchBtn.Size = new Size(85, 27);
            UpdateSearchBtn.TabIndex = 10;
            UpdateSearchBtn.Text = "Search";
            UpdateSearchBtn.UseVisualStyleBackColor = true;
            UpdateSearchBtn.Click += UpdateSearchBtn_Click;
            // 
            // NicUpdateTxt
            // 
            NicUpdateTxt.Location = new Point(297, 106);
            NicUpdateTxt.Name = "NicUpdateTxt";
            NicUpdateTxt.Size = new Size(288, 23);
            NicUpdateTxt.TabIndex = 11;
            // 
            // UpdateStudentInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NicUpdateTxt);
            Controls.Add(UpdateSearchBtn);
            Controls.Add(UpdateStudentDataBtn);
            Controls.Add(DobDatePicker);
            Controls.Add(DobLbl);
            Controls.Add(NicTxt);
            Controls.Add(NicLbl);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            Controls.Add(StudentNicLbl);
            Controls.Add(UpdateFormLbl);
            Name = "UpdateStudentInfoForm";
            Text = "Update Student Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateFormLbl;
        private Label StudentNicLbl;
        private Label NameLbl;
        private TextBox NameTxt;
        private TextBox NicTxt;
        private Label NicLbl;
        private Label DobLbl;
        private DateTimePicker DobDatePicker;
        private Button UpdateStudentDataBtn;
        private Button UpdateSearchBtn;
        private TextBox NicUpdateTxt;
    }
}