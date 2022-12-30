using Builder.Builders;
using Builder.Product;

namespace Builder.Director
{
    class PizzaDirector // Director role is to taking the builder object & executing the process step by step
    {
        public Pizza Build(IPizzaBuilder builder) // Fluent Builder
        {
            //builder.SetName();  // now calling dynamically as per need
            //builder.SetPrice();
            //builder.SetDescription();
            //builder.SetToppings();

            return builder.GetPizza();
        }
    }
}
