﻿namespace Experis.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public DateTime Registrationdate { get; set; }
    }
}
