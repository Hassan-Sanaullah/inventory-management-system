namespace inventory_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currTime = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currDate = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.accountToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSidePanel = new inventory_system.RoundedPanel();
            this.popularPanel = new inventory_system.RoundedPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reportButton = new ePOSOne.btnProduct.Round_button();
            this.ordersButton = new ePOSOne.btnProduct.Round_button();
            this.inventoryButton = new ePOSOne.btnProduct.Round_button();
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
            this.inventoryPanel = new inventory_system.RoundedPanel();
            this.ordersPanel = new inventory_system.RoundedPanel();
            this.ordersSidePanel = new inventory_system.RoundedPanel();
            this.inventorySidePanel = new inventory_system.RoundedPanel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.accountToolStrip.SuspendLayout();
            this.reportSidePanel.SuspendLayout();
            this.popularPanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currTime
            // 
            this.currTime.AutoSize = true;
            this.currTime.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.currTime.Location = new System.Drawing.Point(17, 7);
            this.currTime.Name = "currTime";
            this.currTime.Size = new System.Drawing.Size(43, 22);
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
            this.topPanel.Size = new System.Drawing.Size(1442, 36);
            this.topPanel.TabIndex = 1;
            // 
            // currDate
            // 
            this.currDate.AutoSize = true;
            this.currDate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.currDate.Location = new System.Drawing.Point(122, 7);
            this.currDate.Name = "currDate";
            this.currDate.Size = new System.Drawing.Size(39, 22);
            this.currDate.TabIndex = 1;
            this.currDate.Text = "Date";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 46);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(303, 96);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // accountToolStrip
            // 
            this.accountToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.accountToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountToolStrip.BackgroundImage")));
            this.accountToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.accountToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.accountToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accountToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.accountToolStrip.Location = new System.Drawing.Point(1322, 46);
            this.accountToolStrip.Name = "accountToolStrip";
            this.accountToolStrip.Padding = new System.Windows.Forms.Padding(10);
            this.accountToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.accountToolStrip.Size = new System.Drawing.Size(95, 47);
            this.accountToolStrip.TabIndex = 14;
            this.accountToolStrip.Text = "Account";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // reportSidePanel
            // 
            this.reportSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.reportSidePanel.Controls.Add(this.popularPanel);
            this.reportSidePanel.Location = new System.Drawing.Point(21, 212);
            this.reportSidePanel.Name = "reportSidePanel";
            this.reportSidePanel.Size = new System.Drawing.Size(279, 550);
            this.reportSidePanel.TabIndex = 11;
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
            this.popularPanel.Size = new System.Drawing.Size(228, 231);
            this.popularPanel.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label12.Location = new System.Drawing.Point(75, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "<data>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label11.Location = new System.Drawing.Point(75, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "<data>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label9.Location = new System.Drawing.Point(75, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "<data>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(31, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Top selling products";
            // 
            // reportButton
            // 
            this.reportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportButton.BorderColor = System.Drawing.Color.Gray;
            this.reportButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.reportButton.Location = new System.Drawing.Point(859, 100);
            this.reportButton.Name = "reportButton";
            this.reportButton.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.reportButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.reportButton.OnHoverTextColor = System.Drawing.Color.DarkGray;
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
            this.ordersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.Location = new System.Drawing.Point(620, 100);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.ordersButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.OnHoverTextColor = System.Drawing.Color.DarkGray;
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
            this.inventoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.inventoryButton.Location = new System.Drawing.Point(383, 100);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.inventoryButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.inventoryButton.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.inventoryButton.Size = new System.Drawing.Size(168, 42);
            this.inventoryButton.TabIndex = 2;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextColor = System.Drawing.Color.DarkGray;
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.round_button1_Click);
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
            this.reportPanel.Location = new System.Drawing.Point(321, 212);
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
            this.roundedPanel4.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(44, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "<data>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(44, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
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
            this.roundedPanel2.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label6.Location = new System.Drawing.Point(36, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "<data>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
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
            this.roundedPanel3.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label7.Location = new System.Drawing.Point(48, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "<data>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
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
            this.roundedPanel1.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(57, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "<data>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(57, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Today\'s sales";
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.inventoryPanel.Location = new System.Drawing.Point(321, 212);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(1109, 550);
            this.inventoryPanel.TabIndex = 10;
            // 
            // ordersPanel
            // 
            this.ordersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.ordersPanel.Location = new System.Drawing.Point(321, 212);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(1109, 550);
            this.ordersPanel.TabIndex = 9;
            // 
            // ordersSidePanel
            // 
            this.ordersSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ordersSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.ordersSidePanel.Location = new System.Drawing.Point(21, 212);
            this.ordersSidePanel.Name = "ordersSidePanel";
            this.ordersSidePanel.Size = new System.Drawing.Size(279, 550);
            this.ordersSidePanel.TabIndex = 13;
            // 
            // inventorySidePanel
            // 
            this.inventorySidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inventorySidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.inventorySidePanel.Location = new System.Drawing.Point(21, 212);
            this.inventorySidePanel.Name = "inventorySidePanel";
            this.inventorySidePanel.Size = new System.Drawing.Size(279, 550);
            this.inventorySidePanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1442, 774);
            this.Controls.Add(this.accountToolStrip);
            this.Controls.Add(this.reportSidePanel);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Master";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.accountToolStrip.ResumeLayout(false);
            this.accountToolStrip.PerformLayout();
            this.reportSidePanel.ResumeLayout(false);
            this.popularPanel.ResumeLayout(false);
            this.popularPanel.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

