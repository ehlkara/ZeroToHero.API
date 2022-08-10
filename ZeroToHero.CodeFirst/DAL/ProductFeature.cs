﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroToHero.CodeFirst.DAL
{
    public class ProductFeature
    {
        [ForeignKey("Product")]
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        //public int ProductId { get; set; }
        //[ForeignKey("ProductRef_Id")]
        public Product Product { get; set; }
    }
}
