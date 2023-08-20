
namespace OnlineMovieStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using OnlineMovieStore.Entities;
   // using OnlineMovieStore.Entities.Config;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    public class OnlineMovieStoreDbContext : DbContext
    {
        public OnlineMovieStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<ShopCart> ShopCarts { get; set; }

        public DbSet<Director> Directors { get; set; }
        public DbSet<ScreenWriter> ScreenWriters { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Video> Videos { get; set; }
    }

}
