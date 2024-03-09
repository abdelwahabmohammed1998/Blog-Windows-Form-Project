using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.Models
{
    public class New
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string title { get; set; }
        [Required]
        [MaxLength(100)]
        public string bref { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public DateTime date {  get; set; }
        [Required]
        public int authorId { get; set; }
        [Required]
        public int catalogId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Catalog Catalog { get; set; }

    }
}
