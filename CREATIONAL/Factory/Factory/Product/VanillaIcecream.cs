namespace Factory.Product
{
    class VanillaIcecream : IIcecream
    {
        public float GetPriceMultipler()
        {
            return 1.5f;
        }
    }
}
