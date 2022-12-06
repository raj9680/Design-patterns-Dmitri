using System;
using System.Collections.Generic;

// Definition of Open Closed Principle
/*

Requirement 2: We want to filter product by Color.
Requirement 3: We want to filter product by both Color and Size.

As the requirements keeps on coming we are modifying out ProductFilter class i.e we are violating the Open Closed Principle which states
that a class should always be open for extension but closed for modification. But here we are not extending but modifying the class
feature again and again which is not recommended.
*/
namespace Open_Closed_Principle1
{
    class Program
    {

        public enum Color
        {
            Red, Green, Blue
        }
        public enum Size
        {
            Small, Medium, Large
        }


        public class Product
        {
            public string Name;
            public Color Color;
            public Size Size;

            public Product(string name, Color color, Size size)
            {
                if (name == null)
                    throw new ArgumentNullException(paramName: nameof(name));

                Name = name;
                Color = color;
                Size = size;
            }
        }


        /// Open Closed Principle Approach
        public interface ISpecification<T>
        {
            bool IsSatisfied(T t);
        }

        public interface IFilter<T>
        {
            IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
        }


        // Filter Item By Color
        public class ColorSpecification : ISpecification<Product>
        {
            Color color;
            public ColorSpecification(Color color)
            {
                this.color = color;
            }
            public bool IsSatisfied(Product t)
            {
                return t.Color == color;
            }
        }
        // End


        // Filter Item By Size
        public class SizeSpecification : ISpecification<Product>
        {
            Size size;
            public SizeSpecification(Size size)
            {
                this.size = size;
            }
            public bool IsSatisfied(Product t)
            {
                return t.Size == size;
            }
        }
        // End


        // For Both Size and Color
        public class AndSpecification<T> : ISpecification<T>
        {
            private ISpecification<T> first, second;

            public AndSpecification(ISpecification<T> first, ISpecification<T> second)
            {
                this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
                this.second = first ?? throw new ArgumentNullException(paramName: nameof(second));
            }

            public bool IsSatisfied(T t)
            {
                return first.IsSatisfied(t) && second.IsSatisfied(t);
            }
        }

        public class BetterFilter : IFilter<Product>
        {
            public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
            {
                foreach (var i in items)
                    if (spec.IsSatisfied(i))
                        yield return i;
            }
        }

        /// End


        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var bf = new BetterFilter();

            // For Color

            //Console.WriteLine("Green Products by Color: ");
            //foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            //    Console.WriteLine($"- {p.Name} is {p.Color}");


            // For Size

            //Console.WriteLine("Green Products by Size: ");
            //foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            //    Console.WriteLine($"- {p.Name} is {p.Color}");


            // For both size & Color
            Console.WriteLine("Products by Size & Color: ");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($"- {p.Name} is {p.Color} and {p.Size}");
            }
                
        }
    }
}
