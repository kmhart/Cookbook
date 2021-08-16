using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Cookbook.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Course { get; set; }

        public string Description { get; set; }

        [ValidateComplexType]
        public ICollection<Ingredient> Ingredients { get; set; }

        [ValidateComplexType]
        public ICollection<Step> Steps { get; set; }

    }
}