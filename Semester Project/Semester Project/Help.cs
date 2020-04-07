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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        //Return User to Main Form after reading about
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
