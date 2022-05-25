using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameter = new ProductParameterDTO()
            {
                ProductType = 2,
                AnalyzerModule = true,
                Channel = "Youtube"
            };

            var product = new ProductFactory(parameter).CreateProduct();
            var price = product.CalculatePice(parameter);

            Console.WriteLine($"The price for {product.GetType().Name} is: {price}");
        }
    }
}
