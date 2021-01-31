using AutoMapper;
using Fooddb.Application.Mapping;

namespace Fooddb.Application.DTOs.Ingredient
{
    public class IngredientDto : IMapFrom<Fooddb.Domain.Model.Ingredient>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbohydrates { get; set; }
        public IngredientCategoryDto Category { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Fooddb.Domain.Model.Ingredient, IngredientDto>().ReverseMap();
        }
    }
}
