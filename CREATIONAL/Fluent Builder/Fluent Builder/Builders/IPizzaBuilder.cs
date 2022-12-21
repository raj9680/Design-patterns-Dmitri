using Builder.Product;

namespace Builder.Builders
{
    public interface IPizzaBuilder // Fluent Builder
    {
        IPizzaBuilder SetName(string name);
        IPizzaBuilder SetPrice();
        IPizzaBuilder SetDescription();
        IPizzaBuilder SetToppings();
        Pizza GetPizza();
    }
}
