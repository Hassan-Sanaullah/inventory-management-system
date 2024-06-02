using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class profileForm : Form
    {
        customerAccessDB accessDB = new customerAccessDB();
        private int userId;

        public profileForm()
        {
            InitializeComponent();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            string errorMessage;
            this.userId = accessDB.GetUserIdByEmail(loginForm.email, out errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                LoadUserProfile(userId);
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserProfile(int userId)
        {
            string errorMessage;
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\VP project\\inventory_system\\database\\inventory_system.mdf\";Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    string query = "SELECT user_id, email, password, full_name, created_at FROM users WHERE user_id = @UserId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null && reader.Read())
                        {
                            label1.Text = "Full name: " + reader["full_name"].ToString();
                            label2.Text = "Email: " + reader["email"].ToString();
                            label4.Text = "Password: " + reader["password"].ToString();
                            label6.Text = "Created at: " + Convert.ToDateTime(reader["created_at"]).ToString("g"); // General date/time pattern (short date, short time)
                        }
                        else
                        {
                            MessageBox.Show("No data found for the user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error retrieving user profile: " + ex.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
