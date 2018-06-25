using System.Data.Entity;
using VoxelCloud.Models.Tables;

namespace VoxelCloud.Models
{
    public class Context : DbContext
    {
        public Context() : base("name = database") { }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Location> Location { get; set; } 
        public virtual DbSet<CustomerLocation> CustomerLocation { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceEvent> DeviceEvent { get; set; }
        public virtual DbSet<CustomerDevice> CustomerDevice { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}