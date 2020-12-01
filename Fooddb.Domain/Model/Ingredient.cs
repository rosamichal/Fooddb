using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fooddb.Domain.Model
{
    public class Ingredient : BaseEntity
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Białko")]
        public decimal Protein { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Tłuszcz")]
        public decimal Fat { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Węglowodany")]
        public decimal Carbohydrates { get; set; }

        [Required]
        [Display(Name = "Wartość energetyczna")]
        public decimal Energy => 4 * (this.Protein + this.Carbohydrates) + 9 * this.Fat;

        [Display(Name = "Stosunek ketogenny")]
        public decimal? Ratio => this.Fat == 0 ? 0m : (this.Protein + this.Carbohydrates) == 0 ? 
            (decimal?)null : 
            Math.Round(this.Fat / (this.Protein + this.Carbohydrates), 1);

        [Required]
        public int IngredientCategoryId { get; set; }

        public IngredientCategory Category { get; set; }
        public List<RecipeIngredientListItem> Recipes { get; set; }
    }
}
