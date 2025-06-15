using AirlineApp.Data;
using AirlineApp.Services;
using Microsoft.EntityFrameworkCore;
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

            StyleForm();
            LoadAirlines();
            LoadFlights();
        }
        public Flight GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                return db.Flights.Include(f => f.Airline).FirstOrDefault(f => f.Id == id);
            }
        }

        private void StyleForm()
        {
            this.BackColor = Color.LightSkyBlue;

            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;

            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;

            btnDelete.BackColor = Color.DeepSkyBlue;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;

            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
        }
        private void SelectRow(DataGridViewRow row)
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

            if (row.Cells["Id"].Value != null)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                var service = new FlightService();
                selectedFlight = service.GetById(id);

                if (selectedFlight != null)
                {
                    txtFlightNumber.Text = selectedFlight.FlightNumber;
                    txtDeparture.Text = selectedFlight.Departure;
                    txtDestination.Text = selectedFlight.Destination;
                    dtDeparture.Value = selectedFlight.DepartureTime;
                    cmbAirlines.SelectedValue = selectedFlight.AirlineId;
                    numDuration.Value = selectedFlight.DurationMinutes;


                }
            }
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
                f.FlightNumber,
                f.Departure,
                f.Destination,
                f.DepartureTime,
                f.DurationMinutes,
                Airline = f.Airline.Name
            }).ToList();

            dataGridView.Columns["Id"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
            if (dataGridView.Rows.Count == 1)
            {
                var row = dataGridView.Rows[0];
                row.Selected = true;

                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    if (col.Visible)
                    {
                        dataGridView.CurrentCell = row.Cells[col.Index];
                        break;
                    }
                }

                if (row.Cells["Id"].Value != null)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    selectedFlight = service.GetById(id);

                    if (selectedFlight != null)
                    {
                        txtFlightNumber.Text = selectedFlight.FlightNumber;
                        txtDeparture.Text = selectedFlight.Departure;
                        txtDestination.Text = selectedFlight.Destination;
                        dtDeparture.Value = selectedFlight.DepartureTime;
                        cmbAirlines.SelectedValue = selectedFlight.AirlineId;
                    }
                }
            }
            if (dataGridView.Rows.Count == 1)
            {
                SelectRow(dataGridView.Rows[0]);
            }

        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {

        }

        private void numDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var flight = new Flight
            {
                FlightNumber = txtFlightNumber.Text,
                Departure = txtDeparture.Text,
                Destination = txtDestination.Text,
                DepartureTime = dtDeparture.Value,
                DurationMinutes = (int)numDuration.Value,
                AirlineId = ((Airline)cmbAirlines.SelectedItem).Id
            };

            var service = new FlightService();
            service.Add(flight);

            LoadFlights();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["FlightNumber"].Value?.ToString() == flight.FlightNumber)
                {
                    SelectRow(row);
                    break;
                }
            }

            ClearForm();

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["FlightNumber"].Value?.ToString() == flight.FlightNumber)
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 || selectedFlight == null)
            {
                MessageBox.Show("Please select a flight to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this flight?", "Confirmation", MessageBoxButtons.YesNo);
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
            txtFlightNumber.Text = "";
            txtDeparture.Text = "";
            txtDestination.Text = "";
            dtDeparture.Value = DateTime.Now;
            cmbAirlines.SelectedIndex = 0;
            selectedFlight = null;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedFlight == null)
            {
                MessageBox.Show("Please select a flight to edit.");
                return;
            }

            selectedFlight.FlightNumber = txtFlightNumber.Text;
            selectedFlight.Departure = txtDeparture.Text;
            selectedFlight.Destination = txtDestination.Text;
            selectedFlight.DepartureTime = dtDeparture.Value;
            selectedFlight.DurationMinutes = (int)numDuration.Value;
            selectedFlight.AirlineId = ((Airline)cmbAirlines.SelectedItem).Id;


            var service = new FlightService();
            service.Update(selectedFlight);

            LoadFlights();




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                SelectRow(dataGridView.SelectedRows[0]);
            }
        }
    }
}
