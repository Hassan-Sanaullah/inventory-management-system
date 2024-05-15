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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void round_button1_Click(object sender, EventArgs e)
        {
            

            //roundedPanel2.Visible = false;
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
        }
        private void newAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupBackground.Visible = true;
            loginBackground.Visible = false;
            registerPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginBackground.Visible = true;
            signupBackground.Visible = false;
            registerPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
