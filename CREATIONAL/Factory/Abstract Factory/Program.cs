using System;
using System.Collections.Generic;

/* Use of Abstract Factory
 * The real use of abstract factory is to give out abstract object as opossed to concrete object
 * Note: In abstract we will not return the actual type, but we return the abstract object or interface object
 */

/* Example - Info
 * Ler's suppose we have a machine which makes tea and coffee. But we want give the user an ability to consume a drink without holdingonto its actual time. So the user asks for a particular drink. They might say, well I want a cup of tea, but we don't give them an object of type tea instead we give them an interface.
 */
namespace Abstract_Factory
{
    public interface IHotDrink
    {
        void Consume();
    }

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This is nice but I'd prefer with milk.");
        }
    }
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }




    /* Different Factories for tea and coffee
     */
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a tea bag of amount {amount} to prepare Tea");
            return new Tea();
        }
    }
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a coffee bag of amount {amount} to prepare Coffee");
            return new Coffee();
        }
    }




    public class HotDrinkMachine
    {
        public enum AvalableDrink { Coffee, Tea }
        private Dictionary<AvalableDrink, IHotDrinkFactory> factories = new Dictionary<AvalableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvalableDrink drink in Enum.GetValues(typeof(AvalableDrink)))
            {
                var factory = (IHotDrinkFactory) Activator.CreateInstance(
                    Type.GetType("DesignPatterns." + Enum.GetName(typeof(AvalableDrink), drink) + "Factory")
                    );
                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvalableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvalableDrink.Tea, 100);
            drink.Consume();
        }
    }
}
