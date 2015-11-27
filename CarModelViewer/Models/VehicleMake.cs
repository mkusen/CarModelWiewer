using System;
using System.Collections.Generic;

namespace CarModelViewer.Models
{
    //create table VehicleMake
    public class VehicleMake
    {
        public int VehicleMakeID { get; set; }
        public String ManufacturerName { get; set; }

        public List<VehicleModel> models { get; set; }
    }
}