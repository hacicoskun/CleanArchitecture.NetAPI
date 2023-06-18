using Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Models
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
