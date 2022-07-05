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
    public partial class UserManagement : Form
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=localhost;Initial Catalog=InventoryMilestone;user id=admin;password=123456;");
        SqlCommand sqlCmd = new SqlCommand();
        DataTable sqlDt = new DataTable();
        SqlDataReader sqlRd;
        InventoryMilestoneDataSet1TableAdapters.usersTableAdapter adapter = new InventoryMilestoneDataSet1TableAdapters.usersTableAdapter();

        public UserManagement()
        {
            InitializeComponent();
        }

        private void uploadData()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM users;";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            dataGridView1.DataSource = sqlDt; 
            sqlRd.Close();
            sqlConn.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            adapter.InsertUser(username.Text, password.Text);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dataGridView1.DataSource = adapter.GetData();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            adapter.UpdateUser(username.Text, password.Text);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dataGridView1.DataSource = adapter.GetData();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            adapter.DeleteUser(username.Text);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dataGridView1.DataSource = adapter.GetData();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                password.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
