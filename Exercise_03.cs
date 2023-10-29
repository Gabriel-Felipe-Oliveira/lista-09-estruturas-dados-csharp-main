using System;
using System.Collections;

public class Exercise_03
{
    public void run()
    {
        Hashtable shoppingCart = new Hashtable();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a product to the cart");
            Console.WriteLine("2. View cart");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the product name: ");
                    string productName = Console.ReadLine();

                    if (shoppingCart.ContainsKey(productName))
                    {
                        Console.WriteLine("Product already in the cart. Adding another.");
                        shoppingCart[productName] = (double)shoppingCart[productName] + GetProductPrice(productName);
                    }
                    else
                    {
                        double productPrice = GetProductPrice(productName);
                        if (productPrice > 0)
                            shoppingCart[productName] = productPrice;
                        else
                            Console.WriteLine("Product not found.");
                    }
                    break;

                case 2:
                    if (shoppingCart.Count == 0)
                    {
                        Console.WriteLine("Your cart is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Cart Contents:");
                        foreach (DictionaryEntry entry in shoppingCart)
                        {
                            Console.WriteLine($"{entry.Key} - ${entry.Value:F2}");
                        }
                    }
                    break;

                case 3:
                    double total = CalculateTotal(shoppingCart);
                    Console.WriteLine($"Total amount to be paid: ${total:F2}");
                    shoppingCart.Clear();
                    break;

                case 4:
                    Console.WriteLine("Thank you for shopping with us. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static double GetProductPrice(string productName)
    {
        switch (productName.ToLower())
        {
            case "item1":
                return 10.0;
            case "item2":
                return 15.0;
            case "item3":
                return 20.0;
            default:
                return 0.0;
        }
    }

    static double CalculateTotal(Hashtable cart)
    {
        double total = 0;
        foreach (DictionaryEntry entry in cart)
        {
            total += (double)entry.Value;
        }
        return total;
    }
}
