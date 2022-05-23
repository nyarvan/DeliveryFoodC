using System;
using DataBase;
using Repository;

namespace UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DeliveryContext context;
        public UnitOfWork()
        {
            context = new DeliveryContext();
        }
        private IGenericRepository<Delivery> DeliveryRepository;
        private IGenericRepository<Food> FoodRepository;
        private IGenericRepository<Set> SetRepository;

        public IGenericRepository<Delivery> Deliveries 
        {
            get 
            {
                if (DeliveryRepository == null)
                    DeliveryRepository = new ContextRepository<Delivery>(context);
                return DeliveryRepository;
            }
        }
        public IGenericRepository<Food> Foods
        {
            get
            {
                if (FoodRepository == null)
                    FoodRepository = new ContextRepository<Food>(context);
                return FoodRepository;
            }
        }
        public IGenericRepository<Set> Sets
        {
            get
            {
                if (SetRepository == null)
                    SetRepository = new ContextRepository<Set>(context);
                return SetRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
