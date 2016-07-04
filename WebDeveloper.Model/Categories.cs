using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Categories
    {
        
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "The Category Name is required")]
        [StringLength(15)]
        [Display(Name = "Category Name:")]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        //[Required(ErrorMessage = "The Description is required")]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        [Display(Name = "Photo:")]
        public byte[] Picture { get; set; }

        [Display(Name = "Lista:")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
