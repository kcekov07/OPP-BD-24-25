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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
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
