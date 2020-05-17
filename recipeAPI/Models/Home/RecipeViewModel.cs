using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace recipeAPI.Models
{
    public class RecipeViewModel
    {
        public string RequestUrl { get; set; }
        public List<Recipe> Recipes { get; set; }
        
    }
}