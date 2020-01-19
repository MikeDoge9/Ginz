using Ginz.Interfaces;
using Ginz.Model;
using System.Collections.Generic;
using System.Linq;

namespace Ginz.Repositories
{
    public class GinRepository : IGinRepository
    {
        public void CreateGin(Gin gin)
        {
            using (GinzContext context = new GinzContext())
            {
                context.Gins.Add(gin);
                context.SaveChanges();
            }
        }

        public void DeleteGin(Gin gin)
        {
            using(GinzContext context = new GinzContext())
            {
                context.Gins.Remove(gin);
                context.SaveChanges();
            }
        }

        public Gin GetGin(Gin gin)
        {
            throw new System.NotImplementedException();
        }

        public List<Gin> GetGins()
        {
            using (GinzContext context = new GinzContext())
            {
                return context.Gins.ToList();
            }
        }

        public void UpdateGin(Gin gin)
        {
            using (GinzContext context = new GinzContext())
            {
                context.Entry(context.Gins.Where(c => c.Id == gin.Id).First()).CurrentValues.SetValues(gin);
                context.SaveChanges();
            }
        }
    }
}
