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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbcSearchCourse = new System.Windows.Forms.GroupBox();
            this.btnInsertCourse = new System.Windows.Forms.Button();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnLastCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNextCourse = new System.Windows.Forms.Button();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.btnPrevCourse = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnFirstCourse = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModCode = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.gbxCourseData = new System.Windows.Forms.GroupBox();
            this.btnResourceLast = new System.Windows.Forms.Button();
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.btnResourceNext = new System.Windows.Forms.Button();
            this.btnResourcePrev = new System.Windows.Forms.Button();
            this.btnSaveResource = new System.Windows.Forms.Button();
            this.btnResourceFirst = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.gbcSearchCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.gbxCourseData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcSearchCourse
            // 
            this.gbcSearchCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.gbcSearchCourse.Controls.Add(this.btnInsertCourse);
            this.gbcSearchCourse.Controls.Add(this.txtModCode);
            this.gbcSearchCourse.Controls.Add(this.btnSaveChanges);
            this.gbcSearchCourse.Controls.Add(this.btnLastCourse);
            this.gbcSearchCourse.Controls.Add(this.btnDeleteCourse);
            this.gbcSearchCourse.Controls.Add(this.btnBack);
            this.gbcSearchCourse.Controls.Add(this.btnNextCourse);
            this.gbcSearchCourse.Controls.Add(this.txtSearchCourse);
            this.gbcSearchCourse.Controls.Add(this.btnPrevCourse);
            this.gbcSearchCourse.Controls.Add(this.txtCourseName);
            this.gbcSearchCourse.Controls.Add(this.btnFirstCourse);
            this.gbcSearchCourse.Controls.Add(this.lblDescription);
            this.gbcSearchCourse.Controls.Add(this.dgvCourses);
            this.gbcSearchCourse.Controls.Add(this.label1);
            this.gbcSearchCourse.Controls.Add(this.lblModCode);
            this.gbcSearchCourse.Controls.Add(this.rtbDesc);
            this.gbcSearchCourse.Controls.Add(this.lblCourseName);
            this.gbcSearchCourse.ForeColor = System.Drawing.Color.White;
            this.gbcSearchCourse.Location = new System.Drawing.Point(15, 13);
            this.gbcSearchCourse.Name = "gbcSearchCourse";
            this.gbcSearchCourse.Size = new System.Drawing.Size(1148, 382);
            this.gbcSearchCourse.TabIndex = 0;
            this.gbcSearchCourse.TabStop = false;
            this.gbcSearchCourse.Text = "Course Data";
            // 
            // btnInsertCourse
            // 
            this.btnInsertCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnInsertCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCourse.Location = new System.Drawing.Point(783, 312);
            this.btnInsertCourse.Name = "btnInsertCourse";
            this.btnInsertCourse.Size = new System.Drawing.Size(267, 40);
            this.btnInsertCourse.TabIndex = 21;
            this.btnInsertCourse.Text = "Insert Course";
            this.btnInsertCourse.UseVisualStyleBackColor = false;
            this.btnInsertCourse.Click += new System.EventHandler(this.btnInsertCourse_Click);
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(718, 87);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(419, 19);
            this.txtModCode.TabIndex = 20;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Location = new System.Drawing.Point(783, 266);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(126, 40);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnLastCourse
            // 
            this.btnLastCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLastCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastCourse.Location = new System.Drawing.Point(543, 329);
            this.btnLastCourse.Name = "btnLastCourse";
            this.btnLastCourse.Size = new System.Drawing.Size(63, 40);
            this.btnLastCourse.TabIndex = 6;
            this.btnLastCourse.Text = ">>";
            this.btnLastCourse.UseVisualStyleBackColor = false;
            this.btnLastCourse.Click += new System.EventHandler(this.btnLastCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Location = new System.Drawing.Point(924, 266);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Remove Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(1001, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back To Main";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNextCourse
            // 
            this.btnNextCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnNextCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCourse.Location = new System.Drawing.Point(448, 330);
            this.btnNextCourse.Name = "btnNextCourse";
            this.btnNextCourse.Size = new System.Drawing.Size(57, 40);
            this.btnNextCourse.TabIndex = 5;
            this.btnNextCourse.Text = ">";
            this.btnNextCourse.UseVisualStyleBackColor = false;
            this.btnNextCourse.Click += new System.EventHandler(this.btnNextCourse_Click);
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Location = new System.Drawing.Point(199, 28);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(153, 19);
            this.txtSearchCourse.TabIndex = 1;
            this.txtSearchCourse.TextChanged += new System.EventHandler(this.txtSearchCourse_TextChanged);
            // 
            // btnPrevCourse
            // 
            this.btnPrevCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnPrevCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevCourse.Location = new System.Drawing.Point(122, 330);
            this.btnPrevCourse.Name = "btnPrevCourse";
            this.btnPrevCourse.Size = new System.Drawing.Size(57, 40);
            this.btnPrevCourse.TabIndex = 4;
            this.btnPrevCourse.Text = "<";
            this.btnPrevCourse.UseVisualStyleBackColor = false;
            this.btnPrevCourse.Click += new System.EventHandler(this.btnPrevCourse_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(718, 138);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(419, 19);
            this.txtCourseName.TabIndex = 9;
            // 
            // btnFirstCourse
            // 
            this.btnFirstCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnFirstCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstCourse.Location = new System.Drawing.Point(20, 330);
            this.btnFirstCourse.Name = "btnFirstCourse";
            this.btnFirstCourse.Size = new System.Drawing.Size(63, 40);
            this.btnFirstCourse.TabIndex = 3;
            this.btnFirstCourse.Text = "<<";
            this.btnFirstCourse.UseVisualStyleBackColor = false;
            this.btnFirstCourse.Click += new System.EventHandler(this.btnFirstCourse_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(712, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // dgvCourses
            // 
            this.dgvCourses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCourses.Location = new System.Drawing.Point(11, 84);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvCourses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(609, 233);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.SelectionChanged += new System.EventHandler(this.dgvCourses_SelectionChanged);
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
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(712, 71);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(81, 13);
            this.lblModCode.TabIndex = 0;
            this.lblModCode.Text = "Module Code";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(713, 193);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(424, 58);
            this.rtbDesc.TabIndex = 2;
            this.rtbDesc.Text = "";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(712, 122);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(82, 13);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "Course Name";
            // 
            // gbxCourseData
            // 
            this.gbxCourseData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.gbxCourseData.Controls.Add(this.btnResourceLast);
            this.gbxCourseData.Controls.Add(this.dgvResources);
            this.gbxCourseData.Controls.Add(this.btnResourceNext);
            this.gbxCourseData.Controls.Add(this.btnResourcePrev);
            this.gbxCourseData.Controls.Add(this.btnSaveResource);
            this.gbxCourseData.Controls.Add(this.btnResourceFirst);
            this.gbxCourseData.Controls.Add(this.btnDeleteResource);
            this.gbxCourseData.Controls.Add(this.txtLink);
            this.gbxCourseData.Controls.Add(this.lblLink);
            this.gbxCourseData.ForeColor = System.Drawing.Color.White;
            this.gbxCourseData.Location = new System.Drawing.Point(15, 411);
            this.gbxCourseData.Name = "gbxCourseData";
            this.gbxCourseData.Size = new System.Drawing.Size(1148, 229);
            this.gbxCourseData.TabIndex = 2;
            this.gbxCourseData.TabStop = false;
            this.gbxCourseData.Text = "Course Resources";
            // 
            // btnResourceLast
            // 
            this.btnResourceLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnResourceLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResourceLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceLast.Location = new System.Drawing.Point(543, 173);
            this.btnResourceLast.Name = "btnResourceLast";
            this.btnResourceLast.Size = new System.Drawing.Size(63, 40);
            this.btnResourceLast.TabIndex = 23;
            this.btnResourceLast.Text = ">>";
            this.btnResourceLast.UseVisualStyleBackColor = false;
            this.btnResourceLast.Click += new System.EventHandler(this.btnResourceLast_Click);
            // 
            // dgvResources
            // 
            this.dgvResources.AllowUserToAddRows = false;
            this.dgvResources.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Location = new System.Drawing.Point(11, 21);
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.ReadOnly = true;
            this.dgvResources.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvResources.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResources.RowTemplate.Height = 24;
            this.dgvResources.Size = new System.Drawing.Size(609, 142);
            this.dgvResources.TabIndex = 20;
            // 
            // btnResourceNext
            // 
            this.btnResourceNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnResourceNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResourceNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceNext.Location = new System.Drawing.Point(448, 174);
            this.btnResourceNext.Name = "btnResourceNext";
            this.btnResourceNext.Size = new System.Drawing.Size(57, 40);
            this.btnResourceNext.TabIndex = 22;
            this.btnResourceNext.Text = ">";
            this.btnResourceNext.UseVisualStyleBackColor = false;
            this.btnResourceNext.Click += new System.EventHandler(this.btnResourceNext_Click);
            // 
            // btnResourcePrev
            // 
            this.btnResourcePrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnResourcePrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResourcePrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourcePrev.Location = new System.Drawing.Point(122, 173);
            this.btnResourcePrev.Name = "btnResourcePrev";
            this.btnResourcePrev.Size = new System.Drawing.Size(57, 40);
            this.btnResourcePrev.TabIndex = 21;
            this.btnResourcePrev.Text = "<";
            this.btnResourcePrev.UseVisualStyleBackColor = false;
            this.btnResourcePrev.Click += new System.EventHandler(this.btnResourcePrev_Click);
            // 
            // btnSaveResource
            // 
            this.btnSaveResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.btnSaveResource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResource.Location = new System.Drawing.Point(783, 159);
            this.btnSaveResource.Name = "btnSaveResource";
            this.btnSaveResource.Size = new System.Drawing.Size(126, 40);
            this.btnSaveResource.TabIndex = 14;
            this.btnSaveResource.Text = "Add Resource";
            this.btnSaveResource.UseVisualStyleBackColor = false;
            this.btnSaveResource.Click += new System.EventHandler(this.btnSaveResource_Click);
            // 
            // btnResourceFirst
            // 
            this.btnResourceFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnResourceFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResourceFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourceFirst.Location = new System.Drawing.Point(20, 173);
            this.btnResourceFirst.Name = "btnResourceFirst";
            this.btnResourceFirst.Size = new System.Drawing.Size(63, 40);
            this.btnResourceFirst.TabIndex = 20;
            this.btnResourceFirst.Text = "<<";
            this.btnResourceFirst.UseVisualStyleBackColor = false;
            this.btnResourceFirst.Click += new System.EventHandler(this.btnResourceFirst_Click);
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteResource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteResource.Location = new System.Drawing.Point(924, 159);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteResource.TabIndex = 14;
            this.btnDeleteResource.Text = "Remove Selected";
            this.btnDeleteResource.UseVisualStyleBackColor = false;
            this.btnDeleteResource.Click += new System.EventHandler(this.btnDeleteResource_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(713, 87);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(424, 19);
            this.txtLink.TabIndex = 8;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(712, 71);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(89, 13);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Resource Link";
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1179, 657);
            this.Controls.Add(this.gbxCourseData);
            this.Controls.Add(this.gbcSearchCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.gbcSearchCourse.ResumeLayout(false);
            this.gbcSearchCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.gbxCourseData.ResumeLayout(false);
            this.gbxCourseData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcSearchCourse;
        private System.Windows.Forms.GroupBox gbxCourseData;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnLastCourse;
        private System.Windows.Forms.Button btnNextCourse;
        private System.Windows.Forms.Button btnPrevCourse;
        private System.Windows.Forms.Button btnFirstCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnSaveResource;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnResourceLast;
        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.Button btnResourceNext;
        private System.Windows.Forms.Button btnResourcePrev;
        private System.Windows.Forms.Button btnResourceFirst;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.Button btnInsertCourse;
    }
}