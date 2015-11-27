using System;

namespace CarModelViewer.Models
{
    // create table VehicleModel
    public class VehicleModel
    {
        public int VehicleModelID { get; set; }
        public String ModelName { get; set; }

        public VehicleMake vehicleMake { get; set; }
    }
}