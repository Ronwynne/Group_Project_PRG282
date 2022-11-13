namespace Project
{
    partial class frmCourses
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
            this.gbcSearchCourse = new System.Windows.Forms.GroupBox();
            this.btnSearchCourses = new System.Windows.Forms.Button();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCourses = new System.Windows.Forms.GroupBox();
            this.btnLastCourse = new System.Windows.Forms.Button();
            this.btnNextCourse = new System.Windows.Forms.Button();
            this.btnPrevCourse = new System.Windows.Forms.Button();
            this.btnFirstCourse = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.gbxCourseData = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.cbxNewCourse = new System.Windows.Forms.CheckBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.lblModCode = new System.Windows.Forms.Label();
            this.gbcSearchCourse.SuspendLayout();
            this.gbxCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.gbxCourseData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcSearchCourse
            // 
            this.gbcSearchCourse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbcSearchCourse.Controls.Add(this.btnSearchCourses);
            this.gbcSearchCourse.Controls.Add(this.txtSearchCourse);
            this.gbcSearchCourse.Controls.Add(this.label1);
            this.gbcSearchCourse.Location = new System.Drawing.Point(15, 13);
            this.gbcSearchCourse.Name = "gbcSearchCourse";
            this.gbcSearchCourse.Size = new System.Drawing.Size(776, 80);
            this.gbcSearchCourse.TabIndex = 0;
            this.gbcSearchCourse.TabStop = false;
            this.gbcSearchCourse.Text = "Search";
            // 
            // btnSearchCourses
            // 
            this.btnSearchCourses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchCourses.Location = new System.Drawing.Point(648, 21);
            this.btnSearchCourses.Name = "btnSearchCourses";
            this.btnSearchCourses.Size = new System.Drawing.Size(113, 38);
            this.btnSearchCourses.TabIndex = 2;
            this.btnSearchCourses.Text = "Search";
            this.btnSearchCourses.UseVisualStyleBackColor = false;
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Location = new System.Drawing.Point(261, 28);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(153, 19);
            this.txtSearchCourse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Course by Module Code";
            // 
            // gbxCourses
            // 
            this.gbxCourses.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxCourses.Controls.Add(this.btnLastCourse);
            this.gbxCourses.Controls.Add(this.btnNextCourse);
            this.gbxCourses.Controls.Add(this.btnPrevCourse);
            this.gbxCourses.Controls.Add(this.btnFirstCourse);
            this.gbxCourses.Controls.Add(this.dgvCourses);
            this.gbxCourses.Location = new System.Drawing.Point(15, 99);
            this.gbxCourses.Name = "gbxCourses";
            this.gbxCourses.Size = new System.Drawing.Size(776, 193);
            this.gbxCourses.TabIndex = 1;
            this.gbxCourses.TabStop = false;
            this.gbxCourses.Text = "Courses";
            // 
            // btnLastCourse
            // 
            this.btnLastCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLastCourse.Location = new System.Drawing.Point(698, 164);
            this.btnLastCourse.Name = "btnLastCourse";
            this.btnLastCourse.Size = new System.Drawing.Size(63, 23);
            this.btnLastCourse.TabIndex = 6;
            this.btnLastCourse.Text = ">>";
            this.btnLastCourse.UseVisualStyleBackColor = false;
            // 
            // btnNextCourse
            // 
            this.btnNextCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNextCourse.Location = new System.Drawing.Point(625, 164);
            this.btnNextCourse.Name = "btnNextCourse";
            this.btnNextCourse.Size = new System.Drawing.Size(57, 23);
            this.btnNextCourse.TabIndex = 5;
            this.btnNextCourse.Text = ">";
            this.btnNextCourse.UseVisualStyleBackColor = false;
            // 
            // btnPrevCourse
            // 
            this.btnPrevCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrevCourse.Location = new System.Drawing.Point(106, 164);
            this.btnPrevCourse.Name = "btnPrevCourse";
            this.btnPrevCourse.Size = new System.Drawing.Size(57, 23);
            this.btnPrevCourse.TabIndex = 4;
            this.btnPrevCourse.Text = "<";
            this.btnPrevCourse.UseVisualStyleBackColor = false;
            // 
            // btnFirstCourse
            // 
            this.btnFirstCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFirstCourse.Location = new System.Drawing.Point(11, 164);
            this.btnFirstCourse.Name = "btnFirstCourse";
            this.btnFirstCourse.Size = new System.Drawing.Size(63, 23);
            this.btnFirstCourse.TabIndex = 3;
            this.btnFirstCourse.Text = "<<";
            this.btnFirstCourse.UseVisualStyleBackColor = false;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(11, 22);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(750, 117);
            this.dgvCourses.TabIndex = 0;
            // 
            // gbxCourseData
            // 
            this.gbxCourseData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxCourseData.Controls.Add(this.btnSaveChanges);
            this.gbxCourseData.Controls.Add(this.btnBack);
            this.gbxCourseData.Controls.Add(this.txtCourseName);
            this.gbxCourseData.Controls.Add(this.txtLink);
            this.gbxCourseData.Controls.Add(this.lblDescription);
            this.gbxCourseData.Controls.Add(this.lblCourseName);
            this.gbxCourseData.Controls.Add(this.lblLink);
            this.gbxCourseData.Controls.Add(this.btnDeleteCourse);
            this.gbxCourseData.Controls.Add(this.cbxNewCourse);
            this.gbxCourseData.Controls.Add(this.rtbDesc);
            this.gbxCourseData.Controls.Add(this.txtModCode);
            this.gbxCourseData.Controls.Add(this.lblModCode);
            this.gbxCourseData.Location = new System.Drawing.Point(15, 298);
            this.gbxCourseData.Name = "gbxCourseData";
            this.gbxCourseData.Size = new System.Drawing.Size(776, 233);
            this.gbxCourseData.TabIndex = 2;
            this.gbxCourseData.TabStop = false;
            this.gbxCourseData.Text = "Course Data";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveChanges.Location = new System.Drawing.Point(299, 187);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(126, 40);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(580, 187);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back To Main";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(14, 97);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(303, 19);
            this.txtCourseName.TabIndex = 9;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(14, 159);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(303, 19);
            this.txtLink.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(410, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(11, 78);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(82, 13);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(11, 136);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(31, 13);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Link";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteCourse.Location = new System.Drawing.Point(14, 187);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            // 
            // cbxNewCourse
            // 
            this.cbxNewCourse.AutoSize = true;
            this.cbxNewCourse.Location = new System.Drawing.Point(625, 18);
            this.cbxNewCourse.Name = "cbxNewCourse";
            this.cbxNewCourse.Size = new System.Drawing.Size(120, 17);
            this.cbxNewCourse.TabIndex = 3;
            this.cbxNewCourse.Text = "Add New Course";
            this.cbxNewCourse.UseVisualStyleBackColor = true;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(413, 66);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(348, 115);
            this.rtbDesc.TabIndex = 2;
            this.rtbDesc.Text = "";
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(14, 41);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(303, 19);
            this.txtModCode.TabIndex = 1;
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(11, 22);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(81, 13);
            this.lblModCode.TabIndex = 0;
            this.lblModCode.Text = "Module Code";
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(803, 543);
            this.Controls.Add(this.gbxCourseData);
            this.Controls.Add(this.gbxCourses);
            this.Controls.Add(this.gbcSearchCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.gbcSearchCourse.ResumeLayout(false);
            this.gbcSearchCourse.PerformLayout();
            this.gbxCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.gbxCourseData.ResumeLayout(false);
            this.gbxCourseData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcSearchCourse;
        private System.Windows.Forms.GroupBox gbxCourses;
        private System.Windows.Forms.GroupBox gbxCourseData;
        private System.Windows.Forms.Button btnSearchCourses;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnLastCourse;
        private System.Windows.Forms.Button btnNextCourse;
        private System.Windows.Forms.Button btnPrevCourse;
        private System.Windows.Forms.Button btnFirstCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.CheckBox cbxNewCourse;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblLink;
    }
}