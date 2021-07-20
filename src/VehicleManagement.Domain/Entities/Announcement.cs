using System;

namespace VehicleManagement.Domain.Entities
{
    public class Announcement : Entity
    {
        public Announcement() { }
        public Announcement(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        
        public Vehicle Vehicle { get; private set; }
        public Guid VehicleId { get; private set; }
    }
}