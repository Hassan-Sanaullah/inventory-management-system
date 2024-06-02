using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class productDetailsForm : Form
    {
        private Product product;

        public productDetailsForm(Product product)
        {
            this.product = product;
            InitializeComponent();
            DisplayProductDetails();
        }

        private void DisplayProductDetails()
        {
            this.Text = product.Name; // Set the form title to the product name

            // Set the picture box image
            pictureBox1.Image = ByteArrayToImage(product.Image);

            // Set the product details
            label0.Text = "Name: " + product.Name;
            label1.Text = "Description: " + product.Description;
            label2.Text = "Price: Rs. " + product.Price.ToString("F2");
            label3.Text = "Rating: " + product.Rating.ToString("F1");
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get user ID from your application's session or user authentication
            int userId = customerForm.userID; // Implement this method to get the logged-in user ID

            // Get product ID and other details from the form
            int productId = product.ProductId;
            int quantity = int.Parse(textBox1.Text); // Assuming txtQuantity is a TextBox for quantity input
            decimal unitPrice = product.Price;

            // Call the method to add the product to cart
            string errorMessage;
            customerAccessDB db = new customerAccessDB();
            db.AddToCart(userId, productId, quantity, unitPrice, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Product added to cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
