using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.MusicHub.Data.Models
{
    public class Song
    {
        public int Id { get; set; } 

        public string Name { get; set; } 

        public TimeSpan Duration { get; set; } 

        public DateTime CreatedOn { get; set; } 

        public Genre genre { get; set; } 

        public int? AlbumId { get; set; } 
        public virtual Album Album { get; set; }

        public int WriterId { get; set; } 
        public virtual  Writer Writer { get; set; }

        public decimal Price { get; set; } 

        public ICollection<SongPerformer> SongPerformers { get; set; } = new List<SongPerformer>();

        public enum Genre
        {
            Blues,
            Rap,
            PopMusic,
            Rock,
            Jazz
        }
    }
}
