using Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Models
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } 
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
