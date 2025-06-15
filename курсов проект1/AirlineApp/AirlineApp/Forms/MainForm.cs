using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Home menu";
            this.BackColor = Color.LightSkyBlue;
            this.StartPosition = FormStartPosition.CenterScreen;

           

          
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.Width = 600;
            pictureBoxLogo.Height = 400;
            pictureBoxLogo.Top = labelTitle.Bottom + 30;
            pictureBoxLogo.Left = (this.ClientSize.Width - pictureBoxLogo.Width) / 2;

            
            int buttonWidth = 300;
            int buttonHeight = 70;
            int centerX = (this.ClientSize.Width - buttonWidth) / 2;
            int startY = pictureBoxLogo.Bottom + 40;

            btnAirlines.Width = buttonWidth;
            btnAirlines.Height = buttonHeight;
            btnAirlines.Left = centerX;
            btnAirlines.Top = startY;
            btnAirlines.BackColor = Color.DeepSkyBlue;
            btnAirlines.ForeColor = Color.White;
            btnAirlines.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            btnFlights.Width = buttonWidth;
            btnFlights.Height = buttonHeight;
            btnFlights.Left = centerX;
            btnFlights.Top = btnAirlines.Bottom + 20;
            btnFlights.BackColor = Color.MediumSlateBlue;
            btnFlights.ForeColor = Color.White;
            btnFlights.Font = new Font("Segoe UI", 14, FontStyle.Bold);

           


        }

        private void label1_Click(object sender, EventArgs e)
        {
            labelTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            var form = new FlightsForm();
            form.ShowDialog();
        }

        private void btnAirlines_Click(object sender, EventArgs e)
        {
            var form = new AirlinesForm();
            form.ShowDialog();
        }
    }
}
