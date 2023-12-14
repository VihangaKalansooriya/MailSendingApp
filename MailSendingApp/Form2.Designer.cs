using System.Drawing;
using System.Windows.Forms;
using System;

namespace MailSendingApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.mailsending = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test01DataSet2 = new MailSendingApp.Test01DataSet2();
            this.tBMAILDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_MAILDETAILSTableAdapter = new MailSendingApp.Test01DataSet2TableAdapters.TB_MAILDETAILSTableAdapter();
            this.btn_send = new System.Windows.Forms.Button();
            this.logoimg = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_deselectall = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.maillogo = new System.Windows.Forms.PictureBox();
            this.receiveremail = new System.Windows.Forms.Label();
            this.receiver_txt = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btn_search = new System.Windows.Forms.Button();
            this.send_RB = new System.Windows.Forms.RadioButton();
            this.Unsend_RB = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.retaillable = new System.Windows.Forms.Label();
            this.test01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test01DataSet = new MailSendingApp.Test01DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMAILDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maillogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mailsending
            // 
            this.mailsending.AutoSize = true;
            this.mailsending.BackColor = System.Drawing.Color.Transparent;
            this.mailsending.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailsending.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mailsending.Location = new System.Drawing.Point(354, 48);
            this.mailsending.Name = "mailsending";
            this.mailsending.Size = new System.Drawing.Size(247, 23);
            this.mailsending.TabIndex = 1;
            this.mailsending.Text = "Mail Sending Application";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(50, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 170);
            this.dataGridView1.TabIndex = 2;
            // 
            // test01DataSet2
            // 
            this.test01DataSet2.DataSetName = "Test01DataSet2";
            this.test01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBMAILDETAILSBindingSource
            // 
            this.tBMAILDETAILSBindingSource.DataMember = "TB_MAILDETAILS";
            this.tBMAILDETAILSBindingSource.DataSource = this.test01DataSet2;
            // 
            // tB_MAILDETAILSTableAdapter
            // 
            this.tB_MAILDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Teal;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(738, 343);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 30);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // logoimg
            // 
            this.logoimg.Image = ((System.Drawing.Image)(resources.GetObject("logoimg.Image")));
            this.logoimg.Location = new System.Drawing.Point(405, -10);
            this.logoimg.Name = "logoimg";
            this.logoimg.Size = new System.Drawing.Size(111, 59);
            this.logoimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoimg.TabIndex = 11;
            this.logoimg.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(71, 109);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 19);
            this.date.TabIndex = 12;
            this.date.Text = "Date :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(129, 110);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_deselectall
            // 
            this.btn_deselectall.BackColor = System.Drawing.Color.Teal;
            this.btn_deselectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deselectall.Location = new System.Drawing.Point(290, 343);
            this.btn_deselectall.Name = "btn_deselectall";
            this.btn_deselectall.Size = new System.Drawing.Size(100, 30);
            this.btn_deselectall.TabIndex = 15;
            this.btn_deselectall.Text = "Deselect All";
            this.btn_deselectall.UseVisualStyleBackColor = false;
            this.btn_deselectall.Click += new System.EventHandler(this.btn_deselectall_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(517, 343);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_selectall
            // 
            this.btn_selectall.BackColor = System.Drawing.Color.Teal;
            this.btn_selectall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_selectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectall.Location = new System.Drawing.Point(81, 343);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(100, 30);
            this.btn_selectall.TabIndex = 19;
            this.btn_selectall.Text = "Select All";
            this.btn_selectall.UseVisualStyleBackColor = false;
            this.btn_selectall.Click += new System.EventHandler(this.btn_selectall_Click);
            // 
            // maillogo
            // 
            this.maillogo.Image = ((System.Drawing.Image)(resources.GetObject("maillogo.Image")));
            this.maillogo.Location = new System.Drawing.Point(313, 45);
            this.maillogo.Name = "maillogo";
            this.maillogo.Size = new System.Drawing.Size(46, 31);
            this.maillogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maillogo.TabIndex = 20;
            this.maillogo.TabStop = false;
            // 
            // receiveremail
            // 
            this.receiveremail.AutoSize = true;
            this.receiveremail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiveremail.Location = new System.Drawing.Point(526, 112);
            this.receiveremail.Name = "receiveremail";
            this.receiveremail.Size = new System.Drawing.Size(115, 19);
            this.receiveremail.TabIndex = 21;
            this.receiveremail.Text = "Receiver Email :";
            // 
            // receiver_txt
            // 
            this.receiver_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.receiver_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiver_txt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiver_txt.Location = new System.Drawing.Point(647, 111);
            this.receiver_txt.Name = "receiver_txt";
            this.receiver_txt.Size = new System.Drawing.Size(171, 22);
            this.receiver_txt.TabIndex = 22;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Location = new System.Drawing.Point(868, 417);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(41, 13);
            this.version.TabIndex = 23;
            this.version.Text = "V 1.0.0";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Location = new System.Drawing.Point(818, 110);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 24);
            this.btn_search.TabIndex = 26;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // send_RB
            // 
            this.send_RB.AutoSize = true;
            this.send_RB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_RB.Location = new System.Drawing.Point(330, 113);
            this.send_RB.Name = "send_RB";
            this.send_RB.Size = new System.Drawing.Size(51, 17);
            this.send_RB.TabIndex = 27;
            this.send_RB.TabStop = true;
            this.send_RB.Text = "Sent";
            this.send_RB.UseVisualStyleBackColor = true;
            // 
            // Unsend_RB
            // 
            this.Unsend_RB.AutoSize = true;
            this.Unsend_RB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unsend_RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unsend_RB.Location = new System.Drawing.Point(396, 113);
            this.Unsend_RB.Name = "Unsend_RB";
            this.Unsend_RB.Size = new System.Drawing.Size(68, 17);
            this.Unsend_RB.TabIndex = 28;
            this.Unsend_RB.TabStop = true;
            this.Unsend_RB.Text = "Unsend";
            this.Unsend_RB.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // retaillable
            // 
            this.retaillable.AutoSize = true;
            this.retaillable.BackColor = System.Drawing.Color.Transparent;
            this.retaillable.Location = new System.Drawing.Point(3, 417);
            this.retaillable.Name = "retaillable";
            this.retaillable.Size = new System.Drawing.Size(211, 13);
            this.retaillable.TabIndex = 32;
            this.retaillable.Text = "Copyright (c) 24x7 Retail Solutions (Pvt) Ltd";
            // 
            // test01DataSetBindingSource
            // 
            this.test01DataSetBindingSource.DataSource = this.test01DataSet;
            this.test01DataSetBindingSource.Position = 0;
            // 
            // test01DataSet
            // 
            this.test01DataSet.DataSetName = "Test01DataSet";
            this.test01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 434);
            this.Controls.Add(this.mailsending);
            this.Controls.Add(this.maillogo);
            this.Controls.Add(this.retaillable);
            this.Controls.Add(this.Unsend_RB);
            this.Controls.Add(this.send_RB);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.version);
            this.Controls.Add(this.receiver_txt);
            this.Controls.Add(this.receiveremail);
            this.Controls.Add(this.btn_selectall);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_deselectall);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.date);
            this.Controls.Add(this.logoimg);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Sending Application";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMAILDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maillogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeButtonDesign()
        {
            // Set initial btn_selectall design
            btn_selectall.BackColor = Color.White;
            btn_selectall.ForeColor = Color.Black;
            btn_selectall.Font = new Font("Arial", 9, FontStyle.Bold);
            btn_selectall.FlatStyle = FlatStyle.Flat;
            
            // Set initial btn_refresh design
            btn_refresh.BackColor = Color.White;
            btn_refresh.ForeColor = Color.Black;
            btn_refresh.Font = new Font("Arial", 9, FontStyle.Bold);
            btn_refresh.FlatStyle = FlatStyle.Flat;

            // Set initial btn_deselectall design
            btn_deselectall.BackColor = Color.White;
            btn_deselectall.ForeColor = Color.Black;
            btn_deselectall.Font = new Font("Arial", 9, FontStyle.Bold);
            btn_deselectall.FlatStyle = FlatStyle.Flat;

            // Set initial btn_send design
            btn_send.BackColor = Color.White;
            btn_send.ForeColor = Color.Black;
            btn_send.Font = new Font("Arial", 9, FontStyle.Bold);
            btn_send.FlatStyle = FlatStyle.Flat;

            // Subscribe to MouseEnter and MouseLeave events
            btn_selectall.MouseEnter += btn_selectall_MouseEnter;
            btn_selectall.MouseLeave += btn_selectall_MouseLeave;
            btn_refresh.MouseEnter += btn_refresh_MouseEnter;
            btn_refresh.MouseLeave += btn_refresh_MouseLeave;
            btn_deselectall.MouseEnter += btn_deselectall_MouseEnter;
            btn_deselectall.MouseLeave += btn_deselectall_MouseLeave;
            btn_send.MouseEnter += btn_send_MouseEnter;
            btn_send.MouseLeave += btn_send_MouseLeave;
        }

        private void btn_selectall_MouseEnter(object sender, EventArgs e)
        {
            btn_selectall.BackColor = Color.Blue;
        }

        private void btn_selectall_MouseLeave(object sender, EventArgs e)
        {
            btn_selectall.BackColor = Color.White;
        }

        private void btn_refresh_MouseEnter(object sender, EventArgs e)
        {
            btn_refresh.BackColor = Color.Blue;
        }

        private void btn_refresh_MouseLeave(object sender, EventArgs e)
        {
            btn_refresh.BackColor = Color.White;
        }

        private void btn_deselectall_MouseEnter(object sender, EventArgs e)
        {
            btn_deselectall.BackColor = Color.Blue;
        }

        private void btn_deselectall_MouseLeave(object sender, EventArgs e)
        {
            btn_deselectall.BackColor = Color.White;
        }

        private void btn_send_MouseEnter(object sender, EventArgs e)
        {
            btn_send.BackColor = Color.Blue;
        }

        private void btn_send_MouseLeave(object sender, EventArgs e)
        {
            btn_send.BackColor = Color.White;
        }
        

        #endregion

        private System.Windows.Forms.Label mailsending;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource test01DataSetBindingSource;
        private Test01DataSet test01DataSet;
        private Test01DataSet2 test01DataSet2;
        private System.Windows.Forms.BindingSource tBMAILDETAILSBindingSource;
        private Test01DataSet2TableAdapters.TB_MAILDETAILSTableAdapter tB_MAILDETAILSTableAdapter;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.PictureBox logoimg;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_deselectall;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_selectall;
        private PictureBox maillogo;
        private Label receiveremail;
        private TextBox receiver_txt;
        private Label version;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Button btn_search;
        private RadioButton send_RB;
        private RadioButton Unsend_RB;
        private ErrorProvider errorProvider1;
        private Label retaillable;
    }
}