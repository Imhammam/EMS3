using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class EMSDbcontext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacation> VacationTypes { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
        public DbSet<VacationRequest> VacationRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = Bugs;database = EMS;Trusted_Connection=True;TrustServerCertificate=True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne<Department>(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.VacationRequest)
                .WithOne(v => v.Employee)
                .HasForeignKey(v => v.EmployeeNumber);

            modelBuilder.Entity<VacationRequest>()
                .HasOne(v => v.VacationType)
                .WithMany(vt => vt.VacationRequest)
                .HasForeignKey(v => v.VacationTypeCode);

            modelBuilder.Entity<VacationRequest>()
                .HasOne(v => v.RequestState)
                .WithMany(rs => rs.VacationRequest)
                .HasForeignKey(v => v.StateId);

            modelBuilder.Entity<Position>()
          .HasOne(p => p.Department)
          .WithMany(d => d.Positions)
          .HasForeignKey(p => p.DepartmentId);

            modelBuilder.Entity<RequestState>().HasData(
              new RequestState(1, "Pending"),
              new RequestState(2, "Approved"),
              new RequestState(3, "Declined"));

        }
    }

}
