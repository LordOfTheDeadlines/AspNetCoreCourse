using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCourse.Models
{
    [Table("Item")]
    public class Item
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
