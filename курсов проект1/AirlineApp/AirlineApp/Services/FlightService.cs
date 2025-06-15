using AirlineApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AirlineApp.Services
{
    public class FlightService
    {
        private readonly AppDbContext _context;

        public FlightService()
        {
            _context = new AppDbContext();
        }
        public Flight GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                return db.Flights
                         .Include(f => f.Airline)
                         .FirstOrDefault(f => f.Id == id);
            }
        }
        public List<Flight> GetAll()
        {
            return _context.Flights.Include(f => f.Airline).ToList();
        }

        public void Add(Flight flight)
        {
            _context.Flights.Add(flight);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var flight = _context.Flights.Find(id);
            if (flight != null)
            {
                _context.Flights.Remove(flight);
                _context.SaveChanges();
            }
        }
        public void Update(Flight updatedFlight)
        {
            using (var db = new AppDbContext())
            {
                var existing = db.Flights.FirstOrDefault(f => f.Id == updatedFlight.Id);
                if (existing != null)
                {
                    existing.FlightNumber = updatedFlight.FlightNumber;
                    existing.Departure = updatedFlight.Departure;
                    existing.Destination = updatedFlight.Destination;
                    existing.DepartureTime = updatedFlight.DepartureTime;
                    existing.DurationMinutes = updatedFlight.DurationMinutes;
                    existing.AirlineId = updatedFlight.AirlineId;

                    db.SaveChanges();
                }
            }
        }

    }
}
