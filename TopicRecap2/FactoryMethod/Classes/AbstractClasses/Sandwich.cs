using System.Collections.Generic;

namespace FactoryMethod.Classes.AbstractClasses
{
    /// <summary>
    /// Creator
    /// </summary>
    abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }
    }
}