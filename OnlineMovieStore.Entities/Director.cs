using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Director
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]

        public string Name { get; set; } = null!;
        [StringLength(2000)]
        public string? Biography { get; set; }
        [StringLength(1000)]
        public string? MovieAwards { get; set; }
        public string Country { get; set; } = null!;

        public bool IsPopular { get; set; }
    }
}
