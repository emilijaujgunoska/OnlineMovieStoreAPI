using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string MovieTitle { get; set; } = null!;

        #region ActorDetails

        [StringLength(50)]
        public string? ActorName { get; set; }

        public int ActorId { get; set; }

        public Actor? Actor { get; set; }


        #endregion

        #region DirectorDetails
        [StringLength(50)]
        public string? DirectorName { get; set; }

        public int DirectorId { get; set; }

        public Director? Director { get; set; }
        #endregion

        #region ProducerDetails
        [StringLength(50)]
        public string? ProducerName { get; set; }

        public int ProducerId { get; set; }

        public Producer? Producer { get; set; }
        #endregion

        #region ScreenWriterDetails
        [StringLength(100)]
        public string? ScreenWriterName { get; set; }

        public int ScreenWriterId { get; set; }

        public ScreenWriter? ScreenWriter { get; set; }
        #endregion

        #region Category Details 

        [StringLength(60)]
        public string? CategoryName { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        #endregion

        public DateTime YearOfRelease { get; set; }

        public string? MovieDuration { get; set; }
        [StringLength(80)]
        public string? Genre { get; set; }

        public double Price { get; set; }

        public string? Currency { get;set; }
        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string Language { get; set; } = null!;

        public string? Subtitles { get; set; } = null!;

        public string? Country { get; set; }

        public string? PhotoUrl { get; set; }

        public string? VideoUrl { get; set; }
        public string? VideoResolution { get; set; }

        public string? TrailerUrl { get; set; }

        public bool IsPremier { get; set; }
    }
}
