using System;


/* Prototype Introduction
 * Prototype Introduction: The main intent of the pattern is to allow you to create copies of an already created instance.
 * 
 * 
 * In this design pattern, Instead of creating object from scratch every time, you can make copies of an original instance and modify it as required. This pattern is unique among the other design patterns as it doesn't require a class but only an end object.
 *  
 *  When to choose prototype design pattern:
 *  1). Creating an object is an expensive operation and it would be more efficient to copy an object.
 *  2). System should be independent of how its products are created, composed and represented.
 *  3). Objects are required that are similar to existing objects.
 *  4). We need to hide the complexity of creating new instance from the client.
 */
namespace Prototype
{
    class Members
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Members(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Members member = new Members("Raj", 25);
            Console.WriteLine($"Name: {member.Name}, Age: {member.Age}");

            
        }
    }
}
