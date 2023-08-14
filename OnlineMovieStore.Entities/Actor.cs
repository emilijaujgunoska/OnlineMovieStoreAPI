using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]

        public string Name { get; set; } = null!;
        [StringLength(1100)]
        public string? Biography { get; set; }
        [StringLength(50)]
        public string Country { get; set; } = null!;

        [StringLength(1000)]
        public string? MovieAwards { get; set; }
        public bool IsPopular { get; set; }

        public bool IsLeadActor { get; set; }

        // TO DO: Relation with other table/s

       // PRIMER KAKO public virtual ICollection<Book>? Books { get; set; }
    }
}
