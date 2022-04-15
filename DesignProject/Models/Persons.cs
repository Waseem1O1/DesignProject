using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public abstract class Persons
    {

        public int ID { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime dateofBirth { get; set; }
        public string Notes { get; set; }
    }







    public enum Genders
    {
        Male,
        Female,
        Other,
    }
}
