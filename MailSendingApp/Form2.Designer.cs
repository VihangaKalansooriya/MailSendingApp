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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test01DataSet = new MailSendingApp.Test01DataSet();
            this.test01DataSet2 = new MailSendingApp.Test01DataSet2();
            this.tBMAILDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_MAILDETAILSTableAdapter = new MailSendingApp.Test01DataSet2TableAdapters.TB_MAILDETAILSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.btn_deselectall = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMAILDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(245, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail Sending Application";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Coral;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(554, 316);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(98, 37);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(305, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btn_selectall
            // 
            this.btn_selectall.BackColor = System.Drawing.Color.Coral;
            this.btn_selectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectall.Location = new System.Drawing.Point(67, 316);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(98, 37);
            this.btn_selectall.TabIndex = 14;
            this.btn_selectall.Text = "Select All";
            this.btn_selectall.UseVisualStyleBackColor = false;
            this.btn_selectall.Click += new System.EventHandler(this.btn_selectall_Click);
            // 
            // btn_deselectall
            // 
            this.btn_deselectall.BackColor = System.Drawing.Color.Coral;
            this.btn_deselectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deselectall.Location = new System.Drawing.Point(231, 316);
            this.btn_deselectall.Name = "btn_deselectall";
            this.btn_deselectall.Size = new System.Drawing.Size(98, 37);
            this.btn_deselectall.TabIndex = 15;
            this.btn_deselectall.Text = "Deselect All";
            this.btn_deselectall.UseVisualStyleBackColor = false;
            this.btn_deselectall.Click += new System.EventHandler(this.btn_deselectall_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Coral;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(398, 316);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(98, 37);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 365);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_deselectall);
            this.Controls.Add(this.btn_selectall);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test01DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMAILDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource test01DataSetBindingSource;
        private Test01DataSet test01DataSet;
        private Test01DataSet2 test01DataSet2;
        private System.Windows.Forms.BindingSource tBMAILDETAILSBindingSource;
        private Test01DataSet2TableAdapters.TB_MAILDETAILSTableAdapter tB_MAILDETAILSTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_selectall;
        private System.Windows.Forms.Button btn_deselectall;
        private System.Windows.Forms.Button btn_refresh;
    }
}