using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace recipeAPI.Models
{
    public class Recipe
    {
        [Description("Ontology identifier")]
        public string URI { get; set; }
        [Description("Recipe Title")]
        public string Label { get; set; }
        [Description("Image URL")]
        public string Image { get; set; }

        [Description("Site Identifier")]
        public string Source { get; set; }

        [Description("Original Recipe URL")]
        public string URL { get; set; }

        [Description("Number of servings")]
        public Int32 Yield { get; set; }

        [Description("Total energy, kcal")]
        public float Calories { get; set; }

        [Description("Total Weight, g")]
        public float TotalWeight { get; set; }

        [Description("Ingredient List")]
        public List<Ingredient> Ingredients { get; set; }

        [Description("Total nutrients for the entire recipe")]
        public List<NutrientInfo> TotalNutrients { get; set; }

        [Description("% daily value for the entire recipe")]
        public List<NutrientInfo> TotalDaily { get; set; }

        [Description("Diet labels: “balanced”, “high-protein”, “high-fiber”, “low-fat”, “low-carb”, “low-sodium” (labels are per serving)")]
        public List<DietLabels> DietLabels { get; set; }

        [Description("Health labels: “vegan”, “vegetarian”, “paleo”, “dairy-free”, “gluten-free”, “wheat-free”, “fat-free”, “low-sugar”, “egg-free”, “peanut-free”, “tree-nut-free”, “soy-free”, “fish-free”, “shellfish-free” (labels are per serving)")]
        public List<HealthLabels> HealthLabels { get; set; }
    }

    public enum DietLabels
    {
        Balanced,
        High_Fiber,
        High_Protein,
        Low_Carb,
        Low_Fat,
        Low_Sodium
        //Diet    Balanced    balanced    Protein/Fat/Carb values in 15/35/50 ratio
        //Diet    High-Fiber  high-fiber  More than 5g fiber per serving
        //Diet    High-Protein    high-protein    More than 50% of total calories from proteins
        //Diet    Low-Carb    low-carb    Less than 20% of total calories from carbs
        //Diet    Low-Fat low-fat Less than 15% of total calories from fat
        //Diet    Low-Sodium  low-sodium  Less than 140mg Na per serving

    }

    public enum HealthLabels
    {
        Alcohol_Free,
        Celery_Free,
        Curstacean_Free,
        Dairy,
        Eggs,
        Fish,
        Gluten,
        Kidney,
        Kosher,
        Low,
        Lupine_Free,
        Mustard_Free,
        No_Oil_Added,
        No_Sugar,
        Paleo,
        Peanuts,
        Pescatarian,
        Prok_Free,
        Red_Meat_Free,
        Sesame_Free,
        Shellfish,
        Soy,
        Sugar_Concious,
        Tree_Nuts,
        Vegan,
        Vegetarian,
        Wheat_Free

        //Health  Alcohol-free    alcohol-free    No alcohol used or contained
        //Health  Celery-free celery-free does not contain celery or derivatives
        //Health  Crustacean-free crustacean-free does not contain crustaceans (shrimp, lobster etc.) or derivatives
        //Health  Dairy   dairy-free  No dairy; no lactose
        //Health  Eggs    egg-free    No eggs or products containing eggs
        //Health  Fish    fish-free   No fish or fish derivatives
        //Health  Gluten  gluten-free No ingredients containing gluten
        //Health  Kidney friendly kidney-friendly per serving – phosphorus less than 250 mg AND potassium less than 500 mg AND sodium: less than 500 mg
        //Health  Kosher  kosher  contains only ingredients allowed by the kosher diet. However it does not guarantee kosher preparation of the ingredients themselves
        //Health  Low potassium   low-potassium   Less than 150mg per serving
        //Health  Lupine-free lupine-free does not contain lupine or derivatives
        //Health  Mustard-free    mustard-free    does not contain mustard or derivatives
        //Health  No oil added    No-oil-added    No oil added except to what is contained in the basic ingredients
        //Health  No-sugar    low-sugar   No simple sugars – glucose, dextrose, galactose, fructose, sucrose, lactose, maltose
        //Health  Paleo   paleo   Excludes what are perceived to be agricultural products; grains, legumes, dairy products, potatoes, refined salt, refined sugar, and processed oils
        //Health  Peanuts peanut-free No peanuts or products containing peanuts
        //Health  Pescatarian pescatarian Does not contain meat or meat based products, can contain dairy and fish
        //Health  Pork-free   pork-free   does not contain pork or derivatives
        //Health  Red meat-free   red-meat-free   does not contain beef, lamb, pork, duck, goose, game, horse, and other types of red meat or products containing red meat.
        //Health  Sesame-free sesame-free does not contain sesame seed or derivatives
        //Health  Shellfish   shellfish-free  No shellfish or shellfish derivatives
        //Health  Soy soy-free    No soy or products containing soy
        //Health  Sugar-conscious sugar-conscious Less than 4g of sugar per serving
        //Health  Tree Nuts   tree-nut-free   No tree nuts or products containing tree nuts
        //Health  Vegan   vegan   No meat, poultry, fish, dairy, eggs or honey
        //Health  Vegetarian  vegetarian  No meat, poultry, or fish
    }
}