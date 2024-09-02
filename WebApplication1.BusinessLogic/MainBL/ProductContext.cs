using System.Data.Entity;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.MainBL
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=WebApplication2") { }

        public DbSet<Product> Products { get; set; } // Creează tabela

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurațiuni suplimentare pentru modelul de date, dacă este necesar
            base.OnModelCreating(modelBuilder);
        }
    }
}

