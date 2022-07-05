using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MilestoneProject
{
    public partial class Form3 : Form
    {
        Bitmap bitmap;
        SqlConnection sqlConn = new SqlConnection("Data Source=localhost;Initial Catalog=InventoryMilestone;user id=admin;password=123456;");
        SqlCommand sqlCmd = new SqlCommand();
        DataTable sqlDt = new DataTable();
        SqlDataReader sqlRd;
        InventoryMilestoneDataSetTableAdapters.DSTableAdapter adapter = new InventoryMilestoneDataSetTableAdapters.DSTableAdapter();

        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void uploadData()
        {
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM inventoryitems";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            dataGridView1.DataSource = sqlDt;
            sqlRd.Close();
            sqlConn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
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

        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            adapter.ItemInsert(ITEM_ID.Text, ITEM_NAME.Text, STORAGE_LOCATION.Text, COST_CASE.Text,
                CASE_QUANTITY_IN_STOCK.Text, EACH_CASE_QUANTITY.Text, EACH_QUANTITY_IN_STOCK.Text, VENDOR.Text, BASE_UNIT_OF_MEASURE.Text);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dataGridView1.DataSource = adapter.GetData();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            adapter.UpdateItem(ITEM_ID.Text, ITEM_NAME.Text, STORAGE_LOCATION.Text, COST_CASE.Text, 
                CASE_QUANTITY_IN_STOCK.Text, EACH_CASE_QUANTITY.Text, EACH_QUANTITY_IN_STOCK.Text, VENDOR.Text, BASE_UNIT_OF_MEASURE.Text);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dataGridView1.DataSource = adapter.GetData();
            }
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ITEM_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ITEM_NAME.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                STORAGE_LOCATION.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                COST_CASE.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                CASE_QUANTITY_IN_STOCK.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                EACH_QUANTITY_IN_STOCK.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                EACH_CASE_QUANTITY.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                VENDOR.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                BASE_UNIT_OF_MEASURE.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            adapter.DeleteItem(ITEM_ID.Text);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dataGridView1.DataSource = adapter.GetData();
            }
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("ITEM_ID like'%{0}'", search.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
