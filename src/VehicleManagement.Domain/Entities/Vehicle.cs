﻿using System;
using VehicleManagement.Domain.Enums;

namespace VehicleManagement.Domain.Entities
{
    public class Vehicle : Entity
    {
        public Vehicle(Model model, Brand brand, int year, string color, EFuelType fuelType)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            FuelType = fuelType;
        }
        
        public Model Model { get; private set; }
        public Guid ModelId { get; private set; }
        public Brand Brand { get; private set; }
        public Guid BrandId { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public EFuelType FuelType { get; private set; }
    }
}