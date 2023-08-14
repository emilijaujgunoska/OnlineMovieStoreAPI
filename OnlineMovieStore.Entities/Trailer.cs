using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Trailer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(2000)]
        public string MovieUrl { get; set; } = null!;
        [StringLength(500)]
        public string? Description { get; set; }

        public DateTime DateAdded { get; set; }
        public bool isTrailer { get; set; }
    }
}
