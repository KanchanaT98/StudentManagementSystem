namespace StudentManagementSystem
{
    partial class StudentInformationForm
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
            StudentInformationLbl = new Label();
            StudentNoLbl = new Label();
            NameLbl = new Label();
            NameTxt = new TextBox();
            NicTxt = new TextBox();
            NicLbl = new Label();
            DobTxt = new TextBox();
            DobLbl = new Label();
            DeleteLink = new LinkLabel();
            SearchNicTxt = new TextBox();
            SearchBtn = new Button();
            SuspendLayout();
            // 
            // StudentInformationLbl
            // 
            StudentInformationLbl.AutoSize = true;
            StudentInformationLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentInformationLbl.Location = new Point(76, 37);
            StudentInformationLbl.Name = "StudentInformationLbl";
            StudentInformationLbl.Size = new Size(247, 32);
            StudentInformationLbl.TabIndex = 0;
            StudentInformationLbl.Text = "Student Information";
            // 
            // StudentNoLbl
            // 
            StudentNoLbl.AutoSize = true;
            StudentNoLbl.Location = new Point(180, 118);
            StudentNoLbl.Name = "StudentNoLbl";
            StudentNoLbl.Size = new Size(73, 15);
            StudentNoLbl.TabIndex = 1;
            StudentNoLbl.Text = "Student_NIC";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(180, 170);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(39, 15);
            NameLbl.TabIndex = 3;
            NameLbl.Text = "Name";
            NameLbl.Visible = false;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(295, 166);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(296, 23);
            NameTxt.TabIndex = 4;
            NameTxt.Visible = false;
            // 
            // NicTxt
            // 
            NicTxt.Location = new Point(295, 220);
            NicTxt.Name = "NicTxt";
            NicTxt.Size = new Size(296, 23);
            NicTxt.TabIndex = 6;
            NicTxt.Visible = false;
            // 
            // NicLbl
            // 
            NicLbl.AutoSize = true;
            NicLbl.Location = new Point(180, 224);
            NicLbl.Name = "NicLbl";
            NicLbl.Size = new Size(27, 15);
            NicLbl.TabIndex = 5;
            NicLbl.Text = "NIC";
            NicLbl.Visible = false;
            // 
            // DobTxt
            // 
            DobTxt.Location = new Point(295, 277);
            DobTxt.Name = "DobTxt";
            DobTxt.Size = new Size(296, 23);
            DobTxt.TabIndex = 8;
            DobTxt.Visible = false;
            // 
            // DobLbl
            // 
            DobLbl.AutoSize = true;
            DobLbl.Location = new Point(180, 281);
            DobLbl.Name = "DobLbl";
            DobLbl.Size = new Size(31, 15);
            DobLbl.TabIndex = 7;
            DobLbl.Text = "DOB";
            DobLbl.Visible = false;
            // 
            // DeleteLink
            // 
            DeleteLink.AutoSize = true;
            DeleteLink.Location = new Point(551, 356);
            DeleteLink.Name = "DeleteLink";
            DeleteLink.Size = new Size(40, 15);
            DeleteLink.TabIndex = 9;
            DeleteLink.TabStop = true;
            DeleteLink.Text = "Delete";
            DeleteLink.Visible = false;
            DeleteLink.LinkClicked += DeleteLink_LinkClicked;
            // 
            // SearchNicTxt
            // 
            SearchNicTxt.Location = new Point(295, 115);
            SearchNicTxt.Name = "SearchNicTxt";
            SearchNicTxt.Size = new Size(296, 23);
            SearchNicTxt.TabIndex = 10;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(628, 112);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(81, 27);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // StudentInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBtn);
            Controls.Add(SearchNicTxt);
            Controls.Add(DeleteLink);
            Controls.Add(DobTxt);
            Controls.Add(DobLbl);
            Controls.Add(NicTxt);
            Controls.Add(NicLbl);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            Controls.Add(StudentNoLbl);
            Controls.Add(StudentInformationLbl);
            Name = "StudentInformationForm";
            Text = "Student Information Form";
            Load += StudentInformationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentInformationLbl;
        private Label StudentNoLbl;
        private Label NameLbl;
        private TextBox NameTxt;
        private TextBox NicTxt;
        private Label NicLbl;
        private TextBox DobTxt;
        private Label DobLbl;
        private LinkLabel DeleteLink;
        private TextBox SearchNicTxt;
        private Button SearchBtn;
    }
}