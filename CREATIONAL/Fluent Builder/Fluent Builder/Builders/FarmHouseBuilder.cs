using Builder.Product;

namespace Builder.Builders
{
    class FarmHouseBuilder: IPizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();
        public IPizzaBuilder SetName(string name)
        {
            _pizza.Name = name;
            return this; // Fluent Builder
        }


        public IPizzaBuilder SetPrice()
        {
            _pizza.Price = 500;
            return this;
        }


        public IPizzaBuilder SetDescription()
        {
            _pizza.Description = "Farm House medium size pizza";
            return this;
        }


        public IPizzaBuilder SetToppings()
        {
            _pizza.Toppings = new[] { "Tomato", "Capsicum", "Mushroom", "Cheese" };
            return this;
        }


        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
