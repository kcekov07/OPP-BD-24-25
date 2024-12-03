using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.MusicHub.Data.Models
{
    public class Writer
    {
        public int Id { get; set; } 

        public string Name { get; set; } 

        public string Pseudonym { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
