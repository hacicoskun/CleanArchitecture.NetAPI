using Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project.Domain.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }    
        public decimal Price { get; set; }

        // Bire bir ilişki örneği
        public virtual Category Category { get; set; }

        // Bire çok ilişki örneği
        public virtual List<Comment> Comments { get; set; }

        // Çoktan çok ilişki örneği
        public virtual List<Tag> Tags { get; set; }
    }
}
