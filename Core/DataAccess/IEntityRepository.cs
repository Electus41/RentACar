
using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class , IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter );

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        List<T>GetCarsByDailPrice(decimal min, decimal max);
        List<T> GetCarsByBrandId(int BrandId);



    }
    
    
}
