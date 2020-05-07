using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagement.Models
{
    public partial class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(20)]
        public string ProductCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(50)]
        public string Brand { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
