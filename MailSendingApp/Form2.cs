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
        private mailApp mailAppInstance;
        public Form2()
        {
            InitializeComponent();
            InitializeButtonDesign();
            mailAppInstance = new mailApp();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "SELECT", 
                Name = "Select",
            };
            dataGridView1.Columns.Insert(0, checkBoxColumn); 
            dataGridView1.AllowUserToAddRows = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
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

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name != "Select")
                    {
                        column.ReadOnly = true;
                    }
                }
                DataGridViewColumn selectColumn = dataGridView1.Columns["Select"];
                if (selectColumn != null)
                {
                    selectColumn.DisplayIndex = 5;
                }

                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle(dataGridView1.ColumnHeadersDefaultCellStyle);
                headerStyle.Font = new Font("Arial", 8, FontStyle.Bold); 
                dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

                dataGridView1.Columns["TB_ID"].HeaderText = "ID";
                dataGridView1.Columns["TB_RECEIVERMAIL"].HeaderText = "RECEIVER EMAIL";
                dataGridView1.Columns["TB_LOCATION"].HeaderText = "LOCATION";
                dataGridView1.Columns["TB_TYPE"].HeaderText = "TYPE";
                dataGridView1.Columns["TB_RUNNO"].HeaderText = "REPORT NUMBER";

                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError("Error in Form2 :", ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.tB_MAILDETAILSTableAdapter.Fill(this.test01DataSet2.TB_MAILDETAILS);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                btn_send.Enabled = false;
                btn_deselectall.Enabled = false;
                btn_selectall.Enabled = false;
                btn_refresh.Enabled = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null && (bool)checkBoxCell.EditedFormattedValue)
                    {
                        int id = Convert.ToInt32(row.Cells["TB_ID"].Value);
                        string recipientEmail = row.Cells["TB_RECEIVERMAIL"].Value.ToString();
                       
                        await mailAppInstance.ProcessEmailAsync(recipientEmail, id);
                        btn_send.Enabled = true;
                        btn_deselectall.Enabled = true;
                        btn_selectall.Enabled = true;
                        btn_refresh.Enabled=true;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Unhandled exception in the application", ex);
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
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
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
                            dateTimePicker1.Value = DateTime.Now.Date;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError("Unhandled exception in the application", ex);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date; 

            try
            {
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
                {
                    connection.Open();
               
                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_TYPE, TB_RUNNO " +
                                   "FROM TB_MAILDETAILS " +
                                   "WHERE TB_STATUS = 0 AND CONVERT(DATE, TB_DATE) = @SelectedDate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

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
                Logger.LogError("Unhandled exception in the application", ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
