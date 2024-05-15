namespace inventory_system
{
    partial class adminForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currTime = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currDate = new System.Windows.Forms.Label();
            this.reportButton = new ePOSOne.btnProduct.Round_button();
            this.ordersButton = new ePOSOne.btnProduct.Round_button();
            this.inventoryButton = new ePOSOne.btnProduct.Round_button();
            this.inventoryPanel = new inventory_system.RoundedPanel();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.newOrder_button = new ePOSOne.btnProduct.Round_button();
            this.ordersPanel = new inventory_system.RoundedPanel();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.ordersSidePanel = new inventory_system.RoundedPanel();
            this.filter_button = new ePOSOne.btnProduct.Round_button();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderSearchLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.inventorySidePanel = new inventory_system.RoundedPanel();
            this.round_button2 = new ePOSOne.btnProduct.Round_button();
            this.inventoryStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inventoryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.inventorySearch = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inventoryPriceMax = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.inventoryPriceMin = new System.Windows.Forms.NumericUpDown();
            this.reportPanel = new inventory_system.RoundedPanel();
            this.roundedPanel4 = new inventory_system.RoundedPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new inventory_system.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new inventory_system.RoundedPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new inventory_system.RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportSidePanel = new inventory_system.RoundedPanel();
            this.roundedPanel5 = new inventory_system.RoundedPanel();
            this.popularPanel = new inventory_system.RoundedPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.accountToolStrip = new System.Windows.Forms.ToolStrip();
            this.accountToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.ordersSidePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.inventorySidePanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPriceMin)).BeginInit();
            this.reportPanel.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.reportSidePanel.SuspendLayout();
            this.popularPanel.SuspendLayout();
            this.accountToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currTime
            // 
            this.currTime.AutoSize = true;
            this.currTime.Font = new System.Drawing.Font("Noyh ", 11F);
            this.currTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.currTime.Location = new System.Drawing.Point(17, 7);
            this.currTime.Name = "currTime";
            this.currTime.Size = new System.Drawing.Size(45, 21);
            this.currTime.TabIndex = 0;
            this.currTime.Text = "Time";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.topPanel.Controls.Add(this.currDate);
            this.topPanel.Controls.Add(this.currTime);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1442, 37);
            this.topPanel.TabIndex = 1;
            // 
            // currDate
            // 
            this.currDate.AutoSize = true;
            this.currDate.Font = new System.Drawing.Font("Noyh ", 11F);
            this.currDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.currDate.Location = new System.Drawing.Point(122, 7);
            this.currDate.Name = "currDate";
            this.currDate.Size = new System.Drawing.Size(46, 21);
            this.currDate.TabIndex = 1;
            this.currDate.Text = "Date";
            // 
            // reportButton
            // 
            this.reportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportButton.BorderColor = System.Drawing.Color.Gray;
            this.reportButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Noyh ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.reportButton.Location = new System.Drawing.Point(859, 101);
            this.reportButton.Name = "reportButton";
            this.reportButton.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.reportButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.reportButton.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.reportButton.Size = new System.Drawing.Size(168, 42);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Report";
            this.reportButton.TextColor = System.Drawing.Color.DarkGray;
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.round_button3_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordersButton.BorderColor = System.Drawing.Color.Gray;
            this.ordersButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Font = new System.Drawing.Font("Noyh ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.Location = new System.Drawing.Point(619, 101);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.ordersButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.ordersButton.Size = new System.Drawing.Size(168, 42);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Orders";
            this.ordersButton.TextColor = System.Drawing.Color.DarkGray;
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryButton.BorderColor = System.Drawing.Color.Gray;
            this.inventoryButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.inventoryButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Noyh ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.inventoryButton.Location = new System.Drawing.Point(383, 101);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.inventoryButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.inventoryButton.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.inventoryButton.Size = new System.Drawing.Size(168, 42);
            this.inventoryButton.TabIndex = 2;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextColor = System.Drawing.Color.DarkGray;
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.round_button1_Click);
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.inventoryPanel.Controls.Add(this.inventoryDataGridView);
            this.inventoryPanel.Controls.Add(this.newOrder_button);
            this.inventoryPanel.Location = new System.Drawing.Point(321, 213);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(1109, 550);
            this.inventoryPanel.TabIndex = 10;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Location = new System.Drawing.Point(27, 111);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersWidth = 51;
            this.inventoryDataGridView.RowTemplate.Height = 24;
            this.inventoryDataGridView.Size = new System.Drawing.Size(1057, 424);
            this.inventoryDataGridView.TabIndex = 8;
            // 
            // newOrder_button
            // 
            this.newOrder_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newOrder_button.BorderColor = System.Drawing.Color.Gray;
            this.newOrder_button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.newOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder_button.Font = new System.Drawing.Font("Noyh ", 12F);
            this.newOrder_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.newOrder_button.Location = new System.Drawing.Point(915, 22);
            this.newOrder_button.Name = "newOrder_button";
            this.newOrder_button.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.newOrder_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.newOrder_button.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.newOrder_button.Size = new System.Drawing.Size(168, 42);
            this.newOrder_button.TabIndex = 7;
            this.newOrder_button.Text = "+ New order";
            this.newOrder_button.TextColor = System.Drawing.Color.DarkGray;
            this.newOrder_button.UseVisualStyleBackColor = true;
            this.newOrder_button.Click += new System.EventHandler(this.newOrder_button_Click);
            // 
            // ordersPanel
            // 
            this.ordersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.ordersPanel.Controls.Add(this.OrdersGridView);
            this.ordersPanel.Location = new System.Drawing.Point(321, 213);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(1109, 550);
            this.ordersPanel.TabIndex = 9;
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(27, 111);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(1057, 424);
            this.OrdersGridView.TabIndex = 6;
            // 
            // ordersSidePanel
            // 
            this.ordersSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ordersSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.ordersSidePanel.Controls.Add(this.filter_button);
            this.ordersSidePanel.Controls.Add(this.orderStatus);
            this.ordersSidePanel.Controls.Add(this.label15);
            this.ordersSidePanel.Controls.Add(this.dateTimePicker1);
            this.ordersSidePanel.Controls.Add(this.label14);
            this.ordersSidePanel.Controls.Add(this.label13);
            this.ordersSidePanel.Controls.Add(this.textBox1);
            this.ordersSidePanel.Controls.Add(this.orderSearchLabel);
            this.ordersSidePanel.Controls.Add(this.groupBox1);
            this.ordersSidePanel.Location = new System.Drawing.Point(21, 213);
            this.ordersSidePanel.Name = "ordersSidePanel";
            this.ordersSidePanel.Size = new System.Drawing.Size(279, 550);
            this.ordersSidePanel.TabIndex = 13;
            // 
            // filter_button
            // 
            this.filter_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_button.BorderColor = System.Drawing.Color.Gray;
            this.filter_button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Font = new System.Drawing.Font("Noyh ", 11F);
            this.filter_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.filter_button.Location = new System.Drawing.Point(49, 470);
            this.filter_button.Name = "filter_button";
            this.filter_button.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.filter_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.filter_button.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.filter_button.Size = new System.Drawing.Size(168, 42);
            this.filter_button.TabIndex = 9;
            this.filter_button.Text = "Filter";
            this.filter_button.TextColor = System.Drawing.Color.DarkGray;
            this.filter_button.UseVisualStyleBackColor = true;
            // 
            // orderStatus
            // 
            this.orderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderStatus.Font = new System.Drawing.Font("Noyh ", 11F);
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.orderStatus.Location = new System.Drawing.Point(26, 213);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(218, 28);
            this.orderStatus.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(22, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 21);
            this.label15.TabIndex = 7;
            this.label15.Text = "Order status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Noyh ", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 28);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(22, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "Order date";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(22, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Filter by";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Noyh ", 11F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Location = new System.Drawing.Point(26, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 28);
            this.textBox1.TabIndex = 3;
            // 
            // orderSearchLabel
            // 
            this.orderSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderSearchLabel.AutoSize = true;
            this.orderSearchLabel.Font = new System.Drawing.Font("Noyh ", 11F);
            this.orderSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.orderSearchLabel.Location = new System.Drawing.Point(22, 14);
            this.orderSearchLabel.Name = "orderSearchLabel";
            this.orderSearchLabel.Size = new System.Drawing.Size(62, 21);
            this.orderSearchLabel.TabIndex = 2;
            this.orderSearchLabel.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Font = new System.Drawing.Font("Noyh ", 11F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(21, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price range";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Noyh ", 11F);
            this.numericUpDown1.Location = new System.Drawing.Point(8, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 28);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(8, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "Maximum";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(8, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 21);
            this.label18.TabIndex = 14;
            this.label18.Text = "Minimum";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Noyh ", 11F);
            this.numericUpDown2.Location = new System.Drawing.Point(8, 138);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(218, 28);
            this.numericUpDown2.TabIndex = 13;
            // 
            // inventorySidePanel
            // 
            this.inventorySidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventorySidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.inventorySidePanel.Controls.Add(this.round_button2);
            this.inventorySidePanel.Controls.Add(this.inventoryStatus);
            this.inventorySidePanel.Controls.Add(this.label16);
            this.inventorySidePanel.Controls.Add(this.inventoryDateTimePicker);
            this.inventorySidePanel.Controls.Add(this.label19);
            this.inventorySidePanel.Controls.Add(this.label20);
            this.inventorySidePanel.Controls.Add(this.inventorySearch);
            this.inventorySidePanel.Controls.Add(this.label21);
            this.inventorySidePanel.Controls.Add(this.groupBox2);
            this.inventorySidePanel.Location = new System.Drawing.Point(21, 213);
            this.inventorySidePanel.Name = "inventorySidePanel";
            this.inventorySidePanel.Size = new System.Drawing.Size(279, 550);
            this.inventorySidePanel.TabIndex = 12;
            // 
            // round_button2
            // 
            this.round_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.round_button2.BorderColor = System.Drawing.Color.Gray;
            this.round_button2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_button2.Font = new System.Drawing.Font("Noyh ", 11F);
            this.round_button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button2.Location = new System.Drawing.Point(49, 470);
            this.round_button2.Name = "round_button2";
            this.round_button2.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.round_button2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button2.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.round_button2.Size = new System.Drawing.Size(168, 42);
            this.round_button2.TabIndex = 18;
            this.round_button2.Text = "Filter";
            this.round_button2.TextColor = System.Drawing.Color.DarkGray;
            this.round_button2.UseVisualStyleBackColor = true;
            // 
            // inventoryStatus
            // 
            this.inventoryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryStatus.Font = new System.Drawing.Font("Noyh ", 11F);
            this.inventoryStatus.FormattingEnabled = true;
            this.inventoryStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.inventoryStatus.Location = new System.Drawing.Point(26, 213);
            this.inventoryStatus.Name = "inventoryStatus";
            this.inventoryStatus.Size = new System.Drawing.Size(218, 28);
            this.inventoryStatus.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(22, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 21);
            this.label16.TabIndex = 15;
            this.label16.Text = "Order status";
            // 
            // inventoryDateTimePicker
            // 
            this.inventoryDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.inventoryDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.inventoryDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.inventoryDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.inventoryDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.inventoryDateTimePicker.Font = new System.Drawing.Font("Noyh ", 11F);
            this.inventoryDateTimePicker.Location = new System.Drawing.Point(26, 145);
            this.inventoryDateTimePicker.Name = "inventoryDateTimePicker";
            this.inventoryDateTimePicker.Size = new System.Drawing.Size(218, 28);
            this.inventoryDateTimePicker.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Location = new System.Drawing.Point(22, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 21);
            this.label19.TabIndex = 13;
            this.label19.Text = "Date added";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(22, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 21);
            this.label20.TabIndex = 12;
            this.label20.Text = "Filter by";
            // 
            // inventorySearch
            // 
            this.inventorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventorySearch.BackColor = System.Drawing.Color.White;
            this.inventorySearch.Font = new System.Drawing.Font("Noyh ", 11F);
            this.inventorySearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inventorySearch.Location = new System.Drawing.Point(26, 39);
            this.inventorySearch.Name = "inventorySearch";
            this.inventorySearch.Size = new System.Drawing.Size(218, 28);
            this.inventorySearch.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label21.Location = new System.Drawing.Point(22, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.inventoryPriceMax);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.inventoryPriceMin);
            this.groupBox2.Font = new System.Drawing.Font("Noyh ", 11F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(21, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 193);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price range";
            // 
            // inventoryPriceMax
            // 
            this.inventoryPriceMax.Location = new System.Drawing.Point(8, 64);
            this.inventoryPriceMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inventoryPriceMax.Name = "inventoryPriceMax";
            this.inventoryPriceMax.Size = new System.Drawing.Size(218, 28);
            this.inventoryPriceMax.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(8, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 21);
            this.label22.TabIndex = 12;
            this.label22.Text = "Maximum";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label23.Location = new System.Drawing.Point(8, 107);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 21);
            this.label23.TabIndex = 14;
            this.label23.Text = "Minimum";
            // 
            // inventoryPriceMin
            // 
            this.inventoryPriceMin.Location = new System.Drawing.Point(8, 138);
            this.inventoryPriceMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inventoryPriceMin.Name = "inventoryPriceMin";
            this.inventoryPriceMin.Size = new System.Drawing.Size(218, 28);
            this.inventoryPriceMin.TabIndex = 13;
            // 
            // reportPanel
            // 
            this.reportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.reportPanel.Controls.Add(this.roundedPanel4);
            this.reportPanel.Controls.Add(this.roundedPanel2);
            this.reportPanel.Controls.Add(this.roundedPanel3);
            this.reportPanel.Controls.Add(this.roundedPanel1);
            this.reportPanel.Location = new System.Drawing.Point(321, 213);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1109, 550);
            this.reportPanel.TabIndex = 9;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel4.Controls.Add(this.label8);
            this.roundedPanel4.Controls.Add(this.label4);
            this.roundedPanel4.Location = new System.Drawing.Point(846, 29);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(229, 112);
            this.roundedPanel4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(43, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "<data>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(43, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Today\'s customers";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Location = new System.Drawing.Point(309, 29);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(229, 112);
            this.roundedPanel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label6.Location = new System.Drawing.Point(37, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "<data>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s total orders";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel3.Controls.Add(this.label7);
            this.roundedPanel3.Controls.Add(this.label2);
            this.roundedPanel3.Location = new System.Drawing.Point(573, 29);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(229, 112);
            this.roundedPanel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label7.Location = new System.Drawing.Point(48, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "<data>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Today\'s revenue";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Location = new System.Drawing.Point(40, 29);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(229, 112);
            this.roundedPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(57, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "<data>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(57, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Today\'s sales";
            // 
            // reportSidePanel
            // 
            this.reportSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.reportSidePanel.Controls.Add(this.roundedPanel5);
            this.reportSidePanel.Controls.Add(this.popularPanel);
            this.reportSidePanel.Location = new System.Drawing.Point(21, 213);
            this.reportSidePanel.Name = "reportSidePanel";
            this.reportSidePanel.Size = new System.Drawing.Size(279, 550);
            this.reportSidePanel.TabIndex = 11;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel5.Location = new System.Drawing.Point(29, 283);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(229, 241);
            this.roundedPanel5.TabIndex = 9;
            // 
            // popularPanel
            // 
            this.popularPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.popularPanel.Controls.Add(this.label12);
            this.popularPanel.Controls.Add(this.label11);
            this.popularPanel.Controls.Add(this.label9);
            this.popularPanel.Controls.Add(this.label10);
            this.popularPanel.Location = new System.Drawing.Point(26, 29);
            this.popularPanel.Name = "popularPanel";
            this.popularPanel.Size = new System.Drawing.Size(229, 231);
            this.popularPanel.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label12.Location = new System.Drawing.Point(75, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "<data>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label11.Location = new System.Drawing.Point(75, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "<data>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label9.Location = new System.Drawing.Point(75, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "<data>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noyh ", 11F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(31, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Top selling products";
            // 
            // accountToolStrip
            // 
            this.accountToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.accountToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountToolStrip.BackgroundImage")));
            this.accountToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.accountToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.accountToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accountToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripDropDownButton});
            this.accountToolStrip.Location = new System.Drawing.Point(1340, 46);
            this.accountToolStrip.Name = "accountToolStrip";
            this.accountToolStrip.Padding = new System.Windows.Forms.Padding(10);
            this.accountToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.accountToolStrip.Size = new System.Drawing.Size(56, 47);
            this.accountToolStrip.TabIndex = 14;
            this.accountToolStrip.Text = "Account";
            // 
            // accountToolStripDropDownButton
            // 
            this.accountToolStripDropDownButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.accountToolStripDropDownButton.BackColor = System.Drawing.Color.Transparent;
            this.accountToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.accountToolStripDropDownButton.Name = "accountToolStripDropDownButton";
            this.accountToolStripDropDownButton.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.accountToolStripDropDownButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountToolStripDropDownButton.ShowDropDownArrow = false;
            this.accountToolStripDropDownButton.Size = new System.Drawing.Size(34, 24);
            this.accountToolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 46);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(303, 96);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1442, 774);
            this.Controls.Add(this.accountToolStrip);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.inventoryPanel);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.ordersSidePanel);
            this.Controls.Add(this.inventorySidePanel);
            this.Controls.Add(this.reportSidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.inventoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ordersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ordersSidePanel.ResumeLayout(false);
            this.ordersSidePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.inventorySidePanel.ResumeLayout(false);
            this.inventorySidePanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPriceMin)).EndInit();
            this.reportPanel.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.reportSidePanel.ResumeLayout(false);
            this.popularPanel.ResumeLayout(false);
            this.popularPanel.PerformLayout();
            this.accountToolStrip.ResumeLayout(false);
            this.accountToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currTime;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label currDate;
        private ePOSOne.btnProduct.Round_button inventoryButton;
        private ePOSOne.btnProduct.Round_button ordersButton;
        private ePOSOne.btnProduct.Round_button reportButton;
        private System.Windows.Forms.PictureBox logo;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label1;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label2;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RoundedPanel reportPanel;
        private RoundedPanel inventoryPanel;
        private RoundedPanel ordersPanel;
        private RoundedPanel reportSidePanel;
        private RoundedPanel inventorySidePanel;
        private RoundedPanel ordersSidePanel;
        private RoundedPanel popularPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip accountToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton accountToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Label orderSearchLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private ePOSOne.btnProduct.Round_button filter_button;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private ePOSOne.btnProduct.Round_button newOrder_button;
        private ePOSOne.btnProduct.Round_button round_button2;
        private System.Windows.Forms.ComboBox inventoryStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker inventoryDateTimePicker;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox inventorySearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown inventoryPriceMax;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown inventoryPriceMin;
        private RoundedPanel roundedPanel5;
    }
}

