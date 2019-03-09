using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HTManagerment.Data.Common.Interfaces;

namespace HTManagerment.Data.Model
{
    [Table("Products")]
    public class ProductModel : IDateTracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Unit { get; set; }
        
        public decimal Quantity { get; set; }

        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public int Version { get; set; }
    }
}
