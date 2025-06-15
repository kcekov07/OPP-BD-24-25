using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Data
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }    
        public string Departure { get; set; }       
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int DurationMinutes { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }

    }
}
