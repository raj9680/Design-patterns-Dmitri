using System;

/* Singleton Design Pattern
 * 1). The singleton design pattern is a design pattern that restricts the instantiation of a class to one "single" object.
 * 2). Throughout the lifetime of the application the instance will remain same.
 * 3). Class should be sealed and its constructor should be private.
 * 4). Instance should be requested instead of created.
 * Impirtant Points to Implement Singleton Pattenr
 * 1). A single constructor which is private and parameterless.
 * 2). The class should be sealed to terminate the inheritance.
 * 3). A static variable that holds a reference to the single created instance, if any.
 * 
*/
namespace Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        /* Public Method to access from outside to create instance
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        /* Private Constructor to restrict new object creation from outside
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value "+ counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }


    // Mains 
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton fromEmployee = new Singleton();
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");

            /* Let's say fromEmployee * fromStudent are two outside classed try to create object of Singleton class, but they are * end up creating the same single object. While in Singleton_Bad_Approach we're creating two objects. 
             */
        }
    }
}
