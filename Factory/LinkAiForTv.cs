namespace Factory
{
    class LinkAiForTv : IProduct
    {
        private double _baseProductPrice;

        public LinkAiForTv()
        {
            _baseProductPrice = 900;
        }

        public double CalculatePice(ProductParameterDTO parameters)
        {
            return parameters.AnalyzerModule ? _baseProductPrice * 2 : _baseProductPrice;
        }
    }
}
