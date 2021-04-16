using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LabProject
{
    public partial class FormInsert : Form
    {
        int SchoolID, CourseID, CourseFee;
        string CourseName, CourseCode, CourseLocation, SchoolName, SchoolAddress, SchoolPhone;
        bool save;
        
        //Database adapter and connection
        OleDbDataAdapter da = new OleDbDataAdapter();
        string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Final.accdb";
        
        public FormInsert()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseID.Text = "";
            txtAddressCode.Text = "";
            txtName.Text = "";
            txtPhoneFee.Text = "";
            txtIDLocation.Text = "";
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rdbtnCourse_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = "Course Name";
            lblAddressCode.Text = "Course code";
            lblPhoneFee.Text = "Course fee";
            lblIDLocation.Text = "Course location";
        }
        private void rdbtnSchool_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = "School Name";
            lblAddressCode.Text = "School address";
            lblPhoneFee.Text = "School phone";
            lblIDLocation.Text = "School ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbtnSchool.Checked)
            {
                
                    int check;
                    long check1;
                    SchoolName = txtName.Text;
                    SchoolAddress = txtAddressCode.Text;
                    if (Int32.TryParse(txtIDLocation.Text, out check) && Int64.TryParse(txtPhoneFee.Text, out check1) && Int32.TryParse(txtCourseID.Text, out check))
                    {
                        SchoolID = Convert.ToInt32(txtIDLocation.Text);
                        SchoolPhone = txtPhoneFee.Text;
                        CourseID = Convert.ToInt32(txtCourseID.Text);
                        save = true;
                    }
                     
                    if (txtAddressCode.Text == "" || txtCourseID.Text == "" || txtIDLocation.Text == "" || txtName.Text == "" || txtPhoneFee.Text == "")
                    {
                        MessageBox.Show("Please enter something into the textbox for School before saving.");
                        save = false;
                    }
                     else if (save)
                    {
                        try
                        {
                        //Access Database HERE!!!!
                        OleDbConnection connect = new OleDbConnection(constr);
                        connect.Open();
                        string sqlInstert = "INSERT INTO School(SchoolID,SchoolName,SchoolAddress,SchoolPhone,CourseID) VALUES('" + SchoolID + "','" + SchoolName + "','" + SchoolAddress + "','" + SchoolPhone + "','" + CourseID + "')";
                        da.InsertCommand = new OleDbCommand(sqlInstert, connect);
                        da.InsertCommand.ExecuteNonQuery();
                        connect.Close();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error!!!! Please try again");
                    }
               
            }
            if (rdbtnCourse.Checked)
            {
                int check;
                CourseName = txtName.Text;
                CourseCode = txtAddressCode.Text;
                CourseLocation = txtIDLocation.Text;
         
                if (Int32.TryParse(txtPhoneFee.Text, out check) && Int32.TryParse(txtCourseID.Text, out check))
                {
                    CourseFee = Convert.ToInt32(txtPhoneFee.Text);
                    CourseID = Convert.ToInt32(txtCourseID.Text);
                    save = true;

                }

                if (txtAddressCode.Text == "" || txtCourseID.Text == "" || txtIDLocation.Text == "" || txtName.Text == "" || txtPhoneFee.Text == "")
                {
                    MessageBox.Show("Please enter something into the textbox for Courses before saving.");
                    save = false;

                }

                else if (save)
                {
                    try
                    {
                    //Access Database HERE!!!!
                    OleDbConnection connect = new OleDbConnection(constr);
                    connect.Open();
                    string sqlInstert = "INSERT INTO Courses(CourseID,CourseName,CourseCode,CourseFee,CourseLocation) VALUES('" + CourseID + "','" + CourseName + "','" + CourseCode + "','" + CourseFee + "','" + CourseLocation + "')";
                    da.InsertCommand = new OleDbCommand(sqlInstert, connect);
                    da.InsertCommand.ExecuteNonQuery();
                    connect.Close();
                    }catch (Exception ex) { MessageBox.Show(ex.Message); }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error!!!! Please try again");
                }

            }
            txtAddressCode.Text = "";
            txtCourseID.Text = "";
            txtIDLocation.Text = "";
            txtName.Text = "";
            txtPhoneFee.Text = "";
            save = false;
        }
    }
}
