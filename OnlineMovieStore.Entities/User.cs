using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Username { get; set; } = null!;
        [StringLength(100)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        public string Address { get; set; } = null!;
        [StringLength(100)]
        public string Country { get; set; } = null!;
        [StringLength(100)]
        public string City { get; set; } = null!;

        public byte[] PasswordHash { get; set; } = null!;

        public byte[] PasswordSalt { get; set; } = null!;

        public string? Phone { get; set; }

        public DateTime UserCreated { get; set; }

        public bool IsAdmin { get; set; }

    }
}
