using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libovies.Modele
{
    public class DbContextMovie : DbContext
    {
        string DbPath = @"C:\projets\TDEF\databaseTD1.db";
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<MovieDistributor> MovieDistributors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {DbPath}");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDistributor>().HasKey(md => new { md.MovieId, md.DistributorId });
        }



    }


}

