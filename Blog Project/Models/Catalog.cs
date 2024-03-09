using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.Models
{
    public class Catalog
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? name { get; set; }
        [Required]
        public string? description { get; set; }
        public virtual List<New> News { get; set; } = new List<New>();
    }
}
