using System;

namespace Interface_Segregation_Principle1 // Good
{
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
    }

    public interface IOldMachine
    {
        void Scan(Document d);
        void Fax(Document d);
    }


    // MultiFunctionPrinter can have to inherit from IMachine & IOldMachine
    public class MultiFunctionPrinter : IMachine, IOldMachine
    {
        public void Fax(Document d)
        {
            // Can Fax
        }

        public void Print(Document d)
        {
            // Can Print
        }

        public void Scan(Document d)
        {
            // Can Scan
        }
    }


    // OldFashionedPrinter can only need to inherit from IMachine
    public class OldFashionedPrint : IMachine
    {
        public void Print(Document d)
        {
            // Can Print
        }
    }



    // Mains
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
