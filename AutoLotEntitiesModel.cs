namespace Petrean_Beatrice_Lab6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutoLotEntitiesModel : DbContext
    {
        public AutoLotEntitiesModel()
            : base("name=AutoLotEntitiesModel")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Iventory> Iventories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Iventory>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Iventory)
                .WillCascadeOnDelete();
        }
    }
}
