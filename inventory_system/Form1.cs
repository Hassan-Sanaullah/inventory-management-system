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

namespace inventory_system
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //code for time
            timer1.Start();
            //DPI fix
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            
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

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void round_button1_Click(object sender, EventArgs e)
        {
            inventoryPanel.Visible = true;
            inventorySidePanel.Visible = true;

            reportPanel.Visible = false;
            reportSidePanel.Visible = false;
            ordersPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }

        private void round_button3_Click(object sender, EventArgs e)
        {
            reportPanel.Visible = true;
            reportSidePanel.Visible = true;

            inventoryPanel.Visible = false;
            inventorySidePanel.Visible = false;
            ordersPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ordersPanel.Visible = true;
            ordersSidePanel.Visible = true;

            reportPanel.Visible = false;
            reportSidePanel.Visible = false;
            inventoryPanel.Visible = false;
            inventorySidePanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //changes cursor
            //string parentDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;
            //string cursorFilePath = Path.Combine(parentDirectory, "cursor.cur");
            //this.Cursor = new Cursor(cursorFilePath);
            //C:\Users\DELL\Documents\VP project\inventory_system\inventory_system\normal.cur

        }

        private void newOrder_button_Click(object sender, EventArgs e)
        {

        }
    }
}
