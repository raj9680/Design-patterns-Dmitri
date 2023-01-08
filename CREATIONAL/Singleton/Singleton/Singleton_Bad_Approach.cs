using System;

/* Singleton Design Pattern
 * 1). The singleton design pattern is a design pattern that restricts the instantiation of a class to one "single" object.
 * 2). Throughout the lifetime of the application the instance will remain same.
 * 3). Class should be sealed and its constructor should be private.
 * 4). Instance should be requested instead of created.
*/
namespace Singleton1
{
    public class Singleton
    {
        private static int counter = 0;
        public Singleton()
        {
            counter++;
            Console.WriteLine($"Object {counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }


    // Mains 
    class Programm
    {
        static void Mains(string[] args)
        {
            Singleton m = new Singleton();
            m.PrintDetails("Hello 1");      // Object 1
                                            // Hello 1

            Singleton m1 = new Singleton();
            m.PrintDetails("Hello 2");      // Object 2
                                            // Hello 2

        }
    }
}
        /* For Singleton pattern conventions, we should have only 1 object for all classes to access, but here two classes we are creating two objects. Let's say m & m1 are two classes.
         */