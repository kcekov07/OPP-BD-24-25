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
    }
}
