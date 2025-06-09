using AirlineApp.Data;
using AirlineApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace AirlineApp.Forms
{
    public partial class AirlinesForm : Form
    {
        public AirlinesForm()
        {
            InitializeComponent();
            LoadAirlines();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
        }
        private string selectedImagePath;
        private Airline selectedAirline;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAirline == null)
            {
                MessageBox.Show("Моля, изберете ред за редакция.");
                return;
            }

            selectedAirline.Name = txtName.Text;
            selectedAirline.Country = txtCountry.Text;
            selectedAirline.LogoPath = selectedImagePath;

            var service = new AirlineService();
            service.Update(selectedAirline);
            LoadAirlines();
            ClearForm();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pictureBoxLogo.Image = Image.FromFile(selectedImagePath);
                }
            }
        }
        private void LoadAirlines()
        {
            var service = new AirlineService();
            var data = service.GetAll();

            dataGridView.DataSource = data.Select(a => new
            {
                a.Id,
                a.Name,
                a.Country,
                a.LogoPath
            }).ToList();

            // Скриваме колоната с ID
            if (dataGridView.Columns.Contains("Id"))
                dataGridView.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var airline = new Airline
            {
                Name = txtName.Text,
                Country = txtCountry.Text,
                LogoPath = selectedImagePath
            };

            var service = new AirlineService();
            service.Add(airline);
            LoadAirlines();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAirline == null)
            {
                MessageBox.Show("Моля, изберете ред за изтриване.");
                return;
            }

            var result = MessageBox.Show("Сигурен ли си, че искаш да изтриеш тази авиокомпания?",
                                         "Потвърди изтриване",
                                         MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var service = new AirlineService();
                service.Delete(selectedAirline.Id);
                LoadAirlines();
                ClearForm();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var row = dataGridView.SelectedRows[0];
                string name = row.Cells["Name"].Value.ToString();

                var service = new AirlineService();
                selectedAirline = service.GetAll().FirstOrDefault(a => a.Name == name);

                if (selectedAirline != null)
                {
                    txtName.Text = selectedAirline.Name;
                    txtCountry.Text = selectedAirline.Country;
                    selectedImagePath = selectedAirline.LogoPath;

                    if (File.Exists(selectedImagePath))
                    {
                        pictureBoxLogo.Image = Image.FromFile(selectedImagePath);
                    }
                    else
                    {
                        pictureBoxLogo.Image = null;
                    }
                }
            }
        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtCountry.Text = "";
            pictureBoxLogo.Image = null;
            selectedImagePath = "";
            selectedAirline = null;
        }
    }
}
