using System.Data.Entity;

namespace DataBase
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext() : base("DeliveryFoodDB") 
        {
            //Database.SetInitializer<DeliveryContext>(new DropCreateDatabaseAlways<DeliveryContext>());
            Configuration.LazyLoadingEnabled = false; 
        }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Set> Sets { get; set; }

        private void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Delivery>()
                .HasMany(c => c.Foods)
                .WithOptional(o => o.Delivery);
            modelBuilder.Entity<Delivery>()
                .HasMany(c => c.Sets)
                .WithOptional(o => o.Delivery);
            modelBuilder.Entity<Set>()
                .HasMany(c => c.foods)
                .WithOptional(o => o.Set);
        }
    }
}
