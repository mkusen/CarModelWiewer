﻿using System.Collections.Generic;
using System.Linq;


namespace CarModelViewer.Models
{
    interface IVehicleModelRepository
    {
        List<VehicleMake> GetManufacturer();
    }

    public class VehicleModelRepository : IVehicleModelRepository
    {
        public List<VehicleMake> GetManufacturer()
        {
            VehicleModelDBContext vehicleModelDBContext = new VehicleModelDBContext();
            return vehicleModelDBContext.Manufacturers.ToList();
        }
    }
}