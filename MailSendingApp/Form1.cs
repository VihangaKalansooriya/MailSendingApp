using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSendingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_username.Text == "ADMIN" && tx_password.Text == "ADMIN")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is Invalid.");
                tx_username.Clear();
                tx_password.Clear();
                tx_username.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
