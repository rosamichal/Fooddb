using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fooddb.Domain.Model
{
    public class IngredientCategory : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
