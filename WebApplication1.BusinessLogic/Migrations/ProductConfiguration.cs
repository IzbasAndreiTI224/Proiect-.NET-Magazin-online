namespace WebApplication1.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class ProductConfiguration : DbMigrationsConfiguration<WebApplication1.BusinessLogic.MainBL.ProductContext>
    {
        public ProductConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication1.BusinessLogic.MainBL.ProductContext context)
        {
            // Metoda Seed, dacă este necesar
        }
    }
}
