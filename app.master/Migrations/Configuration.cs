namespace app.master.Migrations
{
    using app.master.models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using app.master.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Product.AddOrUpdate(
                new Product { ProductId = 1, Name = "Milanesa napolitana", UnitPrice = 0, Code = "PR01", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now },
                new Product { ProductId = 2, Name = "Hamburguesa simple", UnitPrice = 0, Code = "PR02", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now },
                new Product { ProductId = 3, Name = "Sanguche de vacio", UnitPrice = 0, Code = "PR03", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now },
                new Product { ProductId = 4, Name = "Lomito de ternera", UnitPrice = 0, Code = "PR04", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now },
                new Product { ProductId = 5, Name = "Ensalada rusa", UnitPrice = 0, Code = "PR05", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now },
                new Product { ProductId = 6, Name = "Jugo de naranja", UnitPrice = 0, Code = "PR06", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now },
                new Product { ProductId = 7, Name = "Manaos 5 lts", UnitPrice = 0, Code = "PR07", AsSale = true, AsInput = false, Observation = "", CreationTime = DateTime.Now }
            );

            context.Order.AddOrUpdate(
                new Order { OrderId = 1, OrderDate = DateTime.Now, ShipAdress = "st 199 br 01", CreationTime = DateTime.Now },
                new Order { OrderId = 2, OrderDate = DateTime.Now, ShipAdress = "st 100 br 01", CreationTime = DateTime.Now },
                new Order { OrderId = 3, OrderDate = DateTime.Now, ShipAdress = "st 045 br 02", CreationTime = DateTime.Now },
                new Order { OrderId = 4, OrderDate = DateTime.Now, ShipAdress = "st 234 br 11", CreationTime = DateTime.Now }
            );

            context.Category.AddOrUpdate(
                new Category { CategoryId = 1, Name = "Comidas", Description = "Comidas al plato y para llevar" },
                new Category { CategoryId = 2, Name = "Bebidas", Description = "Gaseosas y jugos" },
                new Category { CategoryId = 3, Name = "Ensaladas", Description = "Guarnicion para comidas" }
            );

            context.ProductCategory.AddOrUpdate(
                new ProductCategory { CategoryId = 1, ProductId = 1 },
                new ProductCategory { CategoryId = 1, ProductId = 2 },
                new ProductCategory { CategoryId = 1, ProductId = 3 },
                new ProductCategory { CategoryId = 2, ProductId = 5 },
                new ProductCategory { CategoryId = 2, ProductId = 6 },
                new ProductCategory { CategoryId = 3, ProductId = 7 }
            );
        }
    }
}
