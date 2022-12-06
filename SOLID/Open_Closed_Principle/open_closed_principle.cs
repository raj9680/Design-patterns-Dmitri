using System;
using System.Collections.Generic;

// Definition of Open Closed Principle
/*
Requirement 1: Hey please create a module which filters product by Color.
Requirement 2: We also want a product to filter by Size.
Requirement 3: We want to filter product by both Color and Size.

As the requirements keeps on coming we are modifying out ProductFilter class i.e we are violating the Open Closed Principle which states
that a class should always be open for extension but closed for modification. But here we are not extending but modifying the class
feature again and again which is not recommended.
*/
namespace Open_Closed_Principle
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
            // Requirement 1 - Entity
            public Color Color;
            // Requirement 2 - Entity
            public Size Size;

            // CTOR for initialing Product fields
            public Product(string name, Color color, Size size)
            {
                if (name == null)
                    throw new ArgumentNullException(paramName: nameof(name));

                Name = name;
                Color = color;
                Size = size;
            }
        }


        public class ProductFilter
        {
            // Requirement 1 - Method
            public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
            {
                foreach (var p in products)
                    if (p.Size == size)
                        yield return p;
            }


            // Requirement 1 - Method
            public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
            {
                foreach (var p in products)
                    if (p.Color == color)
                        yield return p;
            }

            // Requirement 2 - Method
            public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Color color, Size size)
            {
                foreach (var p in products)
                    if (p.Color == color && p.Size == size)
                        yield return p;
            }
        }


        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };
            var pf = new ProductFilter();

            foreach (var p in pf.FilterByColor(products, Color.Green))
                Console.WriteLine($" - {p.Name} is {p.Color}");
        }
    }
}
