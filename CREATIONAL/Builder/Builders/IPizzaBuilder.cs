using Builder.Product;

namespace Builder.Builders
{
    public interface IPizzaBuilder
    {
        void SetName();
        void SetPrice();
        void SetDescription();
        void SetToppings();
        Pizza GetPizza();
    }
}
