using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleManagement.Domain.Entities
{
    public class Model : Entity
    {
        private readonly IList<Vehicle> _vehicles;

        public Model() { }
        public Model(string name, Brand brand)
        {
            Name = name;
            Brand = brand;
            _vehicles = new List<Vehicle>();
        }
        
        public string Name { get; private set; }
        public Brand Brand { get; private set; }
        public Guid BrandId { get; private set; }
        public IReadOnlyCollection<Vehicle> Vehicles => _vehicles.ToArray();
        
        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }
    }
}