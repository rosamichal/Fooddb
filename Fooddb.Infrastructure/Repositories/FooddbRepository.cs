using Fooddb.Domain.Interfaces;
using Fooddb.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fooddb.Infrastructure.Repositories
{
    public class FooddbRepository<T> : IFooddbRepository<T> where T : BaseEntity
    {
        private readonly Context _context;
        private DbSet<T> entities;

        public FooddbRepository(Context context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public void Delete(int id)
        {
            T deletedEntity = entities.SingleOrDefault(o => o.Id == id);
            if (deletedEntity != null)
            {
                entities.Remove(deletedEntity);
                _context.SaveChanges();
            }
        }

        public IQueryable<T> GetAll()
        {
            return entities;
        }

        public T GetById(int id)
        {
            return entities.SingleOrDefault(o => o.Id == id);
        }

        public int Insert(T entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
