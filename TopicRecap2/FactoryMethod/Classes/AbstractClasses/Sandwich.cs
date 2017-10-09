using System.Collections.Generic;

namespace FactoryMethod.Classes.AbstractClasses
{
    /// <summary>
    /// Creator
    /// </summary>
    abstract class Sandwich
    {
        public List<Ingredient> Ingredients { get; private set; }

        public Sandwich()
        {
            Ingredients = new List<Ingredient>();
            CreateIngredients();
        }

        public abstract void CreateIngredients();
        
    }
}