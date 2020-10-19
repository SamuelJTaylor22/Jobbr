using System.ComponentModel.DataAnnotations;

namespace Jobbr.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required]
        public string Location{get; set;}
        public string Description { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}