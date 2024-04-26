using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //code for time
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //code for displaying time
            
            DateTime dateTime = DateTime.Now;
            TimeSpan time = dateTime.TimeOfDay;

            string formattedTime = dateTime.ToString("hh:mm tt");
            string formattedDate = dateTime.ToString("ddd MMM d");
            this.label1.Text = formattedTime.ToString();
            this.label2.Text = formattedDate.ToString();

        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

    }
}
