using System;
using System.ComponentModel.DataAnnotations;
namespace Restauranter.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string restaurant { get; set; }

        [Required(ErrorMessage="hey dingus")]
        public string reviewer  { get; set; }

        [Required(ErrorMessage="hey dingus")]
        public string review { get; set; }

        [Required(ErrorMessage="hey dingus")]
    
        public DateTime? date_visited { get; set; }

        [Required]
        public int rating { get; set; }
        
        //public DateTime? created_at { get; set; }
    }
}