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
    public partial class Form3 : Form
    {
        private Timer timer;
        public Form3()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick;
            timer.Start();

            retaillable.Parent = mainimg;
            retaillable.BackColor = Color.Transparent;
            version.Parent = mainimg;
            version.BackColor = Color.Transparent;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
 

    }
}
