using Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}
