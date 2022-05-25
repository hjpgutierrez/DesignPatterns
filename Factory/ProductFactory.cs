namespace Factory
{
    class ProductFactory
    {
        private readonly ProductParameterDTO _parameters;

        public ProductFactory(ProductParameterDTO parameters)
        {
            _parameters = parameters;
        }

        public IProduct CreateProduct()
        {
            switch (_parameters.ProductType)
            {
                case 1:
                    return new LinkAiForTv();
                case 2:
                    return new LinkAiForDigital();
                default:
                    return null;
            }
        }
    }
}
