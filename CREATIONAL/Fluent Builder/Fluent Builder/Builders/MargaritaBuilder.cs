using Builder.Product;

namespace Builder.Builders
{
    class MargaritaBuilder: IPizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();
        public IPizzaBuilder SetName(string name)
        {
            _pizza.Name = name;
            return this;
        }


        public IPizzaBuilder SetPrice()
        {
            _pizza.Price = 400;
            return this;
        }


        public IPizzaBuilder SetDescription()
        {
            _pizza.Description = "Margarita medium size pizza";
            return this;
        }


        public IPizzaBuilder SetToppings()
        {
            _pizza.Toppings = new[] { "Tomato", "Cheese" };
            return this;
        }


        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
