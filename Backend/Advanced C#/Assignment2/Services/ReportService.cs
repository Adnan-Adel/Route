using Assignment2.Models;

namespace Assignment2.Services;


public static class ReportService
{
    /// <summary>
    /// Task 3.1: Print Reports
    /// Uses Action<Product> delegate - takes Product, returns void
    /// Caller controls the format through lambda expression
    /// </summary>
    public static void PrintReport(List<Product> products, Action<Product> reportAction)
    {
        foreach (var product in products)
        {
            reportAction(product);
        }
    }

    /// <summary>
    /// Task 3.2: Transform Products
    /// Uses Func<Product, string> delegate - takes Product, returns string
    /// Transforms each product into a different format
    /// </summary>
    public static List<string> TransformProducts(List<Product> products, Func<Product, string> transformer)
    {
        List<string> results = new List<string>();

        foreach (var product in products)
        {
            results.Add(transformer(product));
        }

        return results;
    }

    /// <summary>
    /// Task 3.3: Filter Products
    /// Uses Predicate<Product> delegate - takes Product, returns bool
    /// Predicate is specifically designed for true/false tests
    /// </summary>
    public static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
    {
        List<Product> results = new List<Product>();

        foreach (var product in products)
        {
            if (condition(product))
            {
                results.Add(product);
            }
        }

        return results;
    }
}
