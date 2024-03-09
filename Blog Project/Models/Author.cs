using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.Models
{
    public class Author
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(25)]
        public string name { get; set; }
        [Required]
        [MaxLength(20)]
        public string userName { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        [MaxLength(20)]
        public string password { get; set; }
        [NotMapped]
        public string matchPassword { get; set; }
        [Required]
        public DateTime joinDate { get; set; }
        public virtual List<New> News { get; set; } = new List<New>();

    }
}
