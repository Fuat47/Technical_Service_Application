using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSA.Model.Models;

namespace TSA.Model.Db
{
    public class TSADbContext : DbContext
    {

        private string connectionString;
        
        //EF Core use this method to map our models to database tables
        public TSADbContext()
        {
            connectionString = "Server=.;Database=btk_tsa_db;Trusted_Connection=True;Encrypt=False";
        }
        
        public TSADbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUser>()
                .HasMany(x => x.MaintenanceRecords)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<TblDevice>()
               .HasMany(x => x.MaintenanceRecords)
               .WithOne(x => x.Device)
               .HasForeignKey(x => x.DeviceId);

            modelBuilder.Entity<TblDeviceType>()
                .HasMany(x => x.Devices)
                .WithOne(x => x.Type)
                .HasForeignKey(x => x.TypeId);

            modelBuilder.Entity<TblPersonnel>()
                .HasMany(x => x.AssignedDevices)
                .WithOne(x => x.AssignedPersonnel)
                .HasForeignKey(x => x.AssignedPersonnelId);

            modelBuilder.Entity<TblDepartment>()
                .HasMany(x => x.Personnels)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId);
        }

        public DbSet<TblUser> Users { get; set; }
        public DbSet<TblMaintenanceRecord> MaintenanceRecords { get; set;}
        public DbSet<TblDevice> Devices { get; set; }
        public DbSet<TblDeviceType> DeviceTypes { get; set; }
        public DbSet<TblPersonnel> Personnels { get; set; }
        public DbSet<TblDepartment> Departments { get; set; }


    }
}
