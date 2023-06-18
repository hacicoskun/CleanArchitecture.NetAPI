using Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Models
{
    public class ProductTag : BaseEntity
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; } 
        public Guid TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
