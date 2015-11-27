using System;
using System.Collections.Generic;

namespace CarModelViewer.Models
{
    public class VehicleMake
    {
        public int VehicleMakeID { get; set; }
        public String ManufacturerName { get; set; }

        public List<VehicleModel> models { get; set; }
    }
}