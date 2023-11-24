using confectionerystore;
using System;
namespace Inventory_store.Model
{

    enum BakingCategory
    {
        Bread, Cake, Pastry, Cookie
    }

    record BakeryProduct(string ProductName, decimal Price, BakingCategory Category);

    interface IBakeryActions
    {
        public void AddProduct(BakeryProduct product);                  // Method to add a product to the store
        public void DisplayProducts();                                  // Method showing information about products in the store
    }

    class BakingStore : IBakeryActions
    {
        List<BakeryProduct> products;

        public string StoreName { get; set; }


        public BakingStore(string storeName)                  // Constructor    
        {
            StoreName = storeName;
            products = new List<BakeryProduct>();
        }
        public void AddProduct(BakeryProduct product)        // Method to add a product to the store
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine($"Products in {StoreName}:");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductName}, Category: {product.Category}, Price: N{product.Price}");
            }
        }
    }

}
