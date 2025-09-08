using ProductManagement.Entities;

namespace ProductManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = Product.CreateProduct();
            product.DisplayProductInfo();
        }
    }
}
