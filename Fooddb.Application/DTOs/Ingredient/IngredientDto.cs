namespace Fooddb.Application.DTOs.Ingredient
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbohydrates { get; set; }
        public IngredientCategoryDto Category { get; set; }
    }
}
