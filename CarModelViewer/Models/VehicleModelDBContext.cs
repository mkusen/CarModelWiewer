using System.Data.Entity;


namespace CarModelViewer.Models
{
    //retrieve data from db and populate objects
    public class VehicleModelDBContext : DbContext
    {
        public DbSet<VehicleMake> Manufacturers { get; set; }
        public DbSet<VehicleModel> Models { get; set; }

    }
}