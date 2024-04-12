using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTracker.Models.ToDO
{
    [Table("Tasks")]
    public class Tasks
    {
        [key]
        public int id { get; set; }
        [Required]
        [StringLength(100)] 
        public string? Description { get; set; }
        [Required]
        public DateTime? Created { get; set; }
        [Required]
        public bool? Completed { get; set; }
    }
}


