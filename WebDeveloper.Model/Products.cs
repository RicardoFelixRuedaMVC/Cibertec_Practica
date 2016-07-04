using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "The Product Name is required")]
        [Display(Name = "Product Name:")]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }


        [StringLength(20)]
        [Display(Name = "Quantity Per Unit:")]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Unit Price:")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units in Stock:")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Units on Orders:")]
        public short? UnitsOnOrder { get; set; }

        [Display(Name = "Recorder Level:")]
        public short? ReorderLevel { get; set; }

        [Display(Name = "Discontinued:")]
        public bool Discontinued { get; set; }

        [Display(Name = "List Categories:")]
        public virtual Categories Categories { get; set; }
    }
}
