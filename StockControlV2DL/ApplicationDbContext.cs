using Microsoft.EntityFrameworkCore;
using StockControlV2EL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace StockControlV2DL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<RAM> RAMs { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-U443062K\\SQLEXPRESS;Initial Catalog=StockControlDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // CPU seed data
            modelBuilder.Entity<CPU>().HasData(
                new CPU { Id = 1, CoreCount = 8, ClockSpeed = 3.6m, CreatedDate = DateTime.Now, IsDeleted = false, BrandType = "Intel CPU" }
            );

            // GPU seed data
            modelBuilder.Entity<GPU>().HasData(
                new GPU { Id = 1, Memory = 8, CoreClock = 1600, CreatedDate = DateTime.Now, IsDeleted = false, BrandType = "Asus GPU" }
            );

            // RAM seed data
            modelBuilder.Entity<RAM>().HasData(
                new RAM { Id = 1, Capacity = 16, Speed = 3200, CreatedDate = DateTime.Now, IsDeleted = false, BrandType= "Corsair Ram"}
            );

            // MotherBoard seed data
            modelBuilder.Entity<MotherBoard>().HasData(
                new MotherBoard { Id = 1, Socket = "LGA1151", FormFactor = "ATX", CreatedDate = DateTime.Now, IsDeleted = false, BrandType = " Gigabyte MotherBoard" }
            );



        }
    }
}
