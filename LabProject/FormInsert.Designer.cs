namespace LabProject
{
    partial class FormInsert
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddressCode = new System.Windows.Forms.TextBox();
            this.txtPhoneFee = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddressCode = new System.Windows.Forms.Label();
            this.lblPhoneFee = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnCourse = new System.Windows.Forms.RadioButton();
            this.rdbtnSchool = new System.Windows.Forms.RadioButton();
            this.lblIDLocation = new System.Windows.Forms.Label();
            this.txtIDLocation = new System.Windows.Forms.TextBox();
            this.gbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(319, 107);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddressCode
            // 
            this.txtAddressCode.Location = new System.Drawing.Point(127, 160);
            this.txtAddressCode.Name = "txtAddressCode";
            this.txtAddressCode.Size = new System.Drawing.Size(134, 20);
            this.txtAddressCode.TabIndex = 2;
            // 
            // txtPhoneFee
            // 
            this.txtPhoneFee.Location = new System.Drawing.Point(127, 190);
            this.txtPhoneFee.Name = "txtPhoneFee";
            this.txtPhoneFee.Size = new System.Drawing.Size(134, 20);
            this.txtPhoneFee.TabIndex = 3;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(127, 216);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(134, 20);
            this.txtCourseID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "SchoolName";
            // 
            // lblAddressCode
            // 
            this.lblAddressCode.AutoSize = true;
            this.lblAddressCode.Location = new System.Drawing.Point(31, 163);
            this.lblAddressCode.Name = "lblAddressCode";
            this.lblAddressCode.Size = new System.Drawing.Size(81, 13);
            this.lblAddressCode.TabIndex = 9;
            this.lblAddressCode.Text = "School Address";
            // 
            // lblPhoneFee
            // 
            this.lblPhoneFee.AutoSize = true;
            this.lblPhoneFee.Location = new System.Drawing.Point(31, 190);
            this.lblPhoneFee.Name = "lblPhoneFee";
            this.lblPhoneFee.Size = new System.Drawing.Size(74, 13);
            this.lblPhoneFee.TabIndex = 10;
            this.lblPhoneFee.Text = "School Phone";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(31, 219);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(51, 13);
            this.lblCourseID.TabIndex = 11;
            this.lblCourseID.Text = "CourseID";
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.rdbtnCourse);
            this.gbox1.Controls.Add(this.rdbtnSchool);
            this.gbox1.Location = new System.Drawing.Point(34, 26);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(227, 48);
            this.gbox1.TabIndex = 10;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "Table";
            // 
            // rdbtnCourse
            // 
            this.rdbtnCourse.AutoSize = true;
            this.rdbtnCourse.Location = new System.Drawing.Point(131, 20);
            this.rdbtnCourse.Name = "rdbtnCourse";
            this.rdbtnCourse.Size = new System.Drawing.Size(58, 17);
            this.rdbtnCourse.TabIndex = 9;
            this.rdbtnCourse.Text = "Course";
            this.rdbtnCourse.UseVisualStyleBackColor = true;
            this.rdbtnCourse.CheckedChanged += new System.EventHandler(this.rdbtnCourse_CheckedChanged);
            // 
            // rdbtnSchool
            // 
            this.rdbtnSchool.AutoSize = true;
            this.rdbtnSchool.Checked = true;
            this.rdbtnSchool.Location = new System.Drawing.Point(7, 20);
            this.rdbtnSchool.Name = "rdbtnSchool";
            this.rdbtnSchool.Size = new System.Drawing.Size(58, 17);
            this.rdbtnSchool.TabIndex = 8;
            this.rdbtnSchool.TabStop = true;
            this.rdbtnSchool.Text = "School";
            this.rdbtnSchool.UseVisualStyleBackColor = true;
            this.rdbtnSchool.CheckedChanged += new System.EventHandler(this.rdbtnSchool_CheckedChanged);
            // 
            // lblIDLocation
            // 
            this.lblIDLocation.AutoSize = true;
            this.lblIDLocation.Location = new System.Drawing.Point(31, 107);
            this.lblIDLocation.Name = "lblIDLocation";
            this.lblIDLocation.Size = new System.Drawing.Size(54, 13);
            this.lblIDLocation.TabIndex = 14;
            this.lblIDLocation.Text = "School ID";
            // 
            // txtIDLocation
            // 
            this.txtIDLocation.Location = new System.Drawing.Point(127, 104);
            this.txtIDLocation.Name = "txtIDLocation";
            this.txtIDLocation.Size = new System.Drawing.Size(134, 20);
            this.txtIDLocation.TabIndex = 0;
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.lblIDLocation);
            this.Controls.Add(this.txtIDLocation);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lblPhoneFee);
            this.Controls.Add(this.lblAddressCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.txtPhoneFee);
            this.Controls.Add(this.txtAddressCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "FormInsert";
            this.Text = "Insert";
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddressCode;
        private System.Windows.Forms.TextBox txtPhoneFee;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddressCode;
        private System.Windows.Forms.Label lblPhoneFee;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.RadioButton rdbtnCourse;
        private System.Windows.Forms.RadioButton rdbtnSchool;
        private System.Windows.Forms.Label lblIDLocation;
        private System.Windows.Forms.TextBox txtIDLocation;
    }
}