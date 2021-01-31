using AutoMapper;
using AutoMapper.QueryableExtensions;
using Fooddb.Application.DTOs.Ingredient;
using Fooddb.Application.Interfaces;
using Fooddb.Domain.Interfaces;
using Fooddb.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fooddb.Application.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IFooddbRepository<Ingredient> _repository;
        private readonly IMapper _mapper;

        public IngredientService(IFooddbRepository<Ingredient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public int Add(IngredientDto newIngredient)
        {
            throw new NotImplementedException();
        }

        public int Edit(IngredientDto ingredient)
        {
            throw new NotImplementedException();
        }

        public IngredientDto Get(int ingredientId)
        {
            return _mapper.Map<IngredientDto>(_repository.GetById(ingredientId));
        }

        public List<IngredientDto> GetAll()
        {
            return _repository.GetAll().ProjectTo<IngredientDto>(_mapper.ConfigurationProvider).ToList();
        }

        public void Remove(int ingredientId)
        {
            throw new NotImplementedException();
        }
    }
}
