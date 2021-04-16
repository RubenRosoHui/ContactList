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
    public partial class Form1 : Form
    {
        bool connect;
        FormDelete delobj = new FormDelete();
        FormInsert insobj = new FormInsert();
        FormUpdate updateobj = new FormUpdate();
        //CREATE A VIRTUAL DATABASE and use events to return the values from other forms
        
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connect) 
            { 
                insobj.ShowDialog(); 
            }
            else { MessageBox.Show("Please connect before accessing records"); }

        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                updateobj.ShowDialog();
            }
            else { MessageBox.Show("Please connect before accessing records"); }

        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                delobj.ShowDialog();
            }
            else { MessageBox.Show("Please connect before accessing records"); }
            
        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Final.accdb";
                    string SQLstr = txtRunQuery.Text;

                    OleDbDataAdapter da = new OleDbDataAdapter(SQLstr, constr);
                    da.Fill(dt);
                    da.Dispose();
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); txtRunQuery.Text = ""; }
            }

            else { MessageBox.Show("Please connect before accessing records"); }
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connect = true;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRunQuery.Text = "";
            dataGridView1.DataSource = null;
            connect = false;
        }
    }
}
