using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void CODradio_CheckedChanged(object sender, EventArgs e)
        {
            addressLabel.Visible = true;
            addressTB.Visible = true;

            cardInfoLabel1.Visible = false;
            cardInfoTB1.Visible = false;
            cardInfoLabel2.Visible = false;
            cardInfoTB2.Visible = false;
            cardInfoLabel3.Visible = false;
            cardInfoTB3.Visible = false;
            cardInfoLabel4.Visible = false;
            cardInfoTB4.Visible = false;
        }

        private void creditCardRadio_CheckedChanged(object sender, EventArgs e)
        {
            addressLabel.Visible = false;
            addressTB.Visible = false;

            cardInfoLabel1.Visible = true;
            cardInfoTB1.Visible = true;
            cardInfoLabel2.Visible = true;
            cardInfoTB2.Visible = true;
            cardInfoLabel3.Visible = true;
            cardInfoTB3.Visible = true;
            cardInfoLabel4.Visible = true;
            cardInfoTB4.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cartPanel.Visible = true;
            cartSidePanel.Visible = true;

            home.Visible = false;
            ordersPanel.Visible = false;
            productsFilterSidePanel.Visible = false;
            productsPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }

        int timerCounter = 0;
        private void slideShowTimer_Tick(object sender, EventArgs e)
        {

            string imagesFolder = Path.Combine(Path.GetDirectoryName(Application.StartupPath), "..", "images", "product_slideshow");
            string[] imagePaths = Directory.GetFiles(imagesFolder, "*.jpg");


            if (timerCounter < 4 && home.Visible == true)
            {
                slideShowPictureBox.Image = Image.FromFile(imagePaths[timerCounter]);
                //slideShowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                timerCounter++;
            }
            else
            {
                timerCounter = 0;
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            home.Visible = true;

            cartPanel.Visible = false;
            cartSidePanel.Visible = false;
            productsFilterSidePanel.Visible = false;
            productsPanel.Visible = false;
            ordersPanel.Visible = false;
            ordersSidePanel.Visible = false;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ordersPanel.Visible = true;
            ordersSidePanel.Visible = true;

            home.Visible = false;
            cartPanel.Visible = false;
            cartSidePanel.Visible = false;
            productsFilterSidePanel.Visible = false;
            productsPanel.Visible = false;
        }

        private void categoriesDropDown_Show(object sender, EventArgs e)
        {
            categoriesDropDown.Visible = true;      
        }
        private void categoriesDropDown_Hide(object sender, EventArgs e)
        {
            categoriesDropDown.Visible = false;
        }

        private void categoriesButton_MouseLeave(object sender, EventArgs e)
        {
            //gets cursor coordinates
            Point formCoordinates = this.PointToClient(Cursor.Position);
            int formY = formCoordinates.Y;
            //checks is cursor leaves button but is outside categories drop down panel
            if (formY < 120)
            {
                categoriesDropDown.Visible = false;
                
            }
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
    }
}
