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
        private AccessDB dbAccess;
        public loginForm()
        {
            InitializeComponent();

            //DPI fix
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            // Initialize the AccessDB object
            dbAccess = new AccessDB();
            // Attach event handlers
            this.Load += MainForm_Load;
            this.FormClosed += MainForm_FormClosed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Open the database connection when the form loads
            dbAccess.OpenConnection();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the database connection when the form closes
            dbAccess.CloseConnection();
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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string email = registerEmailTB.Text;
            string password = registerPasswordTB.Text;
            string fName = firstNameTB.Text;
            string lName = lastNameTB.Text;
            string fullName = fName + " " + lName;

            string errorMessage;
            bool isRegistered = dbAccess.Register(email, password, fullName, out errorMessage);

            if (isRegistered)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed with your application logic
                object dummySender = null;
                LinkLabelLinkClickedEventArgs dummyEventArgs = new LinkLabelLinkClickedEventArgs(null); // You may need to pass appropriate LinkLabel.Link object here

                // Call loginLink_LinkClicked with the dummy arguments
                loginLink_LinkClicked(dummySender, dummyEventArgs);

            }
            else
            {
                MessageBox.Show("Registration failed: " + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string email;
        private void loginButton_Click(object sender, EventArgs e)
        {
            email = loginEmailTB.Text;
            string password = loginPasswordTB.Text;

            string errorMessage;
            (bool isValidUser, string role) = dbAccess.Login(email, password, out errorMessage);

            if (isValidUser)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Load different forms based on the role
                if (role == "admin")
                {
                    // Load admin form
                    adminForm adminForm = new adminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (role == "customer")
                {
                    // Load customer form
                    customerForm customerForm = new customerForm();
                    customerForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown role: " + role, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Login failed: " + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
