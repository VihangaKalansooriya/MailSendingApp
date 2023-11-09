using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSendingApp
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=DESKTOP-AUL1S01;Initial Catalog=Test01;User ID=pll;Password=myposadminauthentication";
        public Form2()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Select", 
                Name = "Select",
            };

            dataGridView1.Columns.Insert(0, checkBoxColumn); 
            dataGridView1.AllowUserToAddRows = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_TYPE, TB_RUNNO FROM TB_MAILDETAILS WHERE TB_STATUS=0";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test01DataSet2.TB_MAILDETAILS' table. You can move, or remove it, as needed.
            this.tB_MAILDETAILSTableAdapter.Fill(this.test01DataSet2.TB_MAILDETAILS);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.EditedFormattedValue)
                {
                    // This row is checked
                    int tbId = Convert.ToInt32(row.Cells["TB_ID"].Value);
                    string receiverMail = row.Cells["TB_RECEIVERMAIL"].Value.ToString();
                    // ... and so on for other columns

                    // Perform your desired actions with the checked data
                }
            }
        }

        private void btn_selectall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = true;
                }
            }
        }

        private void btn_deselectall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_TYPE, TB_RUNNO FROM TB_MAILDETAILS WHERE TB_STATUS=0";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
