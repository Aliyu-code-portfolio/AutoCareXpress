using ACX.Domain.Model;
using ACX.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Common
{
    public class RepositoryContext:IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ServiceLocationConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public DbSet<PickUpAddress> PickUpAddresses { get; set;}
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ProviderService> ProviderServices { get; set; }
        public DbSet<Ref_Service_Location> Ref_Service_Locations { get; set; }
        public DbSet<Ref_Service_Type> Ref_Service_Types { get; set; }
        public DbSet<DoYouKnow> DoYouKnows { get;set; }
    }
}
