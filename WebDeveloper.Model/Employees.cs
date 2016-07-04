using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Employees
    {
        
        public Employees()
        {
            Employees1 = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "The Last Name is required")]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The First Name is required")]
        [StringLength(10)]
        [Display(Name = "First name:")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Title:")]
        public string Title { get; set; }

        [StringLength(25)]
        [Display(Name = "Title of Courstesy:")]
        public string TitleOfCourtesy { get; set; }

        [Display(Name = "Birth Date:")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Hire Date:")]
        public DateTime? HireDate { get; set; }

        [StringLength(60)]
        [Display(Name = "Andress:")]
        public string Address { get; set; }

        [StringLength(15)]
        [Display(Name = "City:")]
        public string City { get; set; }

        [StringLength(15)]
        [Display(Name = "Region:")]
        public string Region { get; set; }

        [StringLength(10)]
        [Display(Name = "Postal Code:")]
        public string PostalCode { get; set; }

        [StringLength(15)]
        [Display(Name = "Country:")]
        public string Country { get; set; }

        [StringLength(24)]
        [Display(Name = "Home Phone:")]
        public string HomePhone { get; set; }

        [StringLength(4)]
        [Display(Name = "Extension:")]
        public string Extension { get; set; }

        [Column(TypeName = "image")]
        [Display(Name = "Photo:")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Notes:")]
        public string Notes { get; set; }

        [Display(Name = "Reports to:")]
        public int? ReportsTo { get; set; }

        [StringLength(255)]
        [Display(Name = "Photo Path:")]
        public string PhotoPath { get; set; }


        [Display(Name = "List:")]
        public virtual ICollection<Employees> Employees1 { get; set; }

        public virtual Employees Employees2 { get; set; }

        [Display(Name = "List Orders:")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
