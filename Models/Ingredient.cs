using System.ComponentModel.DataAnnotations;

namespace Cookbook.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }

        [Required]
        public string Name { get; set; }
        
        public Recipe Recipe { get; set; }

        public string Unit { get; set; }

        [Required]
        public string Amount { get; set; }
    }
}