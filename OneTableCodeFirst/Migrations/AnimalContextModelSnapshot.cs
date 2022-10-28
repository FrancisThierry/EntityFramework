﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneTableCodeFirst.Models;

#nullable disable

namespace OneTableCodeFirst.Migrations
{
    [DbContext(typeof(AnimalContext))]
    partial class AnimalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("OneTableCodeFirst.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("OneTableCodeFirst.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FkAnimalId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("FK_Animal_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FkAnimalId");

                    b.ToTable("Food", (string)null);
                });

            modelBuilder.Entity("OneTableCodeFirst.Models.Food", b =>
                {
                    b.HasOne("OneTableCodeFirst.Models.Animal", "FkAnimal")
                        .WithMany("Foods")
                        .HasForeignKey("FkAnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FkAnimal");
                });

            modelBuilder.Entity("OneTableCodeFirst.Models.Animal", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
