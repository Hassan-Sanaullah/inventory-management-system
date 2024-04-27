using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

            //applies font
            ApplyCustomFontToForm(this);
            

        }

        //Adds custom font
        // Assuming you've added your custom font file to your project
        // and set its Build Action to "Content" and Copy to Output Directory to "Copy if newer"

        // Load the custom font from the file
        private void ApplyCustomFontToForm(Control control)
        {
            /*if (control.Name == "specificControlName") // Change "specificControlName" to the name of your specific control
            {
                control.Font = LoadCustomFont(14); // Set custom font size for the specific control
            }
            if (control is Button)
            {
                control.Font = LoadCustomFont(20); // Set font size to 14 for Buttons and Labels
            }
            else
            {
                control.Font = LoadCustomFont(12); // Set default font size to 12 for other controls
            }*/

            //remove the line below is the above conditions are applied
            control.Font = LoadCustomFont(12);
            foreach (Control childControl in control.Controls)
            {
                ApplyCustomFontToForm(childControl); // Recursively apply font to child controls
            }
        }

        private Font LoadCustomFont(float fontSize)
        {
            // Replace "path\to\your\custom\font.ttf" with the actual path to your custom font file
            string fontFileName = "Noyh-Bold.ttf";
            string pathToFontFile = Path.Combine(Application.StartupPath, fontFileName);
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile(pathToFontFile);
            return new Font(privateFontCollection.Families[0], fontSize);
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
    }
}
