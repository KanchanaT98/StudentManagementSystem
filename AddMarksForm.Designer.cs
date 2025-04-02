namespace StudentManagementSystem
{
    partial class AddMarksForm
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
            FormTitleLbl = new Label();
            NameLbl = new Label();
            NameTxt = new TextBox();
            SemesterTxt = new TextBox();
            label1 = new Label();
            SubjectTxt = new TextBox();
            label2 = new Label();
            MarkTxt = new TextBox();
            label3 = new Label();
            SubmitBtn = new Button();
            SuspendLayout();
            // 
            // FormTitleLbl
            // 
            FormTitleLbl.AutoSize = true;
            FormTitleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormTitleLbl.Location = new Point(92, 35);
            FormTitleLbl.Name = "FormTitleLbl";
            FormTitleLbl.Size = new Size(138, 32);
            FormTitleLbl.TabIndex = 0;
            FormTitleLbl.Text = "Add Marks";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Microsoft Sans Serif", 8.25F);
            NameLbl.Location = new Point(199, 109);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(75, 13);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "Student Name";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(348, 104);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(274, 23);
            NameTxt.TabIndex = 2;
            // 
            // SemesterTxt
            // 
            SemesterTxt.Location = new Point(348, 160);
            SemesterTxt.Name = "SemesterTxt";
            SemesterTxt.Size = new Size(274, 23);
            SemesterTxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(199, 165);
            label1.Name = "label1";
            label1.Size = new Size(51, 13);
            label1.TabIndex = 3;
            label1.Text = "Semester";
            // 
            // SubjectTxt
            // 
            SubjectTxt.Location = new Point(348, 218);
            SubjectTxt.Name = "SubjectTxt";
            SubjectTxt.Size = new Size(274, 23);
            SubjectTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(199, 223);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 5;
            label2.Text = "Subject";
            // 
            // MarkTxt
            // 
            MarkTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarkTxt.ForeColor = Color.Red;
            MarkTxt.Location = new Point(348, 270);
            MarkTxt.Name = "MarkTxt";
            MarkTxt.Size = new Size(71, 33);
            MarkTxt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(199, 282);
            label3.Name = "label3";
            label3.Size = new Size(31, 13);
            label3.TabIndex = 7;
            label3.Text = "Mark";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.Chartreuse;
            SubmitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.Location = new Point(536, 355);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(86, 27);
            SubmitBtn.TabIndex = 9;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // AddMarksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitBtn);
            Controls.Add(MarkTxt);
            Controls.Add(label3);
            Controls.Add(SubjectTxt);
            Controls.Add(label2);
            Controls.Add(SemesterTxt);
            Controls.Add(label1);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            Controls.Add(FormTitleLbl);
            Name = "AddMarksForm";
            Text = "AddMarksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormTitleLbl;
        private Label NameLbl;
        private TextBox NameTxt;
        private TextBox SemesterTxt;
        private Label label1;
        private TextBox SubjectTxt;
        private Label label2;
        private TextBox MarkTxt;
        private Label label3;
        private Button SubmitBtn;
    }
}