using System;
using Repository;
using DataBase;

namespace UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Delivery> Deliveries { get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<Set> Sets { get; }
        void Save();
    }
}
