using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class ProductVM
    {
        public Guid ProductID { get; set; }
        [Required(ErrorMessage = "Ürün adı boş geçilemez!")]
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}