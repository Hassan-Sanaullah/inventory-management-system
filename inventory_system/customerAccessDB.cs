using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace inventory_system
{
    internal class customerAccessDB
    {   
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Documents\\VP project\\inventory_system\\database\\inventory_system.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection;

        public customerAccessDB()
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

        public int GetUserIdByEmail(string email, out string errorMessage)
        {

            errorMessage = "";
            int userId = -1;
            try
            {
                OpenConnection();
                string query = "SELECT user_id FROM users WHERE email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error retrieving user ID: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return userId;
        }

        public List<Product> GetProducts(out string errorMessage)
        {
            errorMessage = "";
            List<Product> products = new List<Product>();

            try
            {
                OpenConnection();
                string query = "SELECT * FROM products";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = Convert.ToInt32(reader["product_id"]),
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Price = reader["price"] != DBNull.Value ? Convert.ToDecimal(reader["price"]) : 0m,
                                Rating = reader["rating"] != DBNull.Value ? Convert.ToSingle(reader["rating"]) : 0f,
                                Color = reader["color"].ToString(),
                                Image = reader["image"] as byte[],
                                StockQuantity = Convert.ToInt32(reader["stock_quantity"])
                            };

                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error fetching products: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return products;
        }


        public DataTable GetUserOrders(int userId, out string errorMessage)
        {
            errorMessage = "";
            DataTable ordersTable = new DataTable();
            try
            {
                OpenConnection();
                string query = "SELECT * FROM orders WHERE user_id = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ordersTable);
            }
            catch (Exception ex)
            {
                errorMessage = "Error retrieving user orders: " + ex.Message;
            }
            finally
            {
                // CloseConnection();
            }
            return ordersTable;
        }

        public void AddToCart(int userId, int productId, int quantity, decimal unitPrice, out string errorMessage)
        {
            errorMessage = "";
            decimal totalPrice = quantity * unitPrice; // Calculate total price

            try
            {
                OpenConnection();
                string query = "INSERT INTO cart (user_id, product_id, quantity, unit_price, total_price) VALUES (@UserId, @ProductId, @Quantity, @UnitPrice, @TotalPrice)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice); // Pass calculated total price
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errorMessage = "Error adding product to cart: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<CartItem> GetCartItems(int userId, out string errorMessage)
        {
            errorMessage = "";
            List<CartItem> cartItems = new List<CartItem>();

            try
            {
                OpenConnection();
                string query = @"
            SELECT c.cart_id, c.user_id, c.product_id, c.quantity, c.unit_price, c.total_price, p.name, p.description, p.image 
            FROM cart c
            JOIN products p ON c.product_id = p.product_id
            WHERE c.user_id = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CartItem cartItem = new CartItem
                        {
                            CartId = Convert.ToInt32(reader["cart_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            ProductId = Convert.ToInt32(reader["product_id"]),
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            UnitPrice = Convert.ToDecimal(reader["unit_price"]),
                            TotalPrice = Convert.ToDecimal(reader["total_price"]),
                            ProductName = reader["name"].ToString(),
                            ProductDescription = reader["description"].ToString(),
                            ProductImage = reader["image"] as byte[]
                        };

                        cartItems.Add(cartItem);
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error retrieving cart items: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return cartItems;
        }


        public bool RemoveFromCart(int cartId, out string errorMessage)
        {
            errorMessage = "";
            bool isSuccess = false;

            try
            {
                OpenConnection();
                string query = "DELETE FROM cart WHERE cart_id = @CartId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CartId", cartId);

                int rowsAffected = command.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                errorMessage = "Error removing item from cart: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return isSuccess;
        }

        public bool Checkout(int userId, out string errorMessage)
        {
            errorMessage = "";
            bool isSuccess = false;

            try
            {
                OpenConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                // Insert into orders table
                string insertOrderQuery = "INSERT INTO orders (user_id, total_amount, order_date, order_status) OUTPUT INSERTED.order_id VALUES (@UserId, 0, GETDATE(), 'Pending')";
                SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection, transaction);
                insertOrderCommand.Parameters.AddWithValue("@UserId", userId);

                int orderId = (int)insertOrderCommand.ExecuteScalar();

                // Fetch all cart items for the user
                string selectCartItemsQuery = "SELECT * FROM cart WHERE user_id = @UserId";
                SqlCommand selectCartItemsCommand = new SqlCommand(selectCartItemsQuery, connection, transaction);
                selectCartItemsCommand.Parameters.AddWithValue("@UserId", userId);

                List<CartItem> cartItems = new List<CartItem>();
                using (SqlDataReader reader = selectCartItemsCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cartItems.Add(new CartItem
                        {
                            CartId = (int)reader["cart_id"],
                            ProductId = (int)reader["product_id"],
                            Quantity = (int)reader["quantity"],
                            UnitPrice = (decimal)reader["unit_price"],
                            TotalPrice = (decimal)reader["total_price"]
                        });
                    }
                }

                // Insert each cart item into order_items table and calculate total order amount
                decimal totalAmount = 0;
                foreach (CartItem item in cartItems)
                {
                    string insertOrderItemQuery = "INSERT INTO order_items (order_id, product_id, quantity, unit_price, total_price) VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice, @TotalPrice)";
                    SqlCommand insertOrderItemCommand = new SqlCommand(insertOrderItemQuery, connection, transaction);
                    insertOrderItemCommand.Parameters.AddWithValue("@OrderId", orderId);
                    insertOrderItemCommand.Parameters.AddWithValue("@ProductId", item.ProductId);
                    insertOrderItemCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                    insertOrderItemCommand.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                    insertOrderItemCommand.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);

                    insertOrderItemCommand.ExecuteNonQuery();
                    totalAmount += item.TotalPrice;
                }

                // Update the total_amount in orders table
                string updateOrderQuery = "UPDATE orders SET total_amount = @TotalAmount WHERE order_id = @OrderId";
                SqlCommand updateOrderCommand = new SqlCommand(updateOrderQuery, connection, transaction);
                updateOrderCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                updateOrderCommand.Parameters.AddWithValue("@OrderId", orderId);

                updateOrderCommand.ExecuteNonQuery();

                // Clear the cart for the user
                string clearCartQuery = "DELETE FROM cart WHERE user_id = @UserId";
                SqlCommand clearCartCommand = new SqlCommand(clearCartQuery, connection, transaction);
                clearCartCommand.Parameters.AddWithValue("@UserId", userId);

                clearCartCommand.ExecuteNonQuery();

                // Commit the transaction
                transaction.Commit();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                errorMessage = "Error during checkout: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }

            return isSuccess;
        }

        public List<Product> FilterProducts(string productName, int productId, float minRating, decimal priceMin, decimal priceMax, string category)
        {
            List<Product> filteredProducts = new List<Product>();
            try
            {
                OpenConnection();
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM products WHERE 1 = 1");

                // Add filters based on provided criteria
                if (!string.IsNullOrEmpty(productName))
                {
                    queryBuilder.Append(" AND name LIKE @ProductName");
                }

                if (productId > 0)
                {
                    queryBuilder.Append(" AND product_id = @ProductId");
                }

                if (!string.IsNullOrEmpty(category))
                {
                    queryBuilder.Append(" AND category = @Category");
                }

                queryBuilder.Append(" AND rating >= @MinRating");

                if (priceMin >= 0 && priceMax > 0 && priceMin <= priceMax)
                {
                    queryBuilder.Append(" AND price >= @MinPrice AND price <= @MaxPrice");
                }

                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);

                // Add parameters
                if (!string.IsNullOrEmpty(productName))
                {
                    command.Parameters.AddWithValue("@ProductName", "%" + productName + "%");
                }

                if (productId > 0)
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                }

                if (!string.IsNullOrEmpty(category))
                {
                    command.Parameters.AddWithValue("@Category", category);
                }

                command.Parameters.AddWithValue("@MinRating", minRating);

                if (priceMin >= 0 && priceMax > 0 && priceMin <= priceMax)
                {
                    command.Parameters.AddWithValue("@MinPrice", priceMin);
                    command.Parameters.AddWithValue("@MaxPrice", priceMax);
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            ProductId = Convert.ToInt32(reader["product_id"]),
                            Name = reader["name"].ToString(),
                            Description = reader["description"] != DBNull.Value ? reader["description"].ToString() : "",
                            Price = reader["price"] != DBNull.Value ? Convert.ToDecimal(reader["price"]) : 0m,
                            Rating = reader["rating"] != DBNull.Value ? Convert.ToSingle(reader["rating"]) : 0f,
                            Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : "",
                            Image = reader["image"] as byte[],
                            StockQuantity = reader["stock_quantity"] != DBNull.Value ? Convert.ToInt32(reader["stock_quantity"]) : 0
                        };

                        filteredProducts.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as logging or throwing
                MessageBox.Show("Error filtering products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return filteredProducts;
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

public class CartItem
{
    public int CartId { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public byte[] ProductImage { get; set; }
}