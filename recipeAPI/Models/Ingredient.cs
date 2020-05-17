using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace recipeAPI.Models
{
    public class Ingredient
    {
        [Description("Ontology identifier")]
        public string URI { get; set; }

        [Description("Quantity of specified measure")]
        public float Quantity { get; set; }
        [Description("Measure")]
        public Measure Measure { get; set; }
        [Description("Total Weight, g")]
        public float Weight { get; set; }
        [Description("Food")]
        public Food Food { get; set; }
    }

    public class NutrientInfo
    {
        [Description("Ontology identifier")]
        public string URI { get; set; }

        [Description("NutrientInfo Name")]
        public string Label { get; set; }

        [Description("Quantity of specified units")]
        public float Quantity { get; set; }

        [Description("Units")]
        public string Unit { get; set; }
    }

    public class Measure
    {
        [Description("Ontology identifier")]
        public string URI { get; set; }

        [Description("Measure Name")]
        public string Label { get; set; }
    }

    public class Food
    {
        [Description("Ontology identifier")]
        public string URI { get; set; }

        [Description("Food Name")]
        public string Label { get; set; }
    }
}