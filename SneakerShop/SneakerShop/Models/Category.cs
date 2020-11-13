using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.Models
{
    public class Category
    {
        public short Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(450)]
        public string Name { get; set; }

        public virtual ICollection<GenericProductCategory>  GenericProductCategories{ get; set; }
    }
}
