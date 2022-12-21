﻿using Builder.Builders;
using Builder.Director;
using System;

namespace Builder
{
    class Client
    {
        private static void Main(string[] args)
        {
            PizzaDirector pizzaFactory = new PizzaDirector();

            // Fluent Builder
            var selectedPizza = pizzaFactory.Build(new MargaritaBuilder().SetName("Raj").SetPrice().SetDescription());

            if(selectedPizza != null)
                Console.WriteLine($" You have selected {selectedPizza.Name}");


            if(string.IsNullOrEmpty(selectedPizza.Description))
                Console.WriteLine($"\n Description: {selectedPizza.Description}");


            if(selectedPizza.Price > 0)
                Console.WriteLine($"\n Price: {selectedPizza.Price}");


            if(selectedPizza.Toppings != null)
                Console.WriteLine($"\n Toppings: {string.Join(',', selectedPizza.Toppings)}");

        }
    }
}
