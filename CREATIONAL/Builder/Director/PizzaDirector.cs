using Builder.Builders;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Director
{
    class PizzaDirector // Director role is to taking the builder object & executing the process step by step
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
