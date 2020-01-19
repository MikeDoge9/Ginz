using Ginz.Model;
using System.Collections.Generic;

namespace Ginz.Interfaces
{
    public interface IIngrendientRepository
    {
        List<Ingredient> GetIngredients();
        Ingredient GetIngredient(Ingredient ingredient);
        void CreateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
    }
}
