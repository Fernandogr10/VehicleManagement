using System;
using VehicleManagement.Domain.Enums;

namespace VehicleManagement.Domain.Entities
{
    public class Vehicle : Entity
    {
        public Vehicle() { }
        public Vehicle(Model model, int year, string color, EFuelType fuelType, decimal purchasePrice, decimal salePrice, DateTime? saleDate)
        {
            Model = model;
            Year = year;
            Color = color;
            FuelType = fuelType;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            SaleDate = saleDate;
        }
        
        public Model Model { get; private set; }
        public Guid ModelId { get; private set; }
        public Announcement Announcement { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public EFuelType FuelType { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public decimal SalePrice { get; private set; }
        public DateTime? SaleDate { get; private set; }

        public void AnnounceVehicle(Announcement announcement)
        {
            Announcement = announcement;
        }
    }
}