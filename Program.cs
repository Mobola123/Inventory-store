namespace confectionerystore;
using Inventory_store.Model;
class Program
{
    public static void Main(string[] args)
    {
        
        BakingStore myBakery = new BakingStore("Mobola Confectioneries");
        Console.WriteLine($"Welcome to {myBakery.StoreName}!");

        myBakery.AddProduct(new BakeryProduct("Sweetened coconut bread", 3.50m, BakingCategory.Bread));
        myBakery.AddProduct(new BakeryProduct("Chocolate Cake", 25.99m, BakingCategory.Cake));
        myBakery.AddProduct(new BakeryProduct("Meatpie", 4.95m, BakingCategory.Pastry));
        myBakery.AddProduct(new BakeryProduct("Double chocoCookies", 8.99m, BakingCategory.Cookie));

        myBakery.DisplayProducts();
    }
}
