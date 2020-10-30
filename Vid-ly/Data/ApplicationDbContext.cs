using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vid_ly.Data.Models;

namespace Vid_ly.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, IdentityRole<Guid>,Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Video> Videos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
