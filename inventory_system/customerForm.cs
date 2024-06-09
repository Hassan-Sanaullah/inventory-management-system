using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class customerForm : Form
    {

        private customerAccessDB accessDB = new customerAccessDB();
        public customerForm()
        {
            InitializeComponent();
            timer1.Start();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        //code for Cart button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadCartItems(userID);

            cartPanel.Visible = true;
            cartSidePanel.Visible = true;

            ordersPanel.Visible = false;
            productsFilterSidePanel.Visible = false;
            productsPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            DisplayProducts();

            productsFilterSidePanel.Visible = true;
            productsPanel.Visible = true;
            
            ordersPanel.Visible = false;
            ordersSidePanel.Visible = false;
            cartPanel.Visible = false;
            cartSidePanel.Visible = false;
        }
        private void ordersButton_Click(object sender, EventArgs e)
        {
            LoadUserOrders(userID);

            ordersPanel.Visible = true;
            ordersSidePanel.Visible = true;

            cartPanel.Visible = false;
            cartSidePanel.Visible = false;
            productsFilterSidePanel.Visible = false;
            productsPanel.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();
            loginForm LoginForm = new loginForm();

            // If loginForm is null or disposed, create a new instance
            if (LoginForm == null || LoginForm.IsDisposed)
            {
                LoginForm = new loginForm();
            }

            // Show the login form
            LoginForm.Show();
        }

        private void DisplayProducts()
        {
            try
            {
                customerAccessDB accessDB = new customerAccessDB();
                string errorMessage;
                List<Product> products = accessDB.GetProducts(out errorMessage); // Call the GetProducts method

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (products == null || products.Count == 0)
                {
                    MessageBox.Show("No products found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                productsFlowLayout.Controls.Clear(); // Clear existing controls

                foreach (Product product in products)
                {
                    Panel panel = new Panel
                    {
                        Width = 300,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    panel.Tag = product;

                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 100,
                        Image = ByteArrayToImage(product.Image),
                        Location = new Point(5, 5)
                    };
                    pictureBox.Click += (sender, e) => PictureBox_Click(sender, e, product);
                    panel.Controls.Add(pictureBox);

                    // Create labels for product details
                    System.Windows.Forms.Label nameLabel = new System.Windows.Forms.Label
                    {
                        Text = "Name: " + (product.Name ?? "N/A"),
                        Location = new Point(110, 5), // Adjust the location as needed
                        ForeColor = Color.White, // Set text color to white
                        AutoSize = true
                    };
                    panel.Controls.Add(nameLabel);

                    System.Windows.Forms.Label priceLabel = new System.Windows.Forms.Label
                    {
                        Text = "Price: Rs. " + (product.Price.ToString("F2") ?? "N/A"),
                        Location = new Point(110, 30), // Adjust the location as needed
                        ForeColor = Color.White, // Set text color to white
                        AutoSize = true
                    };
                    panel.Controls.Add(priceLabel);

                    

                    // Add the panel to the FlowLayoutPanel
                    productsFlowLayout.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e, Product product)
        {
            productDetailsForm detailsForm = new productDetailsForm(product);
            detailsForm.ShowDialog();
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void LoadUserOrders(int userId)
        {
            string errorMessage;
            DataTable userOrders = accessDB.GetUserOrders(userId, out errorMessage);
            if (userOrders != null && userOrders.Rows.Count > 0)
            {
                ordersGridView.DataSource = userOrders;
                // Set the width of each column to 210
                foreach (DataGridViewColumn column in ordersGridView.Columns)
                {
                    column.Width = 210;
                }
            }
            else
            {
                //MessageBox.Show("No orders found for this user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ordersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                int orderId = Convert.ToInt32(ordersGridView.Rows[e.RowIndex].Cells["order_id"].Value);
                OpenOrderDetailsForm(orderId);
            }
        }

        private void OpenOrderDetailsForm(int orderId)
        {
            // You can create an instance of your order details form and pass the orderId
            orderDetailsForm orderDetailsForm = new orderDetailsForm(orderId);
            orderDetailsForm.ShowDialog();
        }



        public void LoadCartItems(int userId)
        {
            string errorMessage;
            List<CartItem> cartItems = accessDB.GetCartItems(userId, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable cartTable = new DataTable();
            cartTable.Columns.Add("Cart ID", typeof(int));
            cartTable.Columns.Add("Product Name", typeof(string));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Unit Price", typeof(decimal));
            cartTable.Columns.Add("Total Price", typeof(decimal));
            decimal totalAmount = 0;

            foreach (CartItem item in cartItems)
            {
                cartTable.Rows.Add(item.CartId, item.ProductName, item.Quantity, item.UnitPrice, item.TotalPrice);
                totalAmount += item.TotalPrice;
            }

            cartGridView.DataSource = cartTable;

            // Set the width of each column to 210 pixels
            foreach (DataGridViewColumn column in cartGridView.Columns)
            {
                column.Width = 210;
            }

            totalLabel.Text = "Total: Rs. " + totalAmount.ToString("F2");
        }


        private void removeCartButton_Click(object sender, EventArgs e)
        {
            if (cartGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = cartGridView.SelectedRows[0].Index;
                int cartId = Convert.ToInt32(cartGridView.Rows[selectedRowIndex].Cells["Cart ID"].Value);

                string errorMessage;
                bool isRemoved = accessDB.RemoveFromCart(cartId, out errorMessage);

                if (isRemoved)
                {
                    MessageBox.Show("Item removed from cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCartItems(userID); // Refresh the cart items
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static int userID;
        private void customerForm_Load(object sender, EventArgs e)
        {
            string errorMessage;
            userID = accessDB.GetUserIdByEmail(loginForm.email, out errorMessage);
            DisplayProducts();
            LoadCartItems(userID);

            //int userID = accessDB.GetUserIdByEmail(loginForm.email, out errorMessage);
            LoadUserOrders(userID);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

            // Check if any of the TextBoxes are empty
            if (string.IsNullOrWhiteSpace(addressTB.Text) ||
    string.IsNullOrWhiteSpace(cardInfoTB1.Text) ||
     string.IsNullOrWhiteSpace(cardInfoTB2.Text) ||
     string.IsNullOrWhiteSpace(cardInfoTB3.Text) ||
     string.IsNullOrWhiteSpace(cardInfoTB4.Text))
            {
                MessageBox.Show("Please enter all credentials", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if addressTB is empty or if all card info text boxes are empty
            }

            // Check if the cart is empty
            string cartErrorMessage;
            var cartItems = accessDB.GetCartItems(userID, out cartErrorMessage);

            if (cartItems == null || cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to your cart before checking out.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the cart is empty
            }

            // Proceed with checkout if the cart is not empty
            string errorMessage;
            GenerateReceipt();
            bool isCheckoutSuccessful = accessDB.Checkout(userID, out errorMessage);

            if (isCheckoutSuccessful)
            {
                MessageBox.Show("Checkout successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCartItems(userID); // Refresh the cart items
                LoadUserOrders(userID); // Refresh the user orders
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReceipt()
        {
            try
            {
                // Retrieve the cart items from the DataGridView
                DataTable cartTable = (DataTable)cartGridView.DataSource;
                /*if (cartTable == null || cartTable.Rows.Count == 0)
                {
                    MessageBox.Show("Cart is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }*/

                // Create a StringBuilder to construct the receipt
                StringBuilder receipt = new StringBuilder();
                receipt.AppendLine("Receipt");
                receipt.AppendLine("Date: " + DateTime.Now.ToString("g"));
                receipt.AppendLine(new string('-', 70));
                receipt.AppendLine(string.Format("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10}", "Cart ID", "Product Name", "Quantity", "Unit Price", "Total Price"));
                receipt.AppendLine(new string('-', 70));

                // Add cart items to the receipt
                foreach (DataRow row in cartTable.Rows)
                {
                    receipt.AppendLine(string.Format("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10}",
                        row["Cart ID"],
                        row["Product Name"],
                        row["Quantity"],
                        row["Unit Price"],
                        row["Total Price"]));
                }

                // Add the total amount to the receipt
                decimal totalAmount = cartTable.AsEnumerable().Sum(row => row.Field<decimal>("Total Price"));
                receipt.AppendLine(new string('-', 70));
                receipt.AppendLine($"Total Amount: Rs. {totalAmount:F2}");

                // Save the receipt to a file
                string fileName = $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                File.WriteAllText(fileName, receipt.ToString());

                // Inform the user that the receipt was generated
                MessageBox.Show($"Receipt has been generated and saved as {fileName}.", "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void filter_button_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = textBox1.Text;
                decimal priceMax = numericUpDown1.Value;
                decimal priceMin = numericUpDown2.Value;
                int productId = 0;
                /*if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    productId = Convert.ToInt32(textBox1.Text);
                } */
                float minRating = (float)numericUpDown3.Value;
                string selectedCategory = comboBox1.SelectedItem?.ToString(); // Get the selected category

                // Call the FilterProducts method from customerAccessDB to get filtered products
                List<Product> filteredProducts = accessDB.FilterProducts(productName, productId, minRating, priceMin, priceMax, selectedCategory); // Pass the selected category

                // Clear existing controls in the flow layout panel
                productsFlowLayout.Controls.Clear();

                // Populate the flow layout panel with filtered products
                foreach (Product product in filteredProducts)
                {
                    Panel panel = new Panel
                    {
                        Width = 300,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    panel.Tag = product;

                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 100,
                        Image = ByteArrayToImage(product.Image),
                        Location = new Point(5, 5)
                    };
                    pictureBox.Click += (_sender, _e) => PictureBox_Click(_sender, _e, product);

                    panel.Controls.Add(pictureBox);

                    // Create labels for product details
                    System.Windows.Forms.Label nameLabel = new System.Windows.Forms.Label
                    {
                        Text = "Name: " + (product.Name ?? "N/A"),
                        Location = new Point(110, 5), // Adjust the location as needed
                        ForeColor = Color.White, // Set text color to white
                        AutoSize = true
                    };
                    panel.Controls.Add(nameLabel);

                    System.Windows.Forms.Label priceLabel = new System.Windows.Forms.Label
                    {
                        Text = "Price: Rs. " + (product.Price.ToString("F2") ?? "N/A"),
                        Location = new Point(110, 30), // Adjust the location as needed
                        ForeColor = Color.White, // Set text color to white
                        AutoSize = true
                    };
                    panel.Controls.Add(priceLabel);

                    // Add the panel to the FlowLayoutPanel
                    productsFlowLayout.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as displaying an error message
                MessageBox.Show("Error occurred while filtering inventory data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileForm ProfileForm = new profileForm();

            // If loginForm is null or disposed, create a new instance
            if (ProfileForm == null || ProfileForm.IsDisposed)
            {
                ProfileForm = new profileForm();
            }

            // Show the login form
            ProfileForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //code for displaying time

            DateTime dateTime = DateTime.Now;
            TimeSpan time = dateTime.TimeOfDay;

            string formattedTime = dateTime.ToString("hh:mm tt");
            string formattedDate = dateTime.ToString("ddd d MMM");
            this.currTime.Text = formattedTime.ToString();
            this.currDate.Text = formattedDate.ToString();
        }
    }
}
