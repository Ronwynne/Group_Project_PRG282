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
            this.btnLastCourse = new System.Windows.Forms.Button();
            this.btnNextCourse = new System.Windows.Forms.Button();
            this.btnPrevCourse = new System.Windows.Forms.Button();
            this.btnFirstCourse = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.gbxCourseData = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.cbxNewCourse = new System.Windows.Forms.CheckBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblModCode = new System.Windows.Forms.Label();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnSaveResource = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.cbxCourseModCode = new System.Windows.Forms.ComboBox();
            this.cbxResourseModCode = new System.Windows.Forms.ComboBox();
            this.lblResourseModCode = new System.Windows.Forms.Label();
            this.cbxAddResourses = new System.Windows.Forms.CheckBox();
            this.txtCourseResource = new System.Windows.Forms.TextBox();
            this.lblCourseResource = new System.Windows.Forms.Label();
            this.dgvCourseResources = new System.Windows.Forms.DataGridView();
            this.btnResourceLast = new System.Windows.Forms.Button();
            this.btnResourceNext = new System.Windows.Forms.Button();
            this.btnResourcePrev = new System.Windows.Forms.Button();
            this.btnResourceFirst = new System.Windows.Forms.Button();
            this.gbcSearchCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.gbxCourseData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseResources)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcSearchCourse
            // 
            this.gbcSearchCourse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbcSearchCourse.Controls.Add(this.txtCourseResource);
            this.gbcSearchCourse.Controls.Add(this.cbxCourseModCode);
            this.gbcSearchCourse.Controls.Add(this.lblCourseResource);
            this.gbcSearchCourse.Controls.Add(this.btnSaveChanges);
            this.gbcSearchCourse.Controls.Add(this.btnLastCourse);
            this.gbcSearchCourse.Controls.Add(this.btnDeleteCourse);
            this.gbcSearchCourse.Controls.Add(this.btnBack);
            this.gbcSearchCourse.Controls.Add(this.btnSearchCourses);
            this.gbcSearchCourse.Controls.Add(this.btnNextCourse);
            this.gbcSearchCourse.Controls.Add(this.txtSearchCourse);
            this.gbcSearchCourse.Controls.Add(this.btnPrevCourse);
            this.gbcSearchCourse.Controls.Add(this.txtCourseName);
            this.gbcSearchCourse.Controls.Add(this.btnFirstCourse);
            this.gbcSearchCourse.Controls.Add(this.lblDescription);
            this.gbcSearchCourse.Controls.Add(this.dgvCourses);
            this.gbcSearchCourse.Controls.Add(this.label1);
            this.gbcSearchCourse.Controls.Add(this.lblModCode);
            this.gbcSearchCourse.Controls.Add(this.cbxNewCourse);
            this.gbcSearchCourse.Controls.Add(this.rtbDesc);
            this.gbcSearchCourse.Controls.Add(this.lblCourseName);
            this.gbcSearchCourse.Location = new System.Drawing.Point(15, 13);
            this.gbcSearchCourse.Name = "gbcSearchCourse";
            this.gbcSearchCourse.Size = new System.Drawing.Size(1148, 382);
            this.gbcSearchCourse.TabIndex = 0;
            this.gbcSearchCourse.TabStop = false;
            this.gbcSearchCourse.Text = "Course Data";
            // 
            // btnSearchCourses
            // 
            this.btnSearchCourses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchCourses.Location = new System.Drawing.Point(507, 20);
            this.btnSearchCourses.Name = "btnSearchCourses";
            this.btnSearchCourses.Size = new System.Drawing.Size(113, 38);
            this.btnSearchCourses.TabIndex = 2;
            this.btnSearchCourses.Text = "Search";
            this.btnSearchCourses.UseVisualStyleBackColor = false;
            this.btnSearchCourses.Click += new System.EventHandler(this.btnSearchCourses_Click);
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Location = new System.Drawing.Point(261, 28);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(153, 22);
            this.txtSearchCourse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Course by Module Code";
            // 
            // btnLastCourse
            // 
            this.btnLastCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLastCourse.Location = new System.Drawing.Point(543, 337);
            this.btnLastCourse.Name = "btnLastCourse";
            this.btnLastCourse.Size = new System.Drawing.Size(63, 40);
            this.btnLastCourse.TabIndex = 6;
            this.btnLastCourse.Text = ">>";
            this.btnLastCourse.UseVisualStyleBackColor = false;
            // 
            // btnNextCourse
            // 
            this.btnNextCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNextCourse.Location = new System.Drawing.Point(448, 337);
            this.btnNextCourse.Name = "btnNextCourse";
            this.btnNextCourse.Size = new System.Drawing.Size(57, 40);
            this.btnNextCourse.TabIndex = 5;
            this.btnNextCourse.Text = ">";
            this.btnNextCourse.UseVisualStyleBackColor = false;
            // 
            // btnPrevCourse
            // 
            this.btnPrevCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrevCourse.Location = new System.Drawing.Point(122, 337);
            this.btnPrevCourse.Name = "btnPrevCourse";
            this.btnPrevCourse.Size = new System.Drawing.Size(57, 40);
            this.btnPrevCourse.TabIndex = 4;
            this.btnPrevCourse.Text = "<";
            this.btnPrevCourse.UseVisualStyleBackColor = false;
            // 
            // btnFirstCourse
            // 
            this.btnFirstCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFirstCourse.Location = new System.Drawing.Point(20, 337);
            this.btnFirstCourse.Name = "btnFirstCourse";
            this.btnFirstCourse.Size = new System.Drawing.Size(63, 40);
            this.btnFirstCourse.TabIndex = 3;
            this.btnFirstCourse.Text = "<<";
            this.btnFirstCourse.UseVisualStyleBackColor = false;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(11, 84);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(609, 233);
            this.dgvCourses.TabIndex = 0;
            // 
            // gbxCourseData
            // 
            this.gbxCourseData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxCourseData.Controls.Add(this.btnResourceLast);
            this.gbxCourseData.Controls.Add(this.dgvCourseResources);
            this.gbxCourseData.Controls.Add(this.btnResourceNext);
            this.gbxCourseData.Controls.Add(this.cbxResourseModCode);
            this.gbxCourseData.Controls.Add(this.btnResourcePrev);
            this.gbxCourseData.Controls.Add(this.btnSaveResource);
            this.gbxCourseData.Controls.Add(this.btnResourceFirst);
            this.gbxCourseData.Controls.Add(this.lblResourseModCode);
            this.gbxCourseData.Controls.Add(this.cbxAddResourses);
            this.gbxCourseData.Controls.Add(this.btnDeleteResource);
            this.gbxCourseData.Controls.Add(this.txtLink);
            this.gbxCourseData.Controls.Add(this.lblLink);
            this.gbxCourseData.Location = new System.Drawing.Point(15, 411);
            this.gbxCourseData.Name = "gbxCourseData";
            this.gbxCourseData.Size = new System.Drawing.Size(1148, 229);
            this.gbxCourseData.TabIndex = 2;
            this.gbxCourseData.TabStop = false;
            this.gbxCourseData.Text = "Course Resources";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveChanges.Location = new System.Drawing.Point(864, 337);
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
            this.btnBack.Location = new System.Drawing.Point(1011, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back To Main";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(713, 78);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(424, 22);
            this.txtLink.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(712, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 16);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(710, 121);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(101, 16);
            this.lblCourseName.TabIndex = 6;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(710, 59);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(106, 16);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Resource Link";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteCourse.Location = new System.Drawing.Point(715, 337);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            // 
            // cbxNewCourse
            // 
            this.cbxNewCourse.AutoSize = true;
            this.cbxNewCourse.Location = new System.Drawing.Point(993, 38);
            this.cbxNewCourse.Name = "cbxNewCourse";
            this.cbxNewCourse.Size = new System.Drawing.Size(144, 20);
            this.cbxNewCourse.TabIndex = 3;
            this.cbxNewCourse.Text = "Add New Course";
            this.cbxNewCourse.UseVisualStyleBackColor = true;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(713, 202);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(424, 58);
            this.rtbDesc.TabIndex = 2;
            this.rtbDesc.Text = "";
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(712, 65);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(99, 16);
            this.lblModCode.TabIndex = 0;
            this.lblModCode.Text = "Module Code";
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteResource.Location = new System.Drawing.Point(713, 179);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(126, 40);
            this.btnDeleteResource.TabIndex = 14;
            this.btnDeleteResource.Text = "Delete Course";
            this.btnDeleteResource.UseVisualStyleBackColor = false;
            // 
            // btnSaveResource
            // 
            this.btnSaveResource.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveResource.Location = new System.Drawing.Point(1011, 179);
            this.btnSaveResource.Name = "btnSaveResource";
            this.btnSaveResource.Size = new System.Drawing.Size(126, 40);
            this.btnSaveResource.TabIndex = 14;
            this.btnSaveResource.Text = "Save Changes";
            this.btnSaveResource.UseVisualStyleBackColor = false;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(713, 140);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(424, 22);
            this.txtCourseName.TabIndex = 9;
            // 
            // cbxCourseModCode
            // 
            this.cbxCourseModCode.FormattingEnabled = true;
            this.cbxCourseModCode.Location = new System.Drawing.Point(713, 84);
            this.cbxCourseModCode.Name = "cbxCourseModCode";
            this.cbxCourseModCode.Size = new System.Drawing.Size(424, 24);
            this.cbxCourseModCode.TabIndex = 14;
            // 
            // cbxResourseModCode
            // 
            this.cbxResourseModCode.FormattingEnabled = true;
            this.cbxResourseModCode.Location = new System.Drawing.Point(713, 139);
            this.cbxResourseModCode.Name = "cbxResourseModCode";
            this.cbxResourseModCode.Size = new System.Drawing.Size(424, 24);
            this.cbxResourseModCode.TabIndex = 17;
            // 
            // lblResourseModCode
            // 
            this.lblResourseModCode.AutoSize = true;
            this.lblResourseModCode.Location = new System.Drawing.Point(710, 115);
            this.lblResourseModCode.Name = "lblResourseModCode";
            this.lblResourseModCode.Size = new System.Drawing.Size(99, 16);
            this.lblResourseModCode.TabIndex = 15;
            this.lblResourseModCode.Text = "Module Code";
            // 
            // cbxAddResourses
            // 
            this.cbxAddResourses.AutoSize = true;
            this.cbxAddResourses.Location = new System.Drawing.Point(975, 30);
            this.cbxAddResourses.Name = "cbxAddResourses";
            this.cbxAddResourses.Size = new System.Drawing.Size(162, 20);
            this.cbxAddResourses.TabIndex = 16;
            this.cbxAddResourses.Text = "Add New Resource";
            this.cbxAddResourses.UseVisualStyleBackColor = true;
            // 
            // txtCourseResource
            // 
            this.txtCourseResource.Location = new System.Drawing.Point(715, 294);
            this.txtCourseResource.Name = "txtCourseResource";
            this.txtCourseResource.Size = new System.Drawing.Size(424, 22);
            this.txtCourseResource.TabIndex = 19;
            this.txtCourseResource.Visible = false;
            // 
            // lblCourseResource
            // 
            this.lblCourseResource.AutoSize = true;
            this.lblCourseResource.Location = new System.Drawing.Point(712, 275);
            this.lblCourseResource.Name = "lblCourseResource";
            this.lblCourseResource.Size = new System.Drawing.Size(106, 16);
            this.lblCourseResource.TabIndex = 18;
            this.lblCourseResource.Text = "Resource Link";
            this.lblCourseResource.Visible = false;
            // 
            // dgvCourseResources
            // 
            this.dgvCourseResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseResources.Location = new System.Drawing.Point(11, 21);
            this.dgvCourseResources.Name = "dgvCourseResources";
            this.dgvCourseResources.RowHeadersWidth = 51;
            this.dgvCourseResources.RowTemplate.Height = 24;
            this.dgvCourseResources.Size = new System.Drawing.Size(609, 142);
            this.dgvCourseResources.TabIndex = 20;
            // 
            // btnResourceLast
            // 
            this.btnResourceLast.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResourceLast.Location = new System.Drawing.Point(543, 179);
            this.btnResourceLast.Name = "btnResourceLast";
            this.btnResourceLast.Size = new System.Drawing.Size(63, 40);
            this.btnResourceLast.TabIndex = 23;
            this.btnResourceLast.Text = ">>";
            this.btnResourceLast.UseVisualStyleBackColor = false;
            // 
            // btnResourceNext
            // 
            this.btnResourceNext.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResourceNext.Location = new System.Drawing.Point(448, 179);
            this.btnResourceNext.Name = "btnResourceNext";
            this.btnResourceNext.Size = new System.Drawing.Size(57, 40);
            this.btnResourceNext.TabIndex = 22;
            this.btnResourceNext.Text = ">";
            this.btnResourceNext.UseVisualStyleBackColor = false;
            // 
            // btnResourcePrev
            // 
            this.btnResourcePrev.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResourcePrev.Location = new System.Drawing.Point(122, 179);
            this.btnResourcePrev.Name = "btnResourcePrev";
            this.btnResourcePrev.Size = new System.Drawing.Size(57, 40);
            this.btnResourcePrev.TabIndex = 21;
            this.btnResourcePrev.Text = "<";
            this.btnResourcePrev.UseVisualStyleBackColor = false;
            // 
            // btnResourceFirst
            // 
            this.btnResourceFirst.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResourceFirst.Location = new System.Drawing.Point(20, 179);
            this.btnResourceFirst.Name = "btnResourceFirst";
            this.btnResourceFirst.Size = new System.Drawing.Size(63, 40);
            this.btnResourceFirst.TabIndex = 20;
            this.btnResourceFirst.Text = "<<";
            this.btnResourceFirst.UseVisualStyleBackColor = false;
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1179, 657);
            this.Controls.Add(this.gbxCourseData);
            this.Controls.Add(this.gbcSearchCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.gbcSearchCourse.ResumeLayout(false);
            this.gbcSearchCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.gbxCourseData.ResumeLayout(false);
            this.gbxCourseData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcSearchCourse;
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
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnSaveResource;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.ComboBox cbxCourseModCode;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.ComboBox cbxResourseModCode;
        private System.Windows.Forms.Label lblResourseModCode;
        private System.Windows.Forms.CheckBox cbxAddResourses;
        private System.Windows.Forms.TextBox txtCourseResource;
        private System.Windows.Forms.Label lblCourseResource;
        private System.Windows.Forms.Button btnResourceLast;
        private System.Windows.Forms.DataGridView dgvCourseResources;
        private System.Windows.Forms.Button btnResourceNext;
        private System.Windows.Forms.Button btnResourcePrev;
        private System.Windows.Forms.Button btnResourceFirst;
    }
}