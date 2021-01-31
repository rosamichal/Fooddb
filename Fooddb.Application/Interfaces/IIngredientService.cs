using Fooddb.Application.DTOs.Ingredient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooddb.Application.Interfaces
{
    public interface IIngredientService
    {
        List<IngredientDto> GetAll();
        IngredientDto Get(int ingredientId);
        int Add(IngredientDto newIngredient);
        int Edit(IngredientDto ingredient);
        void Remove(int ingredientId);
    }
}
