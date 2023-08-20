using System;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Interfaces
{
    public interface IRepository<in T> : IDisposable where T : IEntity
    {
        int SaveChanges();
        void Add(T entity);
        void Update(T entity);
    }
}
