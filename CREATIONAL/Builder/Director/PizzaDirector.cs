using Builder.Builders;
using Builder.Product;

namespace Builder.Director
{
    class PizzaDirector // Directors role is to taking the builder object & executing the process step by step
    {
        public Pizza Build(IPizzaBuilder builder) // Dependency Injection in Action
        {
            builder.SetName();
            builder.SetPrice();
            builder.SetDescription();
            builder.SetToppings();

            return builder.GetPizza();
        }
    }
}
