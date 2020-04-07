using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //To make exit menu option close 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SemesterLabel_Click(object sender, EventArgs e)
        {
            //Ignore
        }

        private void studentInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInfoDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentInfoDataSet.StudentInfo);

        }

        //Void
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //To get See Classes to show using menu
        private void seeClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeeClasses manageSC = new SeeClasses();
            manageSC.ShowDialog();
                
        }
        //To get See Grades to show using menu
        private void seeGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeeGrades manageSG = new SeeGrades();
            manageSG.ShowDialog();
        }

        //The student info data
        private void studentInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Teacher/Student selection for combobox
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //To make exit button work
        
        private void ExitMainButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();
        }
        //To make print button work
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Help helpForm = new Help();

            helpForm.ShowDialog();
        }
    }
}
