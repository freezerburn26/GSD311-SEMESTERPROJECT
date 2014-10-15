namespace gsd311_SemesterProject
{
    partial class addCourseForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCourseName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(408, 230);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbCourseName
            // 
            this.cbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseName.FormattingEnabled = true;
            this.cbCourseName.Location = new System.Drawing.Point(13, 65);
            this.cbCourseName.Name = "cbCourseName";
            this.cbCourseName.Size = new System.Drawing.Size(216, 21);
            this.cbCourseName.TabIndex = 2;
            this.cbCourseName.SelectedIndexChanged += new System.EventHandler(this.cbCourseName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Course";
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(284, 65);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.ReadOnly = true;
            this.txtCourseType.Size = new System.Drawing.Size(90, 20);
            this.txtCourseType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course Type";
            // 
            // txtCreditHours
            // 
            this.txtCreditHours.Location = new System.Drawing.Point(396, 65);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.ReadOnly = true;
            this.txtCreditHours.Size = new System.Drawing.Size(62, 20);
            this.txtCreditHours.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Credit Hours";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(16, 146);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(83, 20);
            this.txtGrade.TabIndex = 8;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Achieved Grade";
            // 
            // addCourseForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(495, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCourseName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "addCourseForm";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.addCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label4;
    }
}