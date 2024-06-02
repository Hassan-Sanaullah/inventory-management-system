using System;
using System.IO;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class addProductsForm : Form
    {
        AccessDB dbAccess = new AccessDB();
        private byte[] productImageBytes;

        public addProductsForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values from text boxes
                string name = tb1.Text;
                string description = tb2.Text;
                decimal price = Convert.ToDecimal(tb3.Text); // Assuming price is decimal
                string category = tb4.Text;
                int quantity = Convert.ToInt32(tb5.Text); // Assuming quantity is integer

                // Validate input if necessary

                // Check if an image is selected
                if (productImageBytes == null)
                {
                    MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call the method in AccessDB to add the product
                string errorMessage;
                bool success = dbAccess.AddProduct(name, description, price, category, quantity, productImageBytes, out errorMessage);

                if (success)
                {
                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear input fields if needed
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            adminForm adminForm = new adminForm();
            adminForm.FetchInventoryGridViewData();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the selected image file and convert it to bytes
                        string filePath = openFileDialog.FileName;
                        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            using (BinaryReader br = new BinaryReader(fs))
                            {
                                productImageBytes = br.ReadBytes((int)fs.Length);
                            }
                        }

                        // Display the selected image in PictureBox
                        pictureBox1.Image = System.Drawing.Image.FromFile(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading the image file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ClearInputFields()
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            productImageBytes = null;
        }
    }
}
