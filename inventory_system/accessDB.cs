using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace inventory_system
{
    public class AccessDB
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\VP project\\inventory_system\\database\\inventory_system.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection;

        public AccessDB()
        {
            // Initialize the SqlConnection object
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    // Open the database connection
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening database connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    // Close the database connection
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing database connection: " + ex.Message);
            }
        }

        public (bool isValidUser, string role) Login(string email, string password, out string errorMessage)
        {
            errorMessage = "";
            bool isValidUser = false;
            string role = "";

            try
            {
                OpenConnection();

                string query = "SELECT [role] FROM users WHERE email = @Email AND [password] = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isValidUser = true;
                            role = reader["role"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error during login: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return (isValidUser, role);
        }

        public bool Register(string email, string password, string fullName, out string errorMessage)
        {
            errorMessage = "";
            bool isRegistered = false;
            try
            {
                OpenConnection();
                string query = "INSERT INTO users (email, [password], full_name) VALUES (@Email, @Password, @FullName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FullName", fullName);
                int rowsAffected = command.ExecuteNonQuery();
                isRegistered = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                errorMessage = "Error during registration: " + ex.Message;
            }
            finally
            {
                //CloseConnection();
            }
            return isRegistered;
        }
        public Dictionary<string, object> GetSalesDataByDate(DateTime initialDate, out string errorMessage)
        {
            string date = initialDate.ToString("dd-MM-yy");
            errorMessage = "";
            Dictionary<string, object> salesData = new Dictionary<string, object>();
            SqlDataReader topSelling = null;

            try
            {
                OpenConnection();

                // Query 1: Total orders placed on the selected date
                string totalOrdersQuery = "SELECT COUNT(*) FROM orders WHERE FORMAT(order_date, 'dd-MM-yy') = @date";
                SqlCommand totalOrdersCommand = new SqlCommand(totalOrdersQuery, connection);
                totalOrdersCommand.Parameters.AddWithValue("@date", date);
                int totalOrders = (int)totalOrdersCommand.ExecuteScalar();
                salesData.Add("TotalOrders", totalOrders);

                // Query 2: Total revenue generated on the selected date
                string totalRevenueQuery = "SELECT SUM(total_amount) FROM orders WHERE FORMAT(order_date, 'dd-MM-yy') = @date";
                SqlCommand totalRevenueCommand = new SqlCommand(totalRevenueQuery, connection);
                totalRevenueCommand.Parameters.AddWithValue("@date", date);
                object totalRevenue = totalRevenueCommand.ExecuteScalar();
                salesData.Add("TotalRevenue", totalRevenue != DBNull.Value ? totalRevenue : 0);

                // Query 3: Total customers who placed orders on the selected date
                string totalCustomersQuery = "SELECT COUNT(DISTINCT user_id) FROM orders WHERE FORMAT(order_date, 'dd-MM-yy') = @date";
                SqlCommand totalCustomersCommand = new SqlCommand(totalCustomersQuery, connection);
                totalCustomersCommand.Parameters.AddWithValue("@date", date);
                int totalCustomers = (int)totalCustomersCommand.ExecuteScalar();
                salesData.Add("TotalCustomers", totalCustomers);

                // Query 4: Top 3 selling products on the selected date
                string topSellingQuery = @"
    SELECT TOP 3 p.name AS product_name 
    FROM order_items oi 
    JOIN products p ON oi.product_id = p.product_id 
    JOIN orders o ON oi.order_id = o.order_id 
    WHERE FORMAT(o.order_date, 'dd-MM-yy') = @date 
    GROUP BY p.name 
    ORDER BY SUM(oi.quantity) DESC";


                SqlCommand topSellingCommand = new SqlCommand(topSellingQuery, connection);
                topSellingCommand.Parameters.AddWithValue("@date", date);
                topSelling = topSellingCommand.ExecuteReader();
                string topProduct;
                int i = 0;
                while (topSelling.Read() && i < 3)
                {
                    topProduct = topSelling["product_name"].ToString();
                    salesData.Add("TopSelling" + i, topProduct);
                    i++;
                }
                // If less than 3 products, fill the remaining with empty strings
                for (; i < 3; i++)
                {
                    salesData.Add("TopSelling" + i, string.Empty);
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error fetching sales data: " + ex.Message;
            }
            finally
            {
                if (topSelling != null)
                {
                    topSelling.Close();
                }
                CloseConnection();
            }

            return salesData;
        }

        public Dictionary<DateTime, decimal> GetRevenueByDay(DateTime selectedDate, out string errorMessage)
        {
            errorMessage = "";
            Dictionary<DateTime, decimal> revenueByWeek = new Dictionary<DateTime, decimal>();

            try
            {
                OpenConnection();
                DateTime startDateOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek);

                // Loop through each day of the week (7 days)
                for (int i = 0; i < 7; i++)
                {
                    DateTime currentDate = startDateOfWeek.AddDays(i);
                    string formattedDate = currentDate.ToString("yyyy-MM-dd");

                    string dayRevenueQuery = "SELECT SUM(total_amount) FROM orders WHERE CONVERT(date, order_date) = @date";
                    SqlCommand dayRevenueCommand = new SqlCommand(dayRevenueQuery, connection);
                    dayRevenueCommand.Parameters.AddWithValue("@date", formattedDate);
                    object dayRevenue = dayRevenueCommand.ExecuteScalar();

                    revenueByWeek.Add(currentDate, dayRevenue != DBNull.Value ? Convert.ToDecimal(dayRevenue) : 0);
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error fetching revenue by week: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return revenueByWeek;
        }



        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("SELECT order_id, order_date, total_amount, order_status FROM orders", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId = reader.GetInt32(0);
                    order.OrderDate = reader.GetDateTime(1);
                    order.TotalAmount = reader.GetDecimal(2);
                    order.OrderStatus = reader.GetString(3);

                    orders.Add(order);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving orders: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return orders;
        }


        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("SELECT product_id, name, description, price, rating, color, image, stock_quantity FROM products", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = reader.GetInt32(0);
                    product.Name = reader.GetString(1);
                    product.Description = !reader.IsDBNull(2) ? reader.GetString(2) : null;
                    product.Price = reader.GetDecimal(3);
                    product.Rating = !reader.IsDBNull(4) ? (float)Convert.ToDouble(reader.GetValue(4)) : 0;
                    product.Color = !reader.IsDBNull(5) ? reader.GetString(5) : null;
                    product.Image = !reader.IsDBNull(6) ? (byte[])reader.GetValue(6) : null;
                    product.StockQuantity = reader.GetInt32(7);

                    products.Add(product);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving products: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return products;
        }


        public List<Product> FilterProducts(string productName, int productId, float minRating, decimal minPrice, decimal maxPrice)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    StringBuilder queryBuilder = new StringBuilder("SELECT product_id, name, description, price, rating, color, image, stock_quantity FROM products WHERE 1=1");

                    // Add filters based on user input
                    if (!string.IsNullOrEmpty(productName))
                    {
                        queryBuilder.Append(" AND name LIKE @productName");
                    }
                    if (productId > 0)
                    {
                        queryBuilder.Append(" AND product_id = @productId");
                    }
                    if (minRating > 0)
                    {
                        queryBuilder.Append(" AND rating >= @minRating");
                    }
                    if (minPrice >= 0 && maxPrice > 0 && minPrice <= maxPrice)
                    {
                        queryBuilder.Append(" AND price BETWEEN @minPrice AND @maxPrice");
                    }

                    using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                    {
                        // Add parameter values
                        if (!string.IsNullOrEmpty(productName))
                        {
                            command.Parameters.AddWithValue("@productName", "%" + productName + "%");
                        }
                        if (productId > 0)
                        {
                            command.Parameters.AddWithValue("@productId", productId);
                        }
                        if (minRating > 0)
                        {
                            command.Parameters.AddWithValue("@minRating", minRating);
                        }
                        if (minPrice >= 0 && maxPrice > 0 && minPrice <= maxPrice)
                        {
                            command.Parameters.AddWithValue("@minPrice", minPrice);
                            command.Parameters.AddWithValue("@maxPrice", maxPrice);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductId = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = !reader.IsDBNull(2) ? reader.GetString(2) : null,
                                    Price = !reader.IsDBNull(3) ? reader.GetDecimal(3) : 0,
                                    Rating = !reader.IsDBNull(4) ? Convert.ToSingle(reader.GetDouble(4)) : 0, // Convert to single
                                    Color = !reader.IsDBNull(5) ? reader.GetString(5) : null,
                                    Image = !reader.IsDBNull(6) ? (byte[])reader["image"] : null, // Assuming the image is stored as VARBINARY
                                    StockQuantity = reader.GetInt32(7)
                                };

                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log and handle the error
                Console.WriteLine("Error retrieving filtered products: " + ex.Message);
                throw; // Rethrow the exception for higher-level handling
            }

            return products;
        }


        public List<Order> FilterOrders( string orderStatus, int orderId, decimal minAmount, decimal maxAmount)
        {
            List<Order> orders = new List<Order>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    StringBuilder queryBuilder = new StringBuilder("SELECT order_id, order_date, total_amount, order_status FROM orders WHERE 1=1");

                    // Add filters based on user input
                    //if (orderDate != DateTime.MinValue)
                        //queryBuilder.Append(" AND CAST(order_date AS DATE) = @orderDate"); // Cast to DATE to compare only the date part
                    if (!string.IsNullOrEmpty(orderStatus))
                        queryBuilder.Append(" AND order_status = @orderStatus");
                    if (orderId > 0)
                        queryBuilder.Append(" AND order_id = @orderId");
                    if (minAmount >= 0 && maxAmount > 0 && minAmount <= maxAmount)
                        queryBuilder.Append(" AND total_amount BETWEEN @minAmount AND @maxAmount");

                    using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                    {
                        // Add parameter values
                        //if (orderDate != DateTime.MinValue)
                           // command.Parameters.AddWithValue("@orderDate", orderDate.Date); // Get only date portion
                        if (!string.IsNullOrEmpty(orderStatus))
                            command.Parameters.AddWithValue("@orderStatus", orderStatus);
                        if (orderId > 0)
                            command.Parameters.AddWithValue("@orderId", orderId);
                        if (minAmount >= 0 && maxAmount > 0 && minAmount <= maxAmount)
                        {
                            command.Parameters.AddWithValue("@minAmount", minAmount);
                            command.Parameters.AddWithValue("@maxAmount", maxAmount);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Order order = new Order();
                                order.OrderId = reader.GetInt32(0);
                                order.OrderDate = reader.GetDateTime(1);
                                order.TotalAmount = reader.GetDecimal(2);
                                order.OrderStatus = reader.GetString(3);

                                orders.Add(order);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log and handle the error
                Console.WriteLine("Error retrieving filtered orders: " + ex.Message);
                throw;
            }

            return orders;
        }


        public bool DeleteProduct(int productId, out string errorMessage)
        {
            errorMessage = "";
            bool isDeleted = false;
            try
            {
                OpenConnection();
                string query = "DELETE FROM products WHERE product_id = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);
                int rowsAffected = command.ExecuteNonQuery();
                isDeleted = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                errorMessage = "Error deleting product: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return isDeleted;
        }


        public bool AddProduct(string name, string description, decimal price, string category, int quantity, byte[] productImageBytes, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                OpenConnection();

                // Insert query
                string query = "INSERT INTO products (name, description, price, category, stock_quantity, image) " +
                               "VALUES (@Name, @Description, @Price, @Category, @Quantity, @Image)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Image", productImageBytes);

                    // Execute query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return true;
                    else
                    {
                        errorMessage = "Failed to add product.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding product: " + ex.Message;
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

       


    }



    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Rating { get; set; }
        public string Color { get; set; }
        public byte[] Image { get; set; }
        public int StockQuantity { get; set; }
    }

}
