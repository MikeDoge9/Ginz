using Ginz.Interfaces;
using Ginz.Model;
using System.Collections.Generic;
using System.Linq;

namespace Ginz.Repositories
{
    public class IngredientRepository : IIngrendientRepository
    {
        public void CreateIngredient(Ingredient ingredient)
        {
            using (GinzContext context = new GinzContext())
            {
                context.Ingredients.Add(ingredient);
                context.SaveChanges();
            }
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            using (GinzContext context = new GinzContext())
            {
                context.Ingredients.Remove(ingredient);
                context.SaveChanges();
            }
        }

        public Ingredient GetIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public List<Ingredient> GetIngredients()
        {
            using (GinzContext context = new GinzContext())
            {
                return context.Ingredients.ToList();
            }
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            using (GinzContext context = new GinzContext())
            {
                context.Entry(context.Gins.Where(c => c.Id == ingredient.Id).First()).CurrentValues.SetValues(ingredient);
                context.SaveChanges();
            }

        }
    }
}
