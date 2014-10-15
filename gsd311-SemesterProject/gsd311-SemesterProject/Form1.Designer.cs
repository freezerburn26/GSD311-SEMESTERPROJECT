namespace gsd311_SemesterProject
{
    partial class Form1
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvancedStudy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EligibleForStudy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentGPA,
            this.AdvancedStudy,
            this.StudentID,
            this.EligibleForStudy});
            this.dgvStudents.Location = new System.Drawing.Point(12, 71);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(566, 304);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentGPA
            // 
            this.StudentGPA.HeaderText = "Student GPA";
            this.StudentGPA.Name = "StudentGPA";
            this.StudentGPA.ReadOnly = true;
            // 
            // AdvancedStudy
            // 
            this.AdvancedStudy.HeaderText = "Advanced Study";
            this.AdvancedStudy.Name = "AdvancedStudy";
            this.AdvancedStudy.ReadOnly = true;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // EligibleForStudy
            // 
            this.EligibleForStudy.HeaderText = "Eligible for Advanced Study";
            this.EligibleForStudy.Name = "EligibleForStudy";
            this.EligibleForStudy.ReadOnly = true;
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(680, 84);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(112, 23);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "Edit/View Student";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(680, 122);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(112, 23);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 463);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnViewStudent);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvancedStudy;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EligibleForStudy;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;

    }
}

