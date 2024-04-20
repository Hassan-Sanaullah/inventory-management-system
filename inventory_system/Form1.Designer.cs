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
            this.roundedPanel1 = new inventory_system.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.round_button3 = new ePOSOne.btnProduct.Round_button();
            this.ordersButton = new ePOSOne.btnProduct.Round_button();
            this.round_button1 = new ePOSOne.btnProduct.Round_button();
            this.roundedPanel2 = new inventory_system.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new inventory_system.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new inventory_system.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
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
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Location = new System.Drawing.Point(348, 242);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel1.TabIndex = 7;
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
            // round_button3
            // 
            this.round_button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.round_button3.BorderColor = System.Drawing.Color.Gray;
            this.round_button3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button3.Location = new System.Drawing.Point(884, 100);
            this.round_button3.Name = "round_button3";
            this.round_button3.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.round_button3.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button3.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.round_button3.Size = new System.Drawing.Size(168, 42);
            this.round_button3.TabIndex = 4;
            this.round_button3.Text = "Report";
            this.round_button3.TextColor = System.Drawing.Color.DarkGray;
            this.round_button3.UseVisualStyleBackColor = true;
            // 
            // ordersButton
            // 
            this.ordersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordersButton.BorderColor = System.Drawing.Color.Gray;
            this.ordersButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.Location = new System.Drawing.Point(645, 100);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.ordersButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ordersButton.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.ordersButton.Size = new System.Drawing.Size(168, 42);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Orders";
            this.ordersButton.TextColor = System.Drawing.Color.DarkGray;
            this.ordersButton.UseVisualStyleBackColor = true;
            // 
            // round_button1
            // 
            this.round_button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.round_button1.BorderColor = System.Drawing.Color.Gray;
            this.round_button1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.round_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button1.Location = new System.Drawing.Point(408, 100);
            this.round_button1.Name = "round_button1";
            this.round_button1.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.round_button1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.round_button1.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.round_button1.Size = new System.Drawing.Size(168, 42);
            this.round_button1.TabIndex = 2;
            this.round_button1.Text = "Inventory";
            this.round_button1.TextColor = System.Drawing.Color.DarkGray;
            this.round_button1.UseVisualStyleBackColor = true;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Location = new System.Drawing.Point(617, 242);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel2.TabIndex = 8;
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
            this.roundedPanel3.Controls.Add(this.label2);
            this.roundedPanel3.Location = new System.Drawing.Point(881, 242);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel3.TabIndex = 8;
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
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.roundedPanel4.Controls.Add(this.label4);
            this.roundedPanel4.Location = new System.Drawing.Point(1154, 242);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(228, 112);
            this.roundedPanel4.TabIndex = 8;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1442, 774);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.round_button3);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.round_button1);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Master";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currTime;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label currDate;
        private ePOSOne.btnProduct.Round_button round_button1;
        private ePOSOne.btnProduct.Round_button ordersButton;
        private ePOSOne.btnProduct.Round_button round_button3;
        private System.Windows.Forms.PictureBox logo;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label1;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label2;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label label4;
    }
}

