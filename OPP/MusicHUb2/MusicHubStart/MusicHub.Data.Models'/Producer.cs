using MusicHubStart.MusicHub.Data.Models_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.MusicHub.Data.Models
{
    public class Producer
    {
        public int Id { get; set; } 

        public string Name { get; set; } 

        public string Pseudonym { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
