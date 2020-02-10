using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities;
using WebStore.Domain.Entities.Base;

namespace WebStore.Models
{
    public class OrderItem : BaseEntity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; } 
        public virtual Product Product { get; set; } 
    }
}