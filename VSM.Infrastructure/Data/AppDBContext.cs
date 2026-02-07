using Microsoft.EntityFrameworkCore;
using VSM.Domain.AuthModels;
using VSM.Domain.Models;

namespace VSM.Infrastructure.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<LoginRequestModel> Authentiation { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<VehicleDetails> Vehicles { get; set; }
        public DbSet<ServiceRequestModel> Services { get; set; }

    }
}
