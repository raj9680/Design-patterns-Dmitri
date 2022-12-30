using System;
using System.Threading.Tasks;

/// Factory Method + Asynchronous call
namespace Asynchronous_Factory_Method
{
    public class foo
    {
        /* Using async is not allowed with constructor
  
        public foo()
        {
            await Task.Delay(1000);
        }
        */


        private foo()
        {
            //
        }

        private async Task<foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<foo> CreateAsync()
        {
            var result = new foo();
            return result.InitAsync();
        }
    }



    class Program
    {
        public static async Task Main(string[] args)   // Main method types changed to async
        {
            foo x = await foo.CreateAsync();
        }
    }
}
