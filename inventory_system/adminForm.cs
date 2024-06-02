using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ZXing;

namespace inventory_system
{
    public partial class adminForm : Form
    {
        private AccessDB dbAccess;
        public adminForm()
        {
            InitializeComponent();
            //code for time
            timer1.Start();
            //DPI fix
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            // Initialize the AccessDB object
            dbAccess = new AccessDB();
            // Attach event handlers
            this.Load += MainForm_Load;
            this.FormClosed += MainForm_FormClosed;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            customerAccessDB accessDB = new customerAccessDB();

            FetchInventoryGridViewData();
            FetchOrdersGridViewData();
            //string errorMessage;
            //userID = accessDB.GetUserIdByEmail(loginForm.email, out errorMessage);

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
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


        //code to fix DPI issue
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
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


        private void inventoryButton_Click(object sender, EventArgs e)
        {
            FetchInventoryGridViewData();

            inventoryPanel.Visible = true;
            inventorySidePanel.Visible = true;

            reportPanel.Visible = false;
            reportSidePanel.Visible = false;
            ordersPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            //FetchTodaySalesData();

            reportPanel.Visible = true;
            reportSidePanel.Visible = true;

            inventoryPanel.Visible = false;
            inventorySidePanel.Visible = false;
            ordersPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            FetchOrdersGridViewData();

            ordersPanel.Visible = true;
            ordersSidePanel.Visible = true;

            reportPanel.Visible = false;
            reportSidePanel.Visible = false;
            inventoryPanel.Visible = false;
            inventorySidePanel.Visible = false;
        }

        //public static int userID;
        

        private void newOrder_button_Click(object sender, EventArgs e)
        {
            // Hide current form
            //this.Hide();
            addProductsForm addProductsForm = new addProductsForm();

            // If loginForm is null or disposed, create a new instance
            if (addProductsForm == null || addProductsForm.IsDisposed)
            {
                addProductsForm = new addProductsForm();
            }

            // Show the login form
            addProductsForm.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide current form
            //this.Hide();
            profileForm ProfileForm = new profileForm();

            // If loginForm is null or disposed, create a new instance
            if (ProfileForm == null || ProfileForm.IsDisposed)
            {
                ProfileForm = new profileForm();
            }

            // Show the login form
            ProfileForm.Show();
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

        private void FetchSalesDataForDate(DateTime selectedDate)
        {
            string errorMessage;
            Dictionary<string, object> salesData = dbAccess.GetSalesDataByDate(selectedDate, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                // Handle error, display error message, log it, etc.
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display the fetched sales data in your WinForms application
            int totalOrders = (int)salesData["TotalOrders"];
            int totalCustomers = (int)salesData["TotalCustomers"];

            // Handle totalRevenue conversion gracefully
            decimal totalRevenue = 0; // Default value
            if (salesData["TotalRevenue"] != null && salesData["TotalRevenue"] != DBNull.Value)
            {
                totalRevenue = Convert.ToDecimal(salesData["TotalRevenue"]);
            }

            string[] topSelling = new string[3];
            for (int i = 0; i < 3; i++)
            {
                topSelling[i] = salesData["TopSelling" + i] != null ? (string)salesData["TopSelling" + i] : string.Empty;
            }

            // Update the UI controls
            label6.Text = totalOrders.ToString();
            label7.Text = "Rs. " + totalRevenue.ToString("F2"); // Format as currency
            label8.Text = totalCustomers.ToString();
            label9.Text = topSelling[0];
            label11.Text = topSelling[1];
            label12.Text = topSelling[2];

            // Fetch and display chart data
            Dictionary<DateTime, decimal> revenueByDay = dbAccess.GetRevenueByDay(selectedDate, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                // Handle error, display error message, log it, etc.
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chart1.Series.Clear();
            chart1.Series.Add("Total Revenue");

            // Change label colors
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chart1.Series["Total Revenue"].Points.Clear();
            foreach (KeyValuePair<DateTime, decimal> entry in revenueByDay)
            {
                chart1.Series["Total Revenue"].Points.AddXY(entry.Key, (double)entry.Value);
            }
        }

        private void setReportDateButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            FetchSalesDataForDate(selectedDate);
        }


        private void FetchOrdersGridViewData()
        {
            try
            {
                List<Order> orders = dbAccess.GetAllOrders();

                // Clear existing data in DataGridView
                OrdersGridView.Rows.Clear();
                // Add orders to DataGridView
                foreach (var order in orders)
                {
                    OrdersGridView.Rows.Add(order.OrderId, order.OrderDate, order.TotalAmount, order.OrderStatus);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FetchInventoryGridViewData()
        {
            try
            {
                List<Product> products = dbAccess.GetAllProducts();

                // Clear existing data in DataGridView
                inventoryGridView.Rows.Clear();

                
                // Add products to DataGridView
                foreach (var product in products)
                {
               
                    inventoryGridView.Rows.Add(product.ProductId, product.Name, product.Price, product.Rating, product.StockQuantity);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InventoryGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the mouse is over the first column and the row index is valid
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                // Get the cell value
                var cellValue = inventoryGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Check if the cell value is not null
                if (cellValue != null)
                {
                    // Display the product barcode
                    var barcodeWriter = new BarcodeWriter
                    {
                        Format = BarcodeFormat.CODE_128, // Choose the barcode format here
                        Options = new ZXing.Common.EncodingOptions
                        {
                            Width = barcodePictureBox.Width,
                            Height = barcodePictureBox.Height,
                            Margin = 2
                        }
                    };

                    using (var bitmap = barcodeWriter.Write(cellValue.ToString()))
                    {
                        barcodePictureBox.Image = new Bitmap(bitmap);
                    }

                    barcodePictureBox.Visible = true;
                }
                else
                {
                }
            }
            else
            {
                barcodePictureBox.Visible = false;
            }
        }

        private void filterInventoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = inventorySearch.Text;
                decimal priceMax = inventoryPriceMax.Value;
                decimal priceMin = inventoryPriceMin.Value;
                int productId = 0;
                if (!string.IsNullOrWhiteSpace(inventoryIDSearch.Text))
                {
                    productId = Convert.ToInt32(inventoryIDSearch.Text); // Add product ID filter if textbox is not empty
                }
                //int productId = Convert.ToInt32(inventoryIDSearch.Text); // Add product ID filter
                float minRating = (float)inventoryRating.Value; // Retrieve minimum rating from NumericUpDown

                List<Product> filteredProducts = dbAccess.FilterProducts(productName, productId, minRating, priceMin, priceMax);

                inventoryGridView.Rows.Clear();

                foreach (var product in filteredProducts)
                {
                    inventoryGridView.Rows.Add(product.ProductId, product.Name, product.Price, product.Rating, product.StockQuantity);
                }
            }
            catch (Exception ex)
            {
                //ShowFriendlyErrorMessage("Error occurred while filtering inventory data.", ex);
            }
        }

        private void ordersFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DateTime orderDate = ordersDate.Value.Date;
                string orderStatus = ordersStatus.Text;
                decimal maxAmount = ordersMax.Value;
                decimal minAmount = ordersMin.Value;
                int orderId = 0;
                if (!string.IsNullOrWhiteSpace(ordersSearch.Text))
                {
                    orderId = Convert.ToInt32(ordersSearch.Text); // Add order ID filter if textbox is not empty
                }

                List<Order> filteredOrders = dbAccess.FilterOrders( orderStatus, orderId, minAmount, maxAmount);

                OrdersGridView.Rows.Clear();

                foreach (var order in filteredOrders)
                {
                    OrdersGridView.Rows.Add(order.OrderId, order.OrderDate, order.TotalAmount, order.OrderStatus);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.SelectedRows.Count > 0)
            {
                // Get the selected product's ID from the DataGridView
                int productId = Convert.ToInt32(inventoryGridView.SelectedRows[0].Cells["dataGridViewTextBoxColumn6"].Value);

                // Call the method to delete the product
                string errorMessage;
                if (dbAccess.DeleteProduct(productId, out errorMessage))
                {
                    MessageBox.Show("Product deleted successfully.");
                    // Refresh the DataGridView or update your product list
                }
                else
                {
                    MessageBox.Show("Failed to delete product: " + errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void ordersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                int orderId = Convert.ToInt32(OrdersGridView.Rows[e.RowIndex].Cells["Column1"].Value);
                OpenOrderDetailsForm(orderId);
            }
        }

        private void OpenOrderDetailsForm(int orderId)
        {
            // You can create an instance of your order details form and pass the orderId
            orderDetailsForm orderDetailsForm = new orderDetailsForm(orderId);
            orderDetailsForm.ShowDialog();
        }

        private void inventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row and cell are clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the product ID from the clicked row
                int productId = Convert.ToInt32(inventoryGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value);

                // Display the product details form with the selected product ID
                ShowProductDetailsForm(productId);
            }
        }

        private void ShowProductDetailsForm(int productId)
        {
            // Create an instance of the product details form
            //productDetailsForm2 productDetailsForm = new productDetailsForm(productId);

            // Show the product details form
            //productDetailsForm.ShowDialog();
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            // Capture the panel
            Bitmap bmp = new Bitmap(reportPanel.Width, reportPanel.Height);
            reportPanel.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, reportPanel.Width, reportPanel.Height));

            // Save as JPG
            bmp.Save("report.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Optionally, show a message to confirm the save
            MessageBox.Show("Report saved");
        }
    }
}
