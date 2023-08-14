using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = null!;


        #region Movie Details
        [StringLength(100)]
        public string? LeadActor { get; set; }
        [StringLength(50)]
        public string? MovieProducer { get; set; }
        [StringLength(50)]

        public string? MovieDirector { get; set; }
        [StringLength(50)]

        public string? MovieScreenWriter { get; set; }   

       
        [StringLength(100)]
        public string MovieTitle { get; set; } = null!;
        [StringLength(50)]
        public string? MovieCountry { get; set; }
        [StringLength(100)]

        public string? MovieCategory { get; set; }
        #endregion

        public int MovieCount { get; set; }

        public double VideoResolution { get; set; }

        public string Language { get; set; } = null!;

        public string Subtitles { get; set; } = null!;

        public double Price { get; set; }

        public DateTime PurchaseDate { get; set; }
        public DateTime PurchaseTime { get; set; }
        


    }
}
