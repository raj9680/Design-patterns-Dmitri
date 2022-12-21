using Factory.Product;

namespace Factory.Factory
{
    interface IIcecreamFactory
    {
        IIcecream GetIcecream(string voiceInput);
    }
}
