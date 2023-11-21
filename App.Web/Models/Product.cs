﻿namespace App.Web.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime Created { get; set; }

     
    }
}
