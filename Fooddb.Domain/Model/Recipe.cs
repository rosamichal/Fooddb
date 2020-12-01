using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Fooddb.Domain.Model
{
    public class Recipe : BaseEntity
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Data utworzenia")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Tłuszcz")]
        public decimal Fat => Ingredients.Sum(i => i.Ingredient.Fat * i.Weight / 100);

        [Display(Name = "Białko")]
        public decimal Protein => Ingredients.Sum(i => i.Ingredient.Protein * i.Weight / 100);

        [Display(Name = "Węglowodany")]
        public decimal Carbohydrates => Ingredients.Sum(i => i.Ingredient.Carbohydrates * i.Weight / 100);

        [Display(Name = "Wartość energetyczna")]
        public decimal Energy => Fat * 9 + (Protein + Carbohydrates) * 4;

        [Display(Name = "Stosunek ketogenny")]
        public decimal? Ratio => (this.Protein + this.Carbohydrates) == 0 ? (decimal?)null : Math.Round(this.Fat / (this.Protein + this.Carbohydrates), 1);

        [Display(Name = "Opis")]
        public string Description { get; set; }

        public List<RecipeIngredientListItem> Ingredients { get; set; }
    }
}
