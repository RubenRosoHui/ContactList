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
    public partial class FormUpdate : Form
    {
        int SchoolID, CourseID, CourseFee;
        string CourseName, CourseCode, CourseLocation, SchoolName, SchoolAddress, SchoolPhone;
        bool save;

        //Database adapter and connection
        OleDbDataAdapter da = new OleDbDataAdapter();
        string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Final.accdb";
        
        public FormUpdate()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseID.Text = "";
            txtAddressCode.Text = "";
            txtName.Text = "";
            txtPhoneFee.Text = "";
            txtIDLocation.Text = "";
        }

        private void rdbtnSchool_CheckedChanged_1(object sender, EventArgs e)
        {
            lblName.Text = "School Name";
            lblAddressCode.Text = "School address";
            lblPhoneFee.Text = "School phone";
            lblIDLocation.Text = "School ID number";
            txtAddressCode.Text = "";
            txtCourseID.Text = "";
            txtIDLocation.Text = "";
            txtName.Text = "";
            txtPhoneFee.Text = "";
        }

        private void rdbtnCourse_CheckedChanged_1(object sender, EventArgs e)
        {
            lblName.Text = "Course Name";
            lblAddressCode.Text = "Course code";
            lblPhoneFee.Text = "Course fee";
            lblIDLocation.Text = "Course location";
            txtAddressCode.Text = "";
            txtCourseID.Text = "";
            txtIDLocation.Text = "";
            txtName.Text = "";
            txtPhoneFee.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Please enter something into the textbox for School before saving OR type into the SchoolID and CourseID and click refresh for the rest to show.");
                    save = false;
                }
                else if (save) 
                {
                    try
                    {
                    //Access Database HERE!!!!
                    OleDbConnection connect = new OleDbConnection(constr);
                    connect.Open();
                    string sqlUpdate = "UPDATE School SET SchoolName ='" + SchoolName + "', SchoolAddress = '" + SchoolAddress + "', SchoolPhone = '" + SchoolPhone + "' WHERE (SchoolID = " + SchoolID + "AND CourseID = " + CourseID + ")";
                    da.UpdateCommand = new OleDbCommand(sqlUpdate, connect);
                    da.UpdateCommand.ExecuteNonQuery();
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
                    string sqlInstert = "UPDATE Courses SET CourseName ='" + CourseName + "', CourseCode = '" + CourseCode + "', CourseFee = '" + CourseFee + "', CourseLocation = '" + CourseLocation + "' WHERE (CourseID = " + CourseID + ")";
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
            txtAddressCode.Text = "";
            txtCourseID.Text = "";
            txtIDLocation.Text = "";
            txtName.Text = "";
            txtPhoneFee.Text = "";
            save = false;
        
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int check;
            if (rdbtnSchool.Checked)
            {
                if (Int32.TryParse(txtIDLocation.Text, out check) && Int32.TryParse(txtCourseID.Text, out check))
                {
                    SchoolID = Convert.ToInt32(txtIDLocation.Text);
                    CourseID = Convert.ToInt32(txtCourseID.Text);
                    try
                    {
                        OleDbConnection connect = new OleDbConnection(constr);
                        connect.Open();
                        string sqlSelect = "SELECT SchoolName,SchoolAddress,SchoolPhone FROM School WHERE SchoolID = " + SchoolID + " AND CourseID = " + CourseID + "";
                        da.SelectCommand = new OleDbCommand(sqlSelect, connect);
                        OleDbDataReader dr = null;
                        dr = da.SelectCommand.ExecuteReader();
                        while (dr.Read())
                        {
                            txtAddressCode.Text = (dr["SchoolAddress"].ToString());
                            txtName.Text = (dr["SchoolName"].ToString());
                            txtPhoneFee.Text = (dr["SchoolPhone"].ToString());
                        }
                        connect.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                
                }
                else
                {
                    MessageBox.Show("Please enter properly, both CourseID and SchoolID before clicking the refresh button.");
                }
            }
            if (rdbtnCourse.Checked)
            {
                if (Int32.TryParse(txtCourseID.Text, out check))
                {
                    CourseID = Convert.ToInt32(txtCourseID.Text);

                    try
                    { 
                
                        OleDbConnection connect = new OleDbConnection(constr);
                        connect.Open();
                        string sqlSelect = "SELECT CourseName,CourseCode,CourseFee,CourseLocation FROM Courses WHERE CourseID = " + CourseID + "";
                        da.SelectCommand = new OleDbCommand(sqlSelect, connect);
                        OleDbDataReader dr = null;
                        dr = da.SelectCommand.ExecuteReader();
                        while (dr.Read())
                        {
                            txtAddressCode.Text = (dr["CourseCode"].ToString());
                            txtName.Text = (dr["CourseName"].ToString());
                            txtPhoneFee.Text = (dr["CourseFee"].ToString());
                            txtIDLocation.Text = (dr["CourseLocation"].ToString());
                        }
                        connect.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    MessageBox.Show("Please enter properly, CourseID before clicking the refresh button.");
                }
            }

        }
    }
}
