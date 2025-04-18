﻿
namespace StudentManagementSystem
{
    partial class StudentManagementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            studentInformationToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            updateStudentToolStripMenuItem = new ToolStripMenuItem();
            marksToolStripMenuItem = new ToolStripMenuItem();
            addMarksToolStripMenuItem = new ToolStripMenuItem();
            addMarksToolStripMenuItem1 = new ToolStripMenuItem();
            updateMarksToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, marksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentInformationToolStripMenuItem, addStudentToolStripMenuItem, updateStudentToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // studentInformationToolStripMenuItem
            // 
            studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            studentInformationToolStripMenuItem.Size = new Size(181, 22);
            studentInformationToolStripMenuItem.Text = "Student Information";
            studentInformationToolStripMenuItem.Click += studentInformationToolStripMenuItem_Click;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(181, 22);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // updateStudentToolStripMenuItem
            // 
            updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            updateStudentToolStripMenuItem.Size = new Size(181, 22);
            updateStudentToolStripMenuItem.Text = "Update Student";
            updateStudentToolStripMenuItem.Click += updateStudentToolStripMenuItem_Click;
            // 
            // marksToolStripMenuItem
            // 
            marksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addMarksToolStripMenuItem, addMarksToolStripMenuItem1, updateMarksToolStripMenuItem });
            marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            marksToolStripMenuItem.Size = new Size(51, 20);
            marksToolStripMenuItem.Text = "Marks";
            // 
            // addMarksToolStripMenuItem
            // 
            addMarksToolStripMenuItem.Name = "addMarksToolStripMenuItem";
            addMarksToolStripMenuItem.Size = new Size(180, 22);
            addMarksToolStripMenuItem.Text = "View Marks";
            addMarksToolStripMenuItem.Click += ViewMarksToolStripMenuItem_Click;
            // 
            // addMarksToolStripMenuItem1
            // 
            addMarksToolStripMenuItem1.Name = "addMarksToolStripMenuItem1";
            addMarksToolStripMenuItem1.Size = new Size(180, 22);
            addMarksToolStripMenuItem1.Text = "Add Marks";
            addMarksToolStripMenuItem1.Click += AddMarksToolStripMenuItem_Click;
            // 
            // updateMarksToolStripMenuItem
            // 
            updateMarksToolStripMenuItem.Name = "updateMarksToolStripMenuItem";
            updateMarksToolStripMenuItem.Size = new Size(180, 22);
            updateMarksToolStripMenuItem.Text = "Update Marks";
            updateMarksToolStripMenuItem.Click += UpdateMarksToolStripMenuItem_Click;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "StudentManagementForm";
            Text = "Student Management System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem studentInformationToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem updateStudentToolStripMenuItem;
        private ToolStripMenuItem marksToolStripMenuItem;
        private ToolStripMenuItem addMarksToolStripMenuItem;
        private ToolStripMenuItem addMarksToolStripMenuItem1;
        private ToolStripMenuItem updateMarksToolStripMenuItem;
    }
}
