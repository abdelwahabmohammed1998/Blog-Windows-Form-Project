using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.Models
{
    public class BlogContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<New> News { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABDELWAHAB;Database=BlogDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasIndex(a => a.userName)
                .IsUnique();
        }

    }
}
