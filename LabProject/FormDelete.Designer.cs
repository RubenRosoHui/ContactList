namespace LabProject
{
    partial class FormDelete
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblIDLocation = new System.Windows.Forms.Label();
            this.txtIDLocation = new System.Windows.Forms.TextBox();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnCourse = new System.Windows.Forms.RadioButton();
            this.rdbtnSchool = new System.Windows.Forms.RadioButton();
            this.lblPhoneFee = new System.Windows.Forms.Label();
            this.lblAddressCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneFee = new System.Windows.Forms.TextBox();
            this.txtAddressCode = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.gbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(315, 109);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblIDLocation
            // 
            this.lblIDLocation.AutoSize = true;
            this.lblIDLocation.Location = new System.Drawing.Point(27, 109);
            this.lblIDLocation.Name = "lblIDLocation";
            this.lblIDLocation.Size = new System.Drawing.Size(54, 13);
            this.lblIDLocation.TabIndex = 41;
            this.lblIDLocation.Text = "School ID";
            // 
            // txtIDLocation
            // 
            this.txtIDLocation.Location = new System.Drawing.Point(123, 106);
            this.txtIDLocation.Name = "txtIDLocation";
            this.txtIDLocation.Size = new System.Drawing.Size(134, 20);
            this.txtIDLocation.TabIndex = 0;
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.rdbtnCourse);
            this.gbox1.Controls.Add(this.rdbtnSchool);
            this.gbox1.Location = new System.Drawing.Point(57, 23);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(227, 48);
            this.gbox1.TabIndex = 39;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "Table";
            // 
            // rdbtnCourse
            // 
            this.rdbtnCourse.AutoSize = true;
            this.rdbtnCourse.Location = new System.Drawing.Point(141, 19);
            this.rdbtnCourse.Name = "rdbtnCourse";
            this.rdbtnCourse.Size = new System.Drawing.Size(58, 17);
            this.rdbtnCourse.TabIndex = 1;
            this.rdbtnCourse.TabStop = true;
            this.rdbtnCourse.Text = "Course";
            this.rdbtnCourse.UseVisualStyleBackColor = true;
            this.rdbtnCourse.CheckedChanged += new System.EventHandler(this.rdbtnCourse_CheckedChanged_1);
            // 
            // rdbtnSchool
            // 
            this.rdbtnSchool.AutoSize = true;
            this.rdbtnSchool.Checked = true;
            this.rdbtnSchool.Location = new System.Drawing.Point(17, 19);
            this.rdbtnSchool.Name = "rdbtnSchool";
            this.rdbtnSchool.Size = new System.Drawing.Size(58, 17);
            this.rdbtnSchool.TabIndex = 9;
            this.rdbtnSchool.TabStop = true;
            this.rdbtnSchool.Text = "School";
            this.rdbtnSchool.UseVisualStyleBackColor = true;
            this.rdbtnSchool.CheckedChanged += new System.EventHandler(this.rdbtnSchool_CheckedChanged_1);
            // 
            // lblPhoneFee
            // 
            this.lblPhoneFee.AutoSize = true;
            this.lblPhoneFee.Location = new System.Drawing.Point(27, 188);
            this.lblPhoneFee.Name = "lblPhoneFee";
            this.lblPhoneFee.Size = new System.Drawing.Size(74, 13);
            this.lblPhoneFee.TabIndex = 37;
            this.lblPhoneFee.Text = "School Phone";
            // 
            // lblAddressCode
            // 
            this.lblAddressCode.AutoSize = true;
            this.lblAddressCode.Location = new System.Drawing.Point(27, 161);
            this.lblAddressCode.Name = "lblAddressCode";
            this.lblAddressCode.Size = new System.Drawing.Size(81, 13);
            this.lblAddressCode.TabIndex = 36;
            this.lblAddressCode.Text = "School Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "School Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPhoneFee
            // 
            this.txtPhoneFee.Location = new System.Drawing.Point(123, 188);
            this.txtPhoneFee.Name = "txtPhoneFee";
            this.txtPhoneFee.Size = new System.Drawing.Size(134, 20);
            this.txtPhoneFee.TabIndex = 3;
            // 
            // txtAddressCode
            // 
            this.txtAddressCode.Location = new System.Drawing.Point(123, 158);
            this.txtAddressCode.Name = "txtAddressCode";
            this.txtAddressCode.Size = new System.Drawing.Size(134, 20);
            this.txtAddressCode.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(315, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(315, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(27, 217);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(51, 13);
            this.lblCourseID.TabIndex = 38;
            this.lblCourseID.Text = "CourseID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(123, 214);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(134, 20);
            this.txtCourseID.TabIndex = 4;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblIDLocation);
            this.Controls.Add(this.txtIDLocation);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.lblPhoneFee);
            this.Controls.Add(this.lblAddressCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhoneFee);
            this.Controls.Add(this.txtAddressCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.txtCourseID);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblIDLocation;
        private System.Windows.Forms.TextBox txtIDLocation;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.RadioButton rdbtnCourse;
        private System.Windows.Forms.RadioButton rdbtnSchool;
        private System.Windows.Forms.Label lblPhoneFee;
        private System.Windows.Forms.Label lblAddressCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneFee;
        private System.Windows.Forms.TextBox txtAddressCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
    }
}