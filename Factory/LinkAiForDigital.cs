using System;

namespace Factory
{
    class LinkAiForDigital : IProduct
    {
        private double _baseProductPrice;

        public LinkAiForDigital()
        {
            _baseProductPrice = 650;
        }

        public double CalculatePice(ProductParameterDTO parameters)
        {
            Console.WriteLine($"The selected channel is: {parameters.Channel}");
            return _baseProductPrice;
        }
    }
}
