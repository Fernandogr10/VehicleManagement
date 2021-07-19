using System;

namespace VehicleManagement.Domain.Entities
{
    public class Model : Entity
    {
        public Model(string name, Brand brand, Guid brandId)
        {
            Name = name;
            Brand = brand;
            BrandId = brandId;
        }
        
        public string Name { get; private set; }
        public Brand Brand { get; private set; }
        public Guid BrandId { get; private set; }
    }
}