﻿namespace Project
{
    partial class frmMain
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
            this.gbxViewStudentData = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.gbxStudentData = new System.Windows.Forms.GroupBox();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.cbxNewStudent = new System.Windows.Forms.CheckBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lbxModCode = new System.Windows.Forms.ComboBox();
            this.lbxGender = new System.Windows.Forms.ComboBox();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblModCode = new System.Windows.Forms.Label();
            this.lblImgPath = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnDeleteCourseForStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.gbxStudentCourses = new System.Windows.Forms.GroupBox();
            this.btnNextStudentCourse = new System.Windows.Forms.Button();
            this.btnLastStudentCourse = new System.Windows.Forms.Button();
            this.btnPrevStudentCourse = new System.Windows.Forms.Button();
            this.btnFirstStudentCourse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvStudentCourses = new System.Windows.Forms.DataGridView();
            this.gbxViewStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.gbxStudentData.SuspendLayout();
            this.gbxControl.SuspendLayout();
            this.gbxStudentCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxViewStudentData
            // 
            this.gbxViewStudentData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxViewStudentData.Controls.Add(this.btnLast);
            this.gbxViewStudentData.Controls.Add(this.btnPrev);
            this.gbxViewStudentData.Controls.Add(this.btnNext);
            this.gbxViewStudentData.Controls.Add(this.btnFirst);
            this.gbxViewStudentData.Controls.Add(this.dgvStudents);
            this.gbxViewStudentData.Controls.Add(this.txtSearchStudent);
            this.gbxViewStudentData.Controls.Add(this.lblSearchStudent);
            this.gbxViewStudentData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxViewStudentData.Location = new System.Drawing.Point(15, 13);
            this.gbxViewStudentData.Name = "gbxViewStudentData";
            this.gbxViewStudentData.Size = new System.Drawing.Size(973, 350);
            this.gbxViewStudentData.TabIndex = 0;
            this.gbxViewStudentData.TabStop = false;
            this.gbxViewStudentData.Text = "View Student Data";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.Location = new System.Drawing.Point(800, 309);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(112, 35);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrev.Location = new System.Drawing.Point(199, 309);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 35);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(690, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 35);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirst.Location = new System.Drawing.Point(55, 309);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 35);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(13, 51);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(924, 252);
            this.dgvStudents.TabIndex = 2;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(735, 19);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(202, 19);
            this.txtSearchStudent.TabIndex = 1;
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(458, 22);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(201, 13);
            this.lblSearchStudent.TabIndex = 0;
            this.lblSearchStudent.Text = "Search student by student number";
            // 
            // gbxStudentData
            // 
            this.gbxStudentData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxStudentData.Controls.Add(this.btnSaveStudent);
            this.gbxStudentData.Controls.Add(this.cbxNewStudent);
            this.gbxStudentData.Controls.Add(this.dtpDOB);
            this.gbxStudentData.Controls.Add(this.lbxModCode);
            this.gbxStudentData.Controls.Add(this.lbxGender);
            this.gbxStudentData.Controls.Add(this.txtImgPath);
            this.gbxStudentData.Controls.Add(this.txtHomeAddress);
            this.gbxStudentData.Controls.Add(this.txtPhone);
            this.gbxStudentData.Controls.Add(this.txtNameSurname);
            this.gbxStudentData.Controls.Add(this.lblGender);
            this.gbxStudentData.Controls.Add(this.lblDOB);
            this.gbxStudentData.Controls.Add(this.lblPhone);
            this.gbxStudentData.Controls.Add(this.lblHomeAddress);
            this.gbxStudentData.Controls.Add(this.lblModCode);
            this.gbxStudentData.Controls.Add(this.lblImgPath);
            this.gbxStudentData.Controls.Add(this.lblNameSurname);
            this.gbxStudentData.Location = new System.Drawing.Point(1008, 13);
            this.gbxStudentData.Name = "gbxStudentData";
            this.gbxStudentData.Size = new System.Drawing.Size(280, 638);
            this.gbxStudentData.TabIndex = 1;
            this.gbxStudentData.TabStop = false;
            this.gbxStudentData.Text = "StudentData";
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveStudent.Location = new System.Drawing.Point(32, 558);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(216, 43);
            this.btnSaveStudent.TabIndex = 15;
            this.btnSaveStudent.Text = "Save Changes";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            // 
            // cbxNewStudent
            // 
            this.cbxNewStudent.AutoSize = true;
            this.cbxNewStudent.Location = new System.Drawing.Point(133, 21);
            this.cbxNewStudent.Name = "cbxNewStudent";
            this.cbxNewStudent.Size = new System.Drawing.Size(99, 17);
            this.cbxNewStudent.TabIndex = 14;
            this.cbxNewStudent.Text = "New Student";
            this.cbxNewStudent.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(32, 237);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(216, 19);
            this.dtpDOB.TabIndex = 13;
            // 
            // lbxModCode
            // 
            this.lbxModCode.FormattingEnabled = true;
            this.lbxModCode.Location = new System.Drawing.Point(32, 439);
            this.lbxModCode.Name = "lbxModCode";
            this.lbxModCode.Size = new System.Drawing.Size(216, 21);
            this.lbxModCode.TabIndex = 12;
            // 
            // lbxGender
            // 
            this.lbxGender.FormattingEnabled = true;
            this.lbxGender.Location = new System.Drawing.Point(32, 157);
            this.lbxGender.Name = "lbxGender";
            this.lbxGender.Size = new System.Drawing.Size(216, 21);
            this.lbxGender.TabIndex = 11;
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(32, 506);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(216, 19);
            this.txtImgPath.TabIndex = 10;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(32, 370);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(216, 19);
            this.txtHomeAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(32, 307);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 19);
            this.txtPhone.TabIndex = 8;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(32, 92);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(216, 19);
            this.txtNameSurname.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(103, 129);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(86, 198);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(78, 13);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(82, 274);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(81, 341);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(88, 13);
            this.lblHomeAddress.TabIndex = 3;
            this.lblHomeAddress.Text = "Home Address";
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(92, 414);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(81, 13);
            this.lblModCode.TabIndex = 2;
            this.lblModCode.Text = "Module Code";
            // 
            // lblImgPath
            // 
            this.lblImgPath.AutoSize = true;
            this.lblImgPath.Location = new System.Drawing.Point(92, 479);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(71, 13);
            this.lblImgPath.TabIndex = 1;
            this.lblImgPath.Text = "Image Path";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(58, 63);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(117, 13);
            this.lblNameSurname.TabIndex = 0;
            this.lblNameSurname.Text = "Name and Surname";
            // 
            // gbxControl
            // 
            this.gbxControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxControl.Controls.Add(this.btnDeleteCourseForStudent);
            this.gbxControl.Controls.Add(this.btnExit);
            this.gbxControl.Controls.Add(this.btnCourses);
            this.gbxControl.Controls.Add(this.btnDeleteStudent);
            this.gbxControl.Location = new System.Drawing.Point(564, 385);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(424, 266);
            this.gbxControl.TabIndex = 2;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Control Box";
            // 
            // btnDeleteCourseForStudent
            // 
            this.btnDeleteCourseForStudent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteCourseForStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteCourseForStudent.Location = new System.Drawing.Point(30, 159);
            this.btnDeleteCourseForStudent.Name = "btnDeleteCourseForStudent";
            this.btnDeleteCourseForStudent.Size = new System.Drawing.Size(170, 49);
            this.btnDeleteCourseForStudent.TabIndex = 3;
            this.btnDeleteCourseForStudent.Text = "Delete Course fir Student";
            this.btnDeleteCourseForStudent.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(248, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCourses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCourses.Location = new System.Drawing.Point(248, 44);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(170, 49);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteStudent.Location = new System.Drawing.Point(30, 44);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(170, 49);
            this.btnDeleteStudent.TabIndex = 0;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            // 
            // gbxStudentCourses
            // 
            this.gbxStudentCourses.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxStudentCourses.Controls.Add(this.btnNextStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.btnLastStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.btnPrevStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.btnFirstStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.button1);
            this.gbxStudentCourses.Controls.Add(this.button2);
            this.gbxStudentCourses.Controls.Add(this.button3);
            this.gbxStudentCourses.Controls.Add(this.button4);
            this.gbxStudentCourses.Controls.Add(this.dgvStudentCourses);
            this.gbxStudentCourses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxStudentCourses.Location = new System.Drawing.Point(15, 383);
            this.gbxStudentCourses.Name = "gbxStudentCourses";
            this.gbxStudentCourses.Size = new System.Drawing.Size(515, 268);
            this.gbxStudentCourses.TabIndex = 7;
            this.gbxStudentCourses.TabStop = false;
            this.gbxStudentCourses.Text = "Courses by Student";
            // 
            // btnNextStudentCourse
            // 
            this.btnNextStudentCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNextStudentCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNextStudentCourse.Location = new System.Drawing.Point(395, 216);
            this.btnNextStudentCourse.Name = "btnNextStudentCourse";
            this.btnNextStudentCourse.Size = new System.Drawing.Size(45, 35);
            this.btnNextStudentCourse.TabIndex = 7;
            this.btnNextStudentCourse.Text = ">";
            this.btnNextStudentCourse.UseVisualStyleBackColor = false;
            // 
            // btnLastStudentCourse
            // 
            this.btnLastStudentCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLastStudentCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLastStudentCourse.Location = new System.Drawing.Point(446, 216);
            this.btnLastStudentCourse.Name = "btnLastStudentCourse";
            this.btnLastStudentCourse.Size = new System.Drawing.Size(53, 35);
            this.btnLastStudentCourse.TabIndex = 7;
            this.btnLastStudentCourse.Text = ">>";
            this.btnLastStudentCourse.UseVisualStyleBackColor = false;
            // 
            // btnPrevStudentCourse
            // 
            this.btnPrevStudentCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrevStudentCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevStudentCourse.Location = new System.Drawing.Point(72, 216);
            this.btnPrevStudentCourse.Name = "btnPrevStudentCourse";
            this.btnPrevStudentCourse.Size = new System.Drawing.Size(51, 35);
            this.btnPrevStudentCourse.TabIndex = 7;
            this.btnPrevStudentCourse.Text = "<";
            this.btnPrevStudentCourse.UseVisualStyleBackColor = false;
            // 
            // btnFirstStudentCourse
            // 
            this.btnFirstStudentCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFirstStudentCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirstStudentCourse.Location = new System.Drawing.Point(6, 216);
            this.btnFirstStudentCourse.Name = "btnFirstStudentCourse";
            this.btnFirstStudentCourse.Size = new System.Drawing.Size(60, 35);
            this.btnFirstStudentCourse.TabIndex = 7;
            this.btnFirstStudentCourse.Text = "<<";
            this.btnFirstStudentCourse.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(800, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(660, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(199, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(55, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dgvStudentCourses
            // 
            this.dgvStudentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentCourses.Location = new System.Drawing.Point(6, 22);
            this.dgvStudentCourses.Name = "dgvStudentCourses";
            this.dgvStudentCourses.RowHeadersWidth = 51;
            this.dgvStudentCourses.RowTemplate.Height = 24;
            this.dgvStudentCourses.Size = new System.Drawing.Size(493, 188);
            this.dgvStudentCourses.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1304, 664);
            this.Controls.Add(this.gbxStudentCourses);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.gbxStudentData);
            this.Controls.Add(this.gbxViewStudentData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Main";
            this.gbxViewStudentData.ResumeLayout(false);
            this.gbxViewStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.gbxStudentData.ResumeLayout(false);
            this.gbxStudentData.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            this.gbxStudentCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxViewStudentData;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox gbxStudentData;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Label lblImgPath;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox lbxModCode;
        private System.Windows.Forms.ComboBox lbxGender;
        private System.Windows.Forms.CheckBox cbxNewStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnDeleteCourseForStudent;
        private System.Windows.Forms.GroupBox gbxStudentCourses;
        private System.Windows.Forms.Button btnNextStudentCourse;
        private System.Windows.Forms.Button btnLastStudentCourse;
        private System.Windows.Forms.Button btnPrevStudentCourse;
        private System.Windows.Forms.Button btnFirstStudentCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvStudentCourses;
    }
}