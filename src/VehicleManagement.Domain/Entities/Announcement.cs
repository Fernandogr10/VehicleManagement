using System;

namespace VehicleManagement.Domain.Entities
{
    public class Announcement : Entity
    {
        public Announcement(Vehicle vehicle, decimal purchasePrice, decimal salePrice, DateTime? saleDate)
        {
            Vehicle = vehicle;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            SaleDate = saleDate;
        }
        
        public Vehicle Vehicle { get; private set; }
        public Guid VehicleId { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public decimal SalePrice { get; private set; }
        public DateTime? SaleDate { get; private set; }

        public void SellVehicle()
        {
            SaleDate ??= DateTime.Now;
        }
    }
}