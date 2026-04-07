using Assignment2.Models;

namespace Assignment2.Services;


public static class SearchService
{
    /// <summary>
    /// Task 01: Smart Product Search
    /// Uses Func<Product, bool> delegate to enable flexible filtering
    /// </summary>
    public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        List<Product> results = new List<Product>();

        foreach (var product in products)
        {
            if (filter(product))
            {
                results.Add(product);
            }
        }

        return results;
    }

    public static void PrintProducts(List<Product> products, string header)
    {
        Console.WriteLine($"--- {header} ---");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}
