using AirlineApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AirlineApp.Services
{
    public class AirlineService
    {
        private readonly AppDbContext _context;

        public AirlineService()
        {
            _context = new AppDbContext();
        }

        public List<Airline> GetAll()
        {
            return _context.Airlines.Include(a => a.Flights).ToList();
        }

        public Airline? GetById(int id)
        {
            return _context.Airlines.Include(a => a.Flights)
                .FirstOrDefault(a => a.Id == id);
        }

        public void Add(Airline airline)
        {
            _context.Airlines.Add(airline);
            _context.SaveChanges();
        }

        public void Update(Airline airline)
        {
            _context.Airlines.Update(airline);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var airline = _context.Airlines.Find(id);
            if (airline != null)
            {
                _context.Airlines.Remove(airline);
                _context.SaveChanges();
            }
        }
    }
}
