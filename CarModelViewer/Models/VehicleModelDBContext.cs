using System.Data.Entity;


namespace CarModelViewer.Models
{

    public class VehicleModelDBContext : DbContext
    {
        public DbSet<VehicleMake> Manufacturers { get; set; }
        public DbSet<VehicleModel> Models { get; set; }

    }
}