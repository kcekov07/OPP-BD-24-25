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
using System.Diagnostics.Metrics;


namespace AirlineApp.Forms
{
    public partial class AirlinesForm : Form
    {
        public AirlinesForm()
        {
            InitializeComponent();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.BackColor = Color.LightSkyBlue;
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;

            btnDelete.BackColor = Color.DeepSkyBlue;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;

            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;

            btnBack.BackColor = Color.LightSlateGray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;

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
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            selectedAirline.Name = txtName.Text;
            selectedAirline.Country = txtCountry.Text;
            selectedAirline.LogoPath = selectedImagePath;
            selectedAirline.Founder = txtFounder.Text;
            selectedAirline.FoundedYear = (int)numFoundedYear.Value;

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
                    pictureBoxLogo.Image = ResizeImage(selectedImagePath, pictureBoxLogo.Width, pictureBoxLogo.Height);

                }
            }
        }
        private Image ResizeImage(string path, int width, int height)
        {
            using (var original = Image.FromFile(path))
            {
                var resized = new Bitmap(original, new Size(width, height));
                return new Bitmap(resized);
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
                a.Founder,
                a.FoundedYear,
                a.LogoPath
            }).ToList();

            if (dataGridView.Columns.Contains("Id"))
                dataGridView.Columns["Id"].Visible = false;

            if (dataGridView.Columns.Contains("LogoPath"))
                dataGridView.Columns["LogoPath"].Visible = false;



            if (dataGridView.Rows.Count == 1)
            {
                dataGridView.Rows[0].Selected = true;
                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    if (col.Visible)
                    {
                        dataGridView.CurrentCell = dataGridView.Rows[0].Cells[col.Index];
                        break;
                    }
                }

            }
            dataGridView_SelectionChanged_1(dataGridView, EventArgs.Empty);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var airline = new Airline
            {
                Name = txtName.Text,
                Country = txtCountry.Text,
                LogoPath = selectedImagePath,
                Founder = txtFounder.Text,
                FoundedYear = (int)numFoundedYear.Value
            };

            var service = new AirlineService();
            service.Add(airline);

            LoadAirlines();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Name"].Value?.ToString() == airline.Name)
                {
                    row.Selected = true;
                    foreach (DataGridViewColumn col in dataGridView.Columns)
                    {
                        if (col.Visible)
                        {
                            dataGridView.CurrentCell = row.Cells[col.Index];
                            break;
                        }
                    }

                    break;
                }
            }

            
            selectedAirline = airline;
            selectedImagePath = airline.LogoPath;

            if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
            {
                pictureBoxLogo.Image = Image.FromFile(selectedImagePath);
                pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAirline == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this airline?",
                                         "Confirm deletion",
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


        private void ClearForm()
        {
            txtName.Text = "";
            txtCountry.Text = "";
            pictureBoxLogo.Image = null;
            selectedImagePath = "";
            selectedAirline = null;
        }

        private void AirlinesForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_SelectionChanged_1(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count == 0)
                return;

            var selectedRow = dataGridView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value == null)
                return;

            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            var service = new AirlineService();
            selectedAirline = service.GetById(id);

            if (selectedAirline != null)
            {
                txtName.Text = selectedAirline.Name;
                txtCountry.Text = selectedAirline.Country;
                selectedImagePath = selectedAirline.LogoPath;
                txtFounder.Text = selectedAirline.Founder;
                int year = selectedAirline.FoundedYear;
                if (year >= numFoundedYear.Minimum && year <= numFoundedYear.Maximum)
                {
                    numFoundedYear.Value = year;
                }
                else
                {
                    numFoundedYear.Value = DateTime.Now.Year; 
                }




                if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                {
                   
                    if (pictureBoxLogo.Image != null)
                    {
                        pictureBoxLogo.Image.Dispose();
                        pictureBoxLogo.Image = null;
                    }

                    pictureBoxLogo.Image = Image.FromFile(selectedImagePath);
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBoxLogo.Image = null;
                }
            }


        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numFoundedYear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
