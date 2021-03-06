using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Category:BaseEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
