namespace Project
{
    partial class frmStudents
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblImgPath = new System.Windows.Forms.Label();
            this.lblModCode = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.lbxGender = new System.Windows.Forms.ComboBox();
            this.lbxModCode = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.gbxStudentData = new System.Windows.Forms.GroupBox();
            this.lblStudetnNo = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsertNew = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pbxStudentImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dgvStudentCourses = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFirstStudentCourse = new System.Windows.Forms.Button();
            this.btnPrevStudentCourse = new System.Windows.Forms.Button();
            this.btnLastStudentCourse = new System.Windows.Forms.Button();
            this.btnNextStudentCourse = new System.Windows.Forms.Button();
            this.gbxStudentCourses = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.btnRemoveStudentModule = new System.Windows.Forms.Button();
            this.btnAddStudentModule = new System.Windows.Forms.Button();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.gbxViewStudentData = new System.Windows.Forms.GroupBox();
            this.ofdStudentPic = new System.Windows.Forms.OpenFileDialog();
            this.gbxStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourses)).BeginInit();
            this.gbxStudentCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.gbxViewStudentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Firstname";
            // 
            // lblImgPath
            // 
            this.lblImgPath.AutoSize = true;
            this.lblImgPath.Location = new System.Drawing.Point(192, 51);
            this.lblImgPath.Name = "lblImgPath";
            this.lblImgPath.Size = new System.Drawing.Size(41, 13);
            this.lblImgPath.TabIndex = 1;
            this.lblImgPath.Text = "Image";
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(409, 22);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(81, 13);
            this.lblModCode.TabIndex = 2;
            this.lblModCode.Text = "Module Code";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(31, 386);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(88, 13);
            this.lblHomeAddress.TabIndex = 3;
            this.lblHomeAddress.Text = "Home Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(29, 329);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(29, 268);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(78, 13);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(31, 210);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(31, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 19);
            this.txtName.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(32, 345);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(302, 19);
            this.txtPhone.TabIndex = 8;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(34, 402);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(300, 19);
            this.txtHomeAddress.TabIndex = 9;
            // 
            // lbxGender
            // 
            this.lbxGender.FormattingEnabled = true;
            this.lbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-binary"});
            this.lbxGender.Location = new System.Drawing.Point(31, 226);
            this.lbxGender.Name = "lbxGender";
            this.lbxGender.Size = new System.Drawing.Size(141, 21);
            this.lbxGender.TabIndex = 11;
            // 
            // lbxModCode
            // 
            this.lbxModCode.FormattingEnabled = true;
            this.lbxModCode.Location = new System.Drawing.Point(412, 38);
            this.lbxModCode.Name = "lbxModCode";
            this.lbxModCode.Size = new System.Drawing.Size(136, 21);
            this.lbxModCode.TabIndex = 12;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(32, 284);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(302, 19);
            this.dtpDOB.TabIndex = 13;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStudent.Location = new System.Drawing.Point(34, 504);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(145, 43);
            this.btnSaveStudent.TabIndex = 15;
            this.btnSaveStudent.Text = "Save Changes";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // gbxStudentData
            // 
            this.gbxStudentData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.gbxStudentData.Controls.Add(this.lblStudetnNo);
            this.gbxStudentData.Controls.Add(this.txtStudentNo);
            this.gbxStudentData.Controls.Add(this.btnRemove);
            this.gbxStudentData.Controls.Add(this.btnInsertNew);
            this.gbxStudentData.Controls.Add(this.btnSelect);
            this.gbxStudentData.Controls.Add(this.pbxStudentImage);
            this.gbxStudentData.Controls.Add(this.label1);
            this.gbxStudentData.Controls.Add(this.txtSurname);
            this.gbxStudentData.Controls.Add(this.btnSaveStudent);
            this.gbxStudentData.Controls.Add(this.dtpDOB);
            this.gbxStudentData.Controls.Add(this.lbxGender);
            this.gbxStudentData.Controls.Add(this.txtHomeAddress);
            this.gbxStudentData.Controls.Add(this.txtPhone);
            this.gbxStudentData.Controls.Add(this.txtName);
            this.gbxStudentData.Controls.Add(this.lblGender);
            this.gbxStudentData.Controls.Add(this.lblDOB);
            this.gbxStudentData.Controls.Add(this.lblPhone);
            this.gbxStudentData.Controls.Add(this.lblHomeAddress);
            this.gbxStudentData.Controls.Add(this.lblImgPath);
            this.gbxStudentData.Controls.Add(this.lblName);
            this.gbxStudentData.ForeColor = System.Drawing.Color.White;
            this.gbxStudentData.Location = new System.Drawing.Point(887, 13);
            this.gbxStudentData.Name = "gbxStudentData";
            this.gbxStudentData.Size = new System.Drawing.Size(365, 638);
            this.gbxStudentData.TabIndex = 1;
            this.gbxStudentData.TabStop = false;
            this.gbxStudentData.Text = "StudentData";
            // 
            // lblStudetnNo
            // 
            this.lblStudetnNo.AutoSize = true;
            this.lblStudetnNo.Location = new System.Drawing.Point(31, 51);
            this.lblStudetnNo.Name = "lblStudetnNo";
            this.lblStudetnNo.Size = new System.Drawing.Size(67, 13);
            this.lblStudetnNo.TabIndex = 23;
            this.lblStudetnNo.Text = "StudentNo";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(31, 67);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(141, 19);
            this.txtStudentNo.TabIndex = 22;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(188, 504);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(146, 43);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove Student";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsertNew
            // 
            this.btnInsertNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnInsertNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertNew.Location = new System.Drawing.Point(34, 565);
            this.btnInsertNew.Name = "btnInsertNew";
            this.btnInsertNew.Size = new System.Drawing.Size(300, 43);
            this.btnInsertNew.TabIndex = 20;
            this.btnInsertNew.Text = "Insert new student";
            this.btnInsertNew.UseVisualStyleBackColor = false;
            this.btnInsertNew.Click += new System.EventHandler(this.btnInsertNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(213, 216);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(97, 31);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Select image";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pbxStudentImage
            // 
            this.pbxStudentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxStudentImage.Location = new System.Drawing.Point(188, 67);
            this.pbxStudentImage.Name = "pbxStudentImage";
            this.pbxStudentImage.Size = new System.Drawing.Size(146, 143);
            this.pbxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudentImage.TabIndex = 18;
            this.pbxStudentImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(31, 166);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 19);
            this.txtSurname.TabIndex = 16;
            // 
            // dgvStudentCourses
            // 
            this.dgvStudentCourses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStudentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentCourses.Location = new System.Drawing.Point(18, 22);
            this.dgvStudentCourses.Name = "dgvStudentCourses";
            this.dgvStudentCourses.ReadOnly = true;
            this.dgvStudentCourses.RowHeadersWidth = 51;
            this.dgvStudentCourses.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStudentCourses.RowTemplate.Height = 24;
            this.dgvStudentCourses.Size = new System.Drawing.Size(372, 188);
            this.dgvStudentCourses.TabIndex = 2;
            this.dgvStudentCourses.SelectionChanged += new System.EventHandler(this.dgvStudentCourses_SelectionChanged);
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
            // btnFirstStudentCourse
            // 
            this.btnFirstStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnFirstStudentCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstStudentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstStudentCourse.ForeColor = System.Drawing.Color.White;
            this.btnFirstStudentCourse.Location = new System.Drawing.Point(18, 216);
            this.btnFirstStudentCourse.Name = "btnFirstStudentCourse";
            this.btnFirstStudentCourse.Size = new System.Drawing.Size(55, 35);
            this.btnFirstStudentCourse.TabIndex = 7;
            this.btnFirstStudentCourse.Text = "<<";
            this.btnFirstStudentCourse.UseVisualStyleBackColor = false;
            this.btnFirstStudentCourse.Click += new System.EventHandler(this.btnFirstStudentCourse_Click);
            // 
            // btnPrevStudentCourse
            // 
            this.btnPrevStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnPrevStudentCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevStudentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevStudentCourse.ForeColor = System.Drawing.Color.White;
            this.btnPrevStudentCourse.Location = new System.Drawing.Point(79, 216);
            this.btnPrevStudentCourse.Name = "btnPrevStudentCourse";
            this.btnPrevStudentCourse.Size = new System.Drawing.Size(51, 35);
            this.btnPrevStudentCourse.TabIndex = 7;
            this.btnPrevStudentCourse.Text = "<";
            this.btnPrevStudentCourse.UseVisualStyleBackColor = false;
            this.btnPrevStudentCourse.Click += new System.EventHandler(this.btnPrevStudentCourse_Click);
            // 
            // btnLastStudentCourse
            // 
            this.btnLastStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLastStudentCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastStudentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastStudentCourse.ForeColor = System.Drawing.Color.White;
            this.btnLastStudentCourse.Location = new System.Drawing.Point(337, 216);
            this.btnLastStudentCourse.Name = "btnLastStudentCourse";
            this.btnLastStudentCourse.Size = new System.Drawing.Size(53, 35);
            this.btnLastStudentCourse.TabIndex = 7;
            this.btnLastStudentCourse.Text = ">>";
            this.btnLastStudentCourse.UseVisualStyleBackColor = false;
            this.btnLastStudentCourse.Click += new System.EventHandler(this.btnLastStudentCourse_Click);
            // 
            // btnNextStudentCourse
            // 
            this.btnNextStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnNextStudentCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextStudentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStudentCourse.ForeColor = System.Drawing.Color.White;
            this.btnNextStudentCourse.Location = new System.Drawing.Point(286, 216);
            this.btnNextStudentCourse.Name = "btnNextStudentCourse";
            this.btnNextStudentCourse.Size = new System.Drawing.Size(45, 35);
            this.btnNextStudentCourse.TabIndex = 7;
            this.btnNextStudentCourse.Text = ">";
            this.btnNextStudentCourse.UseVisualStyleBackColor = false;
            this.btnNextStudentCourse.Click += new System.EventHandler(this.btnNextStudentCourse_Click);
            // 
            // gbxStudentCourses
            // 
            this.gbxStudentCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.gbxStudentCourses.Controls.Add(this.btnExit);
            this.gbxStudentCourses.Controls.Add(this.btnManageCourses);
            this.gbxStudentCourses.Controls.Add(this.btnRemoveStudentModule);
            this.gbxStudentCourses.Controls.Add(this.btnAddStudentModule);
            this.gbxStudentCourses.Controls.Add(this.btnNextStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.btnLastStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.btnPrevStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.btnFirstStudentCourse);
            this.gbxStudentCourses.Controls.Add(this.button1);
            this.gbxStudentCourses.Controls.Add(this.button2);
            this.gbxStudentCourses.Controls.Add(this.button3);
            this.gbxStudentCourses.Controls.Add(this.button4);
            this.gbxStudentCourses.Controls.Add(this.lbxModCode);
            this.gbxStudentCourses.Controls.Add(this.dgvStudentCourses);
            this.gbxStudentCourses.Controls.Add(this.lblModCode);
            this.gbxStudentCourses.ForeColor = System.Drawing.Color.White;
            this.gbxStudentCourses.Location = new System.Drawing.Point(15, 384);
            this.gbxStudentCourses.Name = "gbxStudentCourses";
            this.gbxStudentCourses.Size = new System.Drawing.Size(853, 268);
            this.gbxStudentCourses.TabIndex = 7;
            this.gbxStudentCourses.TabStop = false;
            this.gbxStudentCourses.Text = "Courses by Student";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(636, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnManageCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCourses.ForeColor = System.Drawing.Color.White;
            this.btnManageCourses.Location = new System.Drawing.Point(636, 71);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(152, 38);
            this.btnManageCourses.TabIndex = 13;
            this.btnManageCourses.Text = "Manage All Courses";
            this.btnManageCourses.UseVisualStyleBackColor = false;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // btnRemoveStudentModule
            // 
            this.btnRemoveStudentModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemoveStudentModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStudentModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudentModule.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStudentModule.Location = new System.Drawing.Point(412, 115);
            this.btnRemoveStudentModule.Name = "btnRemoveStudentModule";
            this.btnRemoveStudentModule.Size = new System.Drawing.Size(136, 35);
            this.btnRemoveStudentModule.TabIndex = 9;
            this.btnRemoveStudentModule.Text = "Remove Module";
            this.btnRemoveStudentModule.UseVisualStyleBackColor = false;
            this.btnRemoveStudentModule.Click += new System.EventHandler(this.btnRemoveStudentModule_Click);
            // 
            // btnAddStudentModule
            // 
            this.btnAddStudentModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnAddStudentModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudentModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentModule.ForeColor = System.Drawing.Color.White;
            this.btnAddStudentModule.Location = new System.Drawing.Point(412, 74);
            this.btnAddStudentModule.Name = "btnAddStudentModule";
            this.btnAddStudentModule.Size = new System.Drawing.Size(136, 35);
            this.btnAddStudentModule.TabIndex = 8;
            this.btnAddStudentModule.Text = "Add Module";
            this.btnAddStudentModule.UseVisualStyleBackColor = false;
            this.btnAddStudentModule.Click += new System.EventHandler(this.btnAddStudentModule_Click);
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(52, 25);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(201, 13);
            this.lblSearchStudent.TabIndex = 0;
            this.lblSearchStudent.Text = "Search student by student number";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(268, 22);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(202, 19);
            this.txtSearchStudent.TabIndex = 1;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvStudents.Location = new System.Drawing.Point(26, 51);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(762, 252);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(55, 307);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 35);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(509, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 35);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(184, 307);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 35);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(612, 307);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(112, 35);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // gbxViewStudentData
            // 
            this.gbxViewStudentData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.gbxViewStudentData.Controls.Add(this.btnLast);
            this.gbxViewStudentData.Controls.Add(this.btnPrev);
            this.gbxViewStudentData.Controls.Add(this.btnNext);
            this.gbxViewStudentData.Controls.Add(this.btnFirst);
            this.gbxViewStudentData.Controls.Add(this.dgvStudents);
            this.gbxViewStudentData.Controls.Add(this.txtSearchStudent);
            this.gbxViewStudentData.Controls.Add(this.lblSearchStudent);
            this.gbxViewStudentData.ForeColor = System.Drawing.Color.White;
            this.gbxViewStudentData.Location = new System.Drawing.Point(15, 13);
            this.gbxViewStudentData.Name = "gbxViewStudentData";
            this.gbxViewStudentData.Size = new System.Drawing.Size(853, 350);
            this.gbxViewStudentData.TabIndex = 0;
            this.gbxViewStudentData.TabStop = false;
            this.gbxViewStudentData.Text = "View Student Data";
            // 
            // ofdStudentPic
            // 
            this.ofdStudentPic.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...\"";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1267, 664);
            this.Controls.Add(this.gbxStudentCourses);
            this.Controls.Add(this.gbxStudentData);
            this.Controls.Add(this.gbxViewStudentData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxStudentData.ResumeLayout(false);
            this.gbxStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourses)).EndInit();
            this.gbxStudentCourses.ResumeLayout(false);
            this.gbxStudentCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.gbxViewStudentData.ResumeLayout(false);
            this.gbxViewStudentData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblImgPath;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.ComboBox lbxGender;
        private System.Windows.Forms.ComboBox lbxModCode;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.GroupBox gbxStudentData;
        private System.Windows.Forms.DataGridView dgvStudentCourses;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFirstStudentCourse;
        private System.Windows.Forms.Button btnPrevStudentCourse;
        private System.Windows.Forms.Button btnLastStudentCourse;
        private System.Windows.Forms.Button btnNextStudentCourse;
        private System.Windows.Forms.GroupBox gbxStudentCourses;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox gbxViewStudentData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pbxStudentImage;
        private System.Windows.Forms.Button btnInsertNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog ofdStudentPic;
        private System.Windows.Forms.Label lblStudetnNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Button btnRemoveStudentModule;
        private System.Windows.Forms.Button btnAddStudentModule;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManageCourses;
    }
}