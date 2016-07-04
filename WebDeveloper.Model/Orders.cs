using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [StringLength(5)]
        [Display(Name = "Customers ID:")]
        public string CustomerID { get; set; }

        [Display(Name = "Employeed ID:")]
        public int? EmployeeID { get; set; }

        [Display(Name = "Order date:")]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Required Date:")]
        public DateTime? RequiredDate { get; set; }

        [Display(Name = "Shipped Date:")]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Ship Via:")]
        public int? ShipVia { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Freight:")]
        public decimal? Freight { get; set; }

        [StringLength(40)]
        [Display(Name = "Ship Name:")]
        public string ShipName { get; set; }

        [StringLength(60)]
        [Display(Name = "Ship andress:")]
        public string ShipAddress { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship City:")]
        public string ShipCity { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship Region:")]
        public string ShipRegion { get; set; }

        [StringLength(10)]
        [Display(Name = "Ship Postal Code:")]
        public string ShipPostalCode { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship Country:")]
        public string ShipCountry { get; set; }
        //[Display(Name = "List customers:")]
        public virtual Customers Customers { get; set; }
        //[Display(Name = "List Employees:")]
        public virtual Employees Employees { get; set; }
    }
}
