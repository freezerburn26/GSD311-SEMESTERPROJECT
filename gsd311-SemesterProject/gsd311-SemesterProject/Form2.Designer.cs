namespace gsd311_SemesterProject
{
    partial class Form2
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.TextBox();
            this.txtEligible = new System.Windows.Forms.TextBox();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbStudy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseGrade,
            this.CreditHours,
            this.CourseType});
            this.dgvCourses.Location = new System.Drawing.Point(24, 188);
            this.dgvCourses.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.Size = new System.Drawing.Size(1268, 538);
            this.dgvCourses.TabIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 255;
            // 
            // CourseGrade
            // 
            this.CourseGrade.HeaderText = "CourseGrade";
            this.CourseGrade.Name = "CourseGrade";
            this.CourseGrade.ReadOnly = true;
            // 
            // CreditHours
            // 
            this.CreditHours.HeaderText = "CreditHours";
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.ReadOnly = true;
            // 
            // CourseType
            // 
            this.CourseType.HeaderText = "CourseType";
            this.CourseType.Name = "CourseType";
            this.CourseType.ReadOnly = true;
            // 
            // GPA
            // 
            this.GPA.Location = new System.Drawing.Point(824, 106);
            this.GPA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GPA.Name = "GPA";
            this.GPA.ReadOnly = true;
            this.GPA.Size = new System.Drawing.Size(196, 31);
            this.GPA.TabIndex = 1;
            this.GPA.Text = "GPA";
            // 
            // txtEligible
            // 
            this.txtEligible.Location = new System.Drawing.Point(1086, 106);
            this.txtEligible.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEligible.Name = "txtEligible";
            this.txtEligible.ReadOnly = true;
            this.txtEligible.Size = new System.Drawing.Size(196, 31);
            this.txtEligible.TabIndex = 2;
            this.txtEligible.Text = "Eligible?";
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.Location = new System.Drawing.Point(1348, 106);
            this.txtCreditHours.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.ReadOnly = true;
            this.txtCreditHours.Size = new System.Drawing.Size(196, 31);
            this.txtCreditHours.TabIndex = 3;
            this.txtCreditHours.Text = "Credit Hours";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(1142, 810);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 44);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Ok";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(20, 106);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(196, 31);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(282, 106);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(196, 31);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1074, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Advanced Study Eligible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1342, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Credit Hours";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(980, 810);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbStudy
            // 
            this.cbStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudy.FormattingEnabled = true;
            this.cbStudy.Items.AddRange(new object[] {
            "CompSci",
            "CogSci",
            "MatEng"});
            this.cbStudy.Location = new System.Drawing.Point(544, 104);
            this.cbStudy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbStudy.Name = "cbStudy";
            this.cbStudy.Size = new System.Drawing.Size(214, 33);
            this.cbStudy.TabIndex = 13;
            this.cbStudy.SelectedIndexChanged += new System.EventHandler(this.cbStudy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Advanced Study";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(24, 810);
            this.btnRemoveCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(196, 44);
            this.btnRemoveCourse.TabIndex = 15;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(282, 810);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(196, 44);
            this.btnAddCourse.TabIndex = 16;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 928);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1572, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1572, 950);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStudy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.txtEligible);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.dgvCourses);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TextBox GPA;
        private System.Windows.Forms.TextBox txtEligible;
        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbStudy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}