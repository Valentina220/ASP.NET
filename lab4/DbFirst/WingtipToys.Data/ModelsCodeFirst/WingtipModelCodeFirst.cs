namespace WingtipToys.Data.ModelsCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WingtipModelCodeFirst : DbContext
    {
        public WingtipModelCodeFirst()
            : base("name=WingtipCodeFirst")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         //   modelBuilder.Entity<Manufacturer>()
         //.ToTable("Products")
         //.HasKey(x => new { x.ManufacturerID  })
         //.HasRequired(x => x.Products)
         //   .WithMany()
         //   .HasForeignKey(x => x.ManufacturerID);
        }
       
    }
}
