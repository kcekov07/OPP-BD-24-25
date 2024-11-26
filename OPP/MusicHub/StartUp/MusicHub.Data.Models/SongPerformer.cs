using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.MusicHub.Data.Models
{
    public class SongPerformer
    {
        public int SongId { get; set; } 
        public Song Song { get; set; }

        public int PerformerId { get; set; } 
        public virtual Performer Performer { get; set; }
    }
}
