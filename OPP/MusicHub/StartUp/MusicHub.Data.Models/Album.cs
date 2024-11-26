using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.MusicHub.Data.Models
{
    public class Album
    {
        public int Id { get; set; } 

        public string Name { get; set; } 

        public DateTime ReleaseDate { get; set; } 

        public int? ProducerId { get; set; } 
        public virtual Producer Producer { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();

        public decimal Price
        {
            get
            {
                return Songs != null ? Songs.Sum(s => s.Price) : 0;
            }
        } 
    }
}
