using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //close program once the red X is clicked
            DialogResult iExit;
            try
            {

                iExit = MessageBox.Show("Are you sure you want to exit?", "MySQL Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemManagementBtn_Click(object sender, EventArgs e)
        {
            //once item management is clicked, hide form2 and display form3
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void userManagementBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement um = new UserManagement();
            um.Show();

        }
    }
}