using System.Collections.Generic;
using Cookbook.Models;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public ICollection<Recipe> Recipes { get; set; }
}