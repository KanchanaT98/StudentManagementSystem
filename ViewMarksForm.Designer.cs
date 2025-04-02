namespace StudentManagementSystem
{
    partial class ViewMarksForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTxt = new TextBox();
            SemesterTxt = new TextBox();
            SubjectTxt = new TextBox();
            MarkTxt = new TextBox();
            SearchBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 46);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 0;
            label1.Text = "View Marks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 134);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 179);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 224);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(329, 346);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Mark";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(364, 130);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(195, 23);
            NameTxt.TabIndex = 5;
            // 
            // SemesterTxt
            // 
            SemesterTxt.Location = new Point(364, 175);
            SemesterTxt.Name = "SemesterTxt";
            SemesterTxt.Size = new Size(195, 23);
            SemesterTxt.TabIndex = 6;
            // 
            // SubjectTxt
            // 
            SubjectTxt.Location = new Point(364, 220);
            SubjectTxt.Name = "SubjectTxt";
            SubjectTxt.Size = new Size(195, 23);
            SubjectTxt.TabIndex = 7;
            // 
            // MarkTxt
            // 
            MarkTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MarkTxt.ForeColor = Color.Red;
            MarkTxt.Location = new Point(402, 340);
            MarkTxt.Name = "MarkTxt";
            MarkTxt.Size = new Size(65, 27);
            MarkTxt.TabIndex = 8;
            MarkTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.ActiveCaption;
            SearchBtn.Location = new Point(476, 270);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(83, 23);
            SearchBtn.TabIndex = 9;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ViewMarksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBtn);
            Controls.Add(MarkTxt);
            Controls.Add(SubjectTxt);
            Controls.Add(SemesterTxt);
            Controls.Add(NameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewMarksForm";
            Text = "View Marks Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTxt;
        private TextBox SemesterTxt;
        private TextBox SubjectTxt;
        private TextBox MarkTxt;
        private Button SearchBtn;
    }
}