﻿using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("PRODUCT")]
    public class Product : BaseEntity
    {
        [Column("NAME")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("PRICE")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("CATEGORY_NAME")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("IMAGE_URL")]
        [StringLength(300)]
        public string ImageURL { get; set; }

    }
}
