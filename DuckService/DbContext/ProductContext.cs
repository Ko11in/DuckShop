using DuckService.Models;
using DuckService.SourceClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;


namespace DuckService.DB
{
    public class ProductContext:System.Data.Entity.DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Rule> Rules { get; set; }

        public ProductContext(string connectionstring)
            :base("DBConnection")
        {
            Database.SetInitializer<ProductContext>(new ProductContextInitializer());
        }
    }
    public class ProductContextInitializer:DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Утка белая", 10, DuckColors.White,10));
            products.Add(new Product("Утка черная", 10, DuckColors.Black, 10));
            products.Add(new Product("Утка синяя", 10, DuckColors.Blue, 10));
            products.Add(new Product("Утка желтая", 10, DuckColors.Yellow, 10));
            context.Products.AddRange(products);

            Rule rule = new Rule();
            rule.Products = new List<Product>();
            rule.Products.Add(products.FirstOrDefault(x => x.Color == DuckColors.Black));
            rule.Products.Add(products.FirstOrDefault(x => x.Color == DuckColors.White));
            rule.Quantity = -1;
            context.Rules.Add(rule);

            foreach(DuckColors color in Enum.GetValues(typeof(DuckColors)))
            {
                rule = new Rule();
                rule.Products = new List<Product>();

                var prod = products.FirstOrDefault(x => x.Color == color);
                rule.Products.Add(prod);
                rule.Quantity = 3;
                rule.Discount = 10;
                context.Rules.Add(rule);
            }
            context.SaveChanges();
            var rules = DuckShopContext.context.Rules.ToList();
        }
    }
}