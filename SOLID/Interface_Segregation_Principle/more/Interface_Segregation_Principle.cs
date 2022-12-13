using System;

namespace Interface_Segregation_Principle // Bad
{
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }


    // MultiFunctionPrinter can have all the functionalities of IMachine
    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            // Can Fax Document
        }

        public void Print(Document d)
        {
            // Can Print Document
        }

        public void Scan(Document d)
        {
            // Can Scan Document
        }
    }


    // OldFashionedPrinter cannot have Fax and Scan feature, but we're forced to implement as the part of IMachine
    // to solve this kind of problem we use Interface Segregation Principle ( Means to have more interfaces with little features instead
    // of one big interface carrying all features.
    public class OldFashionedPrint : IMachine
    {
        public void Print(Document d)
        {
            // Can Print
        }

        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }  // cannot Fax but still method implemented -> Bad approach

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }  // cannot Scan but still method implemented -> bad approach
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
