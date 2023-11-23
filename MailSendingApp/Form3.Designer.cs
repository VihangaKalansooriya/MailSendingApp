using System.Drawing;

namespace MailSendingApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.mainimg = new System.Windows.Forms.PictureBox();
            this.retaillable = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainimg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainimg
            // 
            this.mainimg.Image = ((System.Drawing.Image)(resources.GetObject("mainimg.Image")));
            this.mainimg.Location = new System.Drawing.Point(0, 0);
            this.mainimg.Name = "mainimg";
            this.mainimg.Size = new System.Drawing.Size(450, 321);
            this.mainimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainimg.TabIndex = 0;
            this.mainimg.TabStop = false;
            // 
            // retaillable
            // 
            this.retaillable.AutoSize = true;
            this.retaillable.BackColor = System.Drawing.Color.White;
            this.retaillable.Location = new System.Drawing.Point(8, 299);
            this.retaillable.Name = "retaillable";
            this.retaillable.Size = new System.Drawing.Size(152, 13);
            this.retaillable.TabIndex = 1;
            this.retaillable.Text = "©24x7 Retail Solutions Pvt Ltd";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.MintCream;
            this.version.Location = new System.Drawing.Point(402, 299);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(41, 13);
            this.version.TabIndex = 2;
            this.version.Text = "V 1.0.0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.version);
            this.Controls.Add(this.retaillable);
            this.Controls.Add(this.mainimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox mainimg;
        private System.Windows.Forms.Label retaillable;
        private System.Windows.Forms.Label version;
    }
}