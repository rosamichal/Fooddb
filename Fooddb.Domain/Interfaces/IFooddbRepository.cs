using Fooddb.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fooddb.Domain.Interfaces
{
    public interface IFooddbRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
