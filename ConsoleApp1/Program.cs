
using ClassLibrary1;
class Program
{
    static void Main()
    {

        try
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddToCart(new Laptop { Name = "Dell XPS", Price = 1500, Count = 2, Processor = "Intel i7" });
            cart.AddToCart(new Smartphone { Name = "iPhone 13", Price = 785, Count = 3, OS = "iOS" });
            cart.AddToCart(new Book { Name = "The Great Gatsby", Price = 15, Count = 5, Author = "F. Scott Fitzgerald" });
            cart.DisplayCart();
            Console.WriteLine($"Total: {cart.CalculateTotal():C}");
        }
        catch (ArgumentException)
        {
            Console.WriteLine($"Invalid argument.");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine($"Null reference error.");
        }


    }

}