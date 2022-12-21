using Factory.Factory;
using Factory.Product;
using System;
using System.Collections.Generic;

/* 
The Factory Method design pattern solves problems like
1). How can an object be created so that subclasses can redefine which class to instantiate?
2). How can a class defer instantiation to subclasses?

Steps: Define an interface for creating an object, but let subclass decide which class to instantiate. The Factory method lets
a class defer instantiation it uses to subclass.
*/
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Flavours = new List<string>()
            {
                "chocoRambo","chocoBar","vaniNation","butteryWorld","scotchButter"
            };

            var baseIceCreamPrice = 25;

            Console.WriteLine(" Available Flavours \n");

            Flavours.ForEach(f => Console.Write(" " + f + " "));

            Console.WriteLine("\n\n Just make a wish \n");

            IIcecreamFactory icecreamFactory = new IcecreamFactory();
            var voiceInput = Console.ReadLine();

            IIcecream selectedIcecream = icecreamFactory.GetIcecream(voiceInput);

            Console.WriteLine($"\n You have to pay: {selectedIcecream.GetPriceMultipler() * baseIceCreamPrice}");
        }
    }
}
