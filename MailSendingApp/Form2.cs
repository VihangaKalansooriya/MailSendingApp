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
                HeaderText = "Select", 
                Name = "Select",
            };

            dataGridView1.Columns.Insert(0, checkBoxColumn); 
            dataGridView1.AllowUserToAddRows = false;
            dateTimePicker.MaxDate = DateTime.Now;

            try
            {
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_DESC, TB_RUNNO FROM M_TBLMAILDETAILS WHERE TB_STATUS=0";

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
                dataGridView1.Columns["TB_RECEIVERMAIL"].HeaderText = "Receiver Email";
                dataGridView1.Columns["TB_LOCATION"].HeaderText = "Location";
                dataGridView1.Columns["TB_DESC"].HeaderText = "Type";
                dataGridView1.Columns["TB_RUNNO"].HeaderText = "Report Number";

                dataGridView1.Columns["TB_ID"].Width = 50; 
                dataGridView1.Columns["TB_RECEIVERMAIL"].Width = 200;
                dataGridView1.Columns["TB_LOCATION"].Width = 100;
                dataGridView1.Columns["TB_DESC"].Width = 200;
                dataGridView1.Columns["TB_RUNNO"].Width = 120;

                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
            }
            catch (Exception ex)
            {
                Logger.LogError("Error in :", ex);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.tB_MAILDETAILSTableAdapter.Fill(this.test01DataSet2.TB_MAILDETAILS);

        }

        private void closeimg_Click(object sender, EventArgs e)
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
                    }
                }

                btn_send.Enabled = true;
                btn_deselectall.Enabled = true;
                btn_selectall.Enabled = true;
                btn_refresh.Enabled = true;
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_TYPE, TB_RUNNO FROM M_TBLMAILDETAILS WHERE TB_STATUS=0";
                    dateTimePicker.Value = DateTime.Now.Date;
                    send_RB.Checked = false;
                    Unsend_RB.Checked = false;
                    receiver_txt.Text = string.Empty;

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                            dateTimePicker.Value = DateTime.Now.Date;
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
            DateTime selectedDate = dateTimePicker.Value.Date; 

            try
            {
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
                {
                    connection.Open();
               
                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_TYPE, TB_RUNNO " +
                                   "FROM M_TBLMAILDETAILS " +
                                   "WHERE CONVERT(DATE, TB_DATE) = @SelectedDate";

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
                Logger.LogError("Unhandled exception in the application", ex);
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchText = receiver_txt.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(Globalconfig.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT TB_ID, TB_RECEIVERMAIL, TB_LOCATION, TB_TYPE, TB_RUNNO " +
                                   "FROM M_TBLMAILDETAILS " +
                                   "WHERE TB_STATUS = @Status AND TB_RECEIVERMAIL LIKE @SearchText " +
                                   "AND CONVERT(DATE, TB_DATE) = @SelectedDate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                        if (send_RB.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Status", 1); 
                        }
                        else if (Unsend_RB.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Status", 0); 
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Status", 0); 
                        }

                        cmd.Parameters.AddWithValue("@SelectedDate", dateTimePicker.Value.Date);

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
                Logger.LogError("Unhandled exception in the application", ex);
            }
        }

        private void minimizeimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }

}
