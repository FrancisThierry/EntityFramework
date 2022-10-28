using System;
using Microsoft.EntityFrameworkCore;

namespace OneTableCodeFirst.Models
{
    public class AnimalContext : DbContext
    {
        public string DbPath { get; }

        public AnimalContext() : base()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "animaldata.db");
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Food> Foods { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.FkAnimalId).HasColumnName("FK_Animal_ID");

                entity.HasOne(d => d.FkAnimal)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.FkAnimalId);
            });
            //  modelBuilder.Entity<Animal>().HasData(new Animal() {Id=1, Name = "Bill", Breed="siamese" });
            // modelBuilder.Entity<Animal>().HasData(new Animal() {Id=2, Name = "Boule", Breed="siamese" });
            // modelBuilder.Entity<Animal>().HasData(new Animal() {Id=3, Name = "Bale", Breed="siamese" });
            // modelBuilder.Entity<Animal>().HasData(new Animal() {Id=4, Name = "Belle", Breed="siamese" });
            // modelBuilder.Entity<Animal>().HasData(new Animal() {Id=5, Name = "Garfield", Breed="siamese" });
            // modelBuilder.Entity<Animal>().HasData(new Animal() {Id=6, Name = "Miss Teigne", Breed="siamese" });

        }
    }
}
