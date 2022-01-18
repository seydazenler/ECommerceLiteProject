﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerceLiteEntity.Models
{
    [Table("Products")]
    public class Product:TheBase<int>
    {
        [Required]
        [StringLength(50,MinimumLength=2,ErrorMessage ="Ürün adının uzunluğu 2 ile 50 karakter aralığında olmalıdır!")]

        public string ProductName { get; set; }
        [StringLength(500,ErrorMessage = "Ürün açıklamasının uzunluğu en fazla 500 karakter olmalıdır!")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)] //Currency : para birimi
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}