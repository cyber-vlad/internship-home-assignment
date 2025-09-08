using ProductManagement.Enums;

namespace ProductManagement.Entities
{
    public class Product
    {
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required int StockQuantity { get; set; }
        public required DateTime ManufactureDate { get; set; }
        public required ProductCategory Category { get; set; }

        public void DisplayProductInfo()
        {
            Console.WriteLine("\nProduct info");
            Console.WriteLine($"Product: {Name}, Price: {Price:f3}, Stock: {StockQuantity}, Manufacture Date: {ManufactureDate:dd-MM-yyyy}");
        }

        public static Product CreateProduct()
        {
            Console.WriteLine("__ The process of creating the product __\n");

            Console.Write(">> Enter product name: ");
            string name = Console.ReadLine()!;

            decimal price;
            Console.Write(">> Enter product price: ");
            while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Invalid price");
                Console.Write(">> Enter product price: ");
            }

            int stock;
            Console.Write(">> Enter stock quantity: ");
            while (!int.TryParse(Console.ReadLine(), out stock) || stock <= 0)
            {
                Console.WriteLine("Invalid stock quantity");
                Console.Write(">> Enter stock quantity: ");
            }

            Console.WriteLine("Categories");
            foreach (var c in Enum.GetValues(typeof(ProductCategory)))
            {
                Console.WriteLine($" {c}");
            }

            ProductCategory category;
            Console.Write(">> Enter product category: ");
            while (!Enum.TryParse(Console.ReadLine(), out category) || !Enum.IsDefined(typeof(ProductCategory), category))
            {
                Console.WriteLine("Invalid product category");
                Console.Write(">> Enter product category: ");
            }

            DateTime date;
            Console.Write(">> Enter manufacture date: ");
            while (!DateTime.TryParse(Console.ReadLine(), out date) || date > DateTime.Today)
            {
                Console.WriteLine("Invalid manufacture date");
                Console.Write(">> Enter manufacture date: ");
            }

            return new Product
            {
                Name = name,
                Price = price,
                StockQuantity = stock,
                Category = category,
                ManufactureDate = date,
            };
        }
    }
}
