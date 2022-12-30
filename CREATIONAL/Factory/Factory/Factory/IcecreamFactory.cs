using Factory.Product;
using System;

/* Factory is responsible for creating the object based on client call */
namespace Factory.Factory
{
    class IcecreamFactory : IIcecreamFactory
    {
        public IIcecream GetIcecream(string voiceInput)
        {
            if (voiceInput.Contains("choc"))
                return new ChocolateIcecream();

            else if (voiceInput.Contains("van"))
                return new VanillaIcecream();

            else if (voiceInput.Contains("butter"))
                return new ButterScotchIcecream();

            else
                throw new ArgumentException("Item not present");
        }
    }
}