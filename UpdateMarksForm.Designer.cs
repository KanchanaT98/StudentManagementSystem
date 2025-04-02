namespace StudentManagementSystem
{
    partial class UpdateMarksForm
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
            UpdateMarksLbl = new Label();
            NameLbl = new Label();
            NameTxt = new TextBox();
            SearchBtn = new Button();
            SemesterLbl = new Label();
            SubjectLbl = new Label();
            MarkTxt = new TextBox();
            MarkLbl = new Label();
            UpdateBtn = new Button();
            SemesterCmb = new ComboBox();
            SubjectCmb = new ComboBox();
            ClearLbl = new LinkLabel();
            SuspendLayout();
            // 
            // UpdateMarksLbl
            // 
            UpdateMarksLbl.AutoSize = true;
            UpdateMarksLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMarksLbl.Location = new Point(96, 37);
            UpdateMarksLbl.Name = "UpdateMarksLbl";
            UpdateMarksLbl.Size = new Size(173, 32);
            UpdateMarksLbl.TabIndex = 0;
            UpdateMarksLbl.Text = "Update Marks";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(182, 126);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(83, 15);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "Student Name";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(324, 122);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(281, 23);
            NameTxt.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Chartreuse;
            SearchBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(506, 174);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(99, 28);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SemesterLbl
            // 
            SemesterLbl.AutoSize = true;
            SemesterLbl.Location = new Point(182, 197);
            SemesterLbl.Name = "SemesterLbl";
            SemesterLbl.Size = new Size(55, 15);
            SemesterLbl.TabIndex = 4;
            SemesterLbl.Text = "Semester";
            SemesterLbl.Visible = false;
            // 
            // SubjectLbl
            // 
            SubjectLbl.AutoSize = true;
            SubjectLbl.Location = new Point(182, 266);
            SubjectLbl.Name = "SubjectLbl";
            SubjectLbl.Size = new Size(46, 15);
            SubjectLbl.TabIndex = 6;
            SubjectLbl.Text = "Subject";
            SubjectLbl.Visible = false;
            // 
            // MarkTxt
            // 
            MarkTxt.Location = new Point(324, 339);
            MarkTxt.Name = "MarkTxt";
            MarkTxt.Size = new Size(80, 23);
            MarkTxt.TabIndex = 9;
            MarkTxt.Visible = false;
            // 
            // MarkLbl
            // 
            MarkLbl.AutoSize = true;
            MarkLbl.Location = new Point(182, 343);
            MarkLbl.Name = "MarkLbl";
            MarkLbl.Size = new Size(61, 15);
            MarkLbl.TabIndex = 8;
            MarkLbl.Text = "New Mark";
            MarkLbl.Visible = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Chartreuse;
            UpdateBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(506, 384);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(99, 28);
            UpdateBtn.TabIndex = 10;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Visible = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // SemesterCmb
            // 
            SemesterCmb.FormattingEnabled = true;
            SemesterCmb.Location = new Point(322, 194);
            SemesterCmb.Name = "SemesterCmb";
            SemesterCmb.Size = new Size(283, 23);
            SemesterCmb.TabIndex = 11;
            SemesterCmb.Visible = false;
            // 
            // SubjectCmb
            // 
            SubjectCmb.FormattingEnabled = true;
            SubjectCmb.Location = new Point(322, 258);
            SubjectCmb.Name = "SubjectCmb";
            SubjectCmb.Size = new Size(283, 23);
            SubjectCmb.TabIndex = 12;
            SubjectCmb.Visible = false;
            // 
            // ClearLbl
            // 
            ClearLbl.AutoSize = true;
            ClearLbl.Location = new Point(571, 51);
            ClearLbl.Name = "ClearLbl";
            ClearLbl.Size = new Size(34, 15);
            ClearLbl.TabIndex = 13;
            ClearLbl.TabStop = true;
            ClearLbl.Text = "Clear";
            ClearLbl.Visible = false;
            ClearLbl.LinkClicked += ClearLbl_LinkClicked;
            // 
            // UpdateMarksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearLbl);
            Controls.Add(SubjectCmb);
            Controls.Add(SemesterCmb);
            Controls.Add(UpdateBtn);
            Controls.Add(MarkTxt);
            Controls.Add(MarkLbl);
            Controls.Add(SubjectLbl);
            Controls.Add(SemesterLbl);
            Controls.Add(SearchBtn);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            Controls.Add(UpdateMarksLbl);
            Name = "UpdateMarksForm";
            Text = "UpdateMarksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateMarksLbl;
        private Label NameLbl;
        private TextBox NameTxt;
        private Button SearchBtn;
        private Label SemesterLbl;
        private Label SubjectLbl;
        private TextBox MarkTxt;
        private Label MarkLbl;
        private Button UpdateBtn;
        private ComboBox SemesterCmb;
        private ComboBox SubjectCmb;
        private LinkLabel ClearLbl;
    }
}