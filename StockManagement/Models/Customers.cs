using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagement.Models
{
    public partial class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public int CustomerNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        [Required]
        [StringLength(6)]
        public string Gender { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
    }
}
