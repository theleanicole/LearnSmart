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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //To make the exit button close the program

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //To make the reset button reset the textboxes

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UserTextBox.Text = string.Empty;
            PassTextBox.Text = string.Empty;

        }

        //To make login button work to catch invalid user/passwords and connect to the mainform
        private void LoginButton_Click(object sender, EventArgs e)
        {                         
                    
            //Return error message if user box is blank and won't login
            if (String.IsNullOrEmpty(UserTextBox.Text))
            {
                MessageBox.Show("Enter valid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();

                mainForm.ShowDialog();
            }

            //Return error message if password box is blank and won't login
            if (String.IsNullOrEmpty(PassTextBox.Text))
            {
                MessageBox.Show("Enter valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();

                mainForm.ShowDialog();
            }
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


    
}
    





        

       

 
