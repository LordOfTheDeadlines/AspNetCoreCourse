using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCourse.Models
{
    [Table("OrderItems")]
    public class OrderItems
    {
        [Key] public int Id { get; set; }
        public int Amount { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
