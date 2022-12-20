using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

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
