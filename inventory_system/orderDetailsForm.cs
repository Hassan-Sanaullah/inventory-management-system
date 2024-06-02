using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class orderDetailsForm : Form
    {
        private int orderId;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\VP project\\inventory_system\\database\\inventory_system.mdf\";Integrated Security=True;Connect Timeout=30";

        public orderDetailsForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void orderDetailsForm_Load(object sender, EventArgs e)
        {
            loadOrderDetails();
        }

        private void loadOrderDetails()
        {
            try
            {
                string errorMessage;
                DataTable orderItems = getOrderItems(orderId, out errorMessage);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (orderItems == null || orderItems.Rows.Count == 0)
                {
                    MessageBox.Show("No order items found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GridView.DataSource = orderItems;

                // Adjust column widths if necessary
                foreach (DataGridViewColumn column in GridView.Columns)
                {
                    column.Width = 120;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable getOrderItems(int orderId, out string errorMessage)
        {
            errorMessage = null;
            DataTable orderItemsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT oi.order_item_id, oi.product_id, p.name AS product_name, oi.quantity, oi.unit_price, oi.total_price 
                 FROM order_items oi
                 JOIN products p ON oi.product_id = p.product_id
                 WHERE oi.order_id = @orderId";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@orderId", orderId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(orderItemsTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return orderItemsTable;
        }
    }
}
