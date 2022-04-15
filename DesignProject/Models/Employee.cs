using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Employee : Persons
    {
        [Display(Name = "Job")]
        public string JobTitle { get; set; }
        [Display(Name = "Starting Date")]
        public DateTime startingDate { get; set; }

    }
}
