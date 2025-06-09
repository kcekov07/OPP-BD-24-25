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

namespace AirlineApp.Forms
{
    public partial class FlightsForm : Form
    {

        private Flight selectedFlight;
        public FlightsForm()
        {
            InitializeComponent();
            LoadAirlines();
            LoadFlights();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
        }
        private void LoadAirlines()
        {
            var service = new AirlineService();
            var airlines = service.GetAll();
            cmbAirlines.DataSource = airlines;
            cmbAirlines.DisplayMember = "Name";
            cmbAirlines.ValueMember = "Id";
        }

        private void LoadFlights()
        {
            var service = new FlightService();
            var data = service.GetAll();

            dataGridView.DataSource = data.Select(f => new
            {
                f.Id,
                f.Destination,
                f.DepartureDate,
                f.Aircraft,
                f.DurationMinutes,
                Airline = f.Airline.Name
            }).ToList();

            if (dataGridView.Columns.Contains("Id"))
                dataGridView.Columns["Id"].Visible = false;
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {

        }

        private void numDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbAirlines.SelectedItem is not Airline selectedAirline) return;

            var flight = new Flight
            {
                Destination = txtDestination.Text,
                DepartureDate = dtDeparture.Value,
                Aircraft = txtAircraft.Text,
                DurationMinutes = (int)numDuration.Value,
                AirlineId = selectedAirline.Id
            };

            var service = new FlightService();
            service.Add(flight);
            LoadFlights();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFlight == null) return;

            var confirm = MessageBox.Show("Сигурен ли си, че искаш да изтриеш този полет?",
                                          "Потвърди", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var service = new FlightService();
                service.Delete(selectedFlight.Id);
                LoadFlights();
                ClearForm();
            }

        }
        private void ClearForm()
        {
            txtDestination.Text = "";
            txtAircraft.Text = "";
            numDuration.Value = 60;
            selectedFlight = null;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var row = dataGridView.SelectedRows[0];
                string destination = row.Cells["Destination"].Value.ToString();

                var service = new FlightService();
                selectedFlight = service.GetAll().FirstOrDefault(f => f.Destination == destination);

                if (selectedFlight != null)
                {
                    txtDestination.Text = selectedFlight.Destination;
                    dtDeparture.Value = selectedFlight.DepartureDate;
                    txtAircraft.Text = selectedFlight.Aircraft;
                    numDuration.Value = selectedFlight.DurationMinutes;
                    cmbAirlines.SelectedValue = selectedFlight.AirlineId;
                }
            }
        }

    }
}
