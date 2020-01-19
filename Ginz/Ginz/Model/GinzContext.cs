using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginz.Model
{
    public class GinzContext : DbContext
    {
        public GinzContext() : base("name=Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Gin> Gins { get; set; }
        public DbSet <Ingredient> Ingredients { get; set; }
    }
}
