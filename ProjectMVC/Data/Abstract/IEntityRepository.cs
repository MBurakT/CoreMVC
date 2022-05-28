using ProjectMVC.Models.Abstract;
using System.Linq.Expressions;

namespace ProjectMVC.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T>? GetList(Expression<Func<T, bool>>? filter);

        T? Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}
