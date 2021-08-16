using System.ComponentModel.DataAnnotations;

namespace Cookbook.Models
{
    public class Step
    {
        [Key]
        public int StepID { get; set; }

        [Required]
        public int StepNo { get; set; }

        public Recipe Recipe { get; set; }

        [Required]
        public string Description { get; set; }
    }
}