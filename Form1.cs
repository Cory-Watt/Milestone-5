using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MilestoneProject
{
    public partial class Form1 : Form
    {

        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlRd;

        public Form1()
        {
            InitializeComponent();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {
                iExit = MessageBox.Show("Are you sure you want to exit?", "SQL Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=localhost;Initial Catalog=InventoryMilestone;user id=admin;password=123456;");
            string query = "SELECT * FROM users WHERE username= '" + usernameTb.Text + "' AND password= '" + passwordTb.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password.");
            }           
        }
    }
}
