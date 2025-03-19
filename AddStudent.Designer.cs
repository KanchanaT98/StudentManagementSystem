namespace StudentManagementSystem
{
    partial class AddStudent
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
            AddStudentLbl = new Label();
            StudentNoLbl = new Label();
            StudentNoTxt = new TextBox();
            NameTxt = new TextBox();
            NameLbl = new Label();
            NicTxt = new TextBox();
            NicLbl = new Label();
            DobLbl = new Label();
            DobPicker = new DateTimePicker();
            AddStudentBtn = new Button();
            SuspendLayout();
            // 
            // AddStudentLbl
            // 
            AddStudentLbl.AutoSize = true;
            AddStudentLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddStudentLbl.Location = new Point(109, 41);
            AddStudentLbl.Name = "AddStudentLbl";
            AddStudentLbl.Size = new Size(156, 32);
            AddStudentLbl.TabIndex = 0;
            AddStudentLbl.Text = "Add Student";
            // 
            // StudentNoLbl
            // 
            StudentNoLbl.AutoSize = true;
            StudentNoLbl.Location = new Point(197, 109);
            StudentNoLbl.Name = "StudentNoLbl";
            StudentNoLbl.Size = new Size(69, 15);
            StudentNoLbl.TabIndex = 1;
            StudentNoLbl.Text = "Student_No";
            // 
            // StudentNoTxt
            // 
            StudentNoTxt.Location = new Point(341, 105);
            StudentNoTxt.Name = "StudentNoTxt";
            StudentNoTxt.Size = new Size(275, 23);
            StudentNoTxt.TabIndex = 2;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(341, 160);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(275, 23);
            NameTxt.TabIndex = 4;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(197, 164);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(39, 15);
            NameLbl.TabIndex = 3;
            NameLbl.Text = "Name";
            // 
            // NicTxt
            // 
            NicTxt.Location = new Point(341, 216);
            NicTxt.Name = "NicTxt";
            NicTxt.Size = new Size(275, 23);
            NicTxt.TabIndex = 6;
            // 
            // NicLbl
            // 
            NicLbl.AutoSize = true;
            NicLbl.Location = new Point(197, 220);
            NicLbl.Name = "NicLbl";
            NicLbl.Size = new Size(27, 15);
            NicLbl.TabIndex = 5;
            NicLbl.Text = "NIC";
            // 
            // DobLbl
            // 
            DobLbl.AutoSize = true;
            DobLbl.Location = new Point(197, 279);
            DobLbl.Name = "DobLbl";
            DobLbl.Size = new Size(31, 15);
            DobLbl.TabIndex = 7;
            DobLbl.Text = "DOB";
            // 
            // DobPicker
            // 
            DobPicker.Location = new Point(341, 275);
            DobPicker.Name = "DobPicker";
            DobPicker.Size = new Size(275, 23);
            DobPicker.TabIndex = 8;
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.BackColor = Color.YellowGreen;
            AddStudentBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddStudentBtn.Location = new Point(346, 342);
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(117, 33);
            AddStudentBtn.TabIndex = 9;
            AddStudentBtn.Text = "Submit";
            AddStudentBtn.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddStudentBtn);
            Controls.Add(DobPicker);
            Controls.Add(DobLbl);
            Controls.Add(NicTxt);
            Controls.Add(NicLbl);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            Controls.Add(StudentNoTxt);
            Controls.Add(StudentNoLbl);
            Controls.Add(AddStudentLbl);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddStudentLbl;
        private Label StudentNoLbl;
        private TextBox StudentNoTxt;
        private TextBox NameTxt;
        private Label NameLbl;
        private TextBox NicTxt;
        private Label NicLbl;
        private Label DobLbl;
        private DateTimePicker DobPicker;
        private Button AddStudentBtn;
    }
}