using Assignment2.Models;
using Assignment2.Services;

namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        // Starter Code: Product Catalog
        List<Product> catalog = new()
        {
            new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
        };

        Console.WriteLine("========== SHOPMASTER BACKEND SYSTEM ==========\n");

        // ============================================
        // TASK 01: SMART PRODUCT SEARCH
        // ============================================
        Console.WriteLine("========== TASK 01: SMART PRODUCT SEARCH ==========\n");

        // Search 1: All Electronics products
        // Using Func<Product, bool> delegate with lambda expression
        var electronics = SearchService.SearchProducts(catalog, p => p.Category == "Electronics");
        SearchService.PrintProducts(electronics, "Electronics");
        Console.WriteLine();

        // Search 2: Products cheaper than $50
        var cheapProducts = SearchService.SearchProducts(catalog, p => p.Price < 50);
        SearchService.PrintProducts(cheapProducts, "Under $50");
        Console.WriteLine();

        // Search 3: Products that are in stock (Stock > 0)
        var inStock = SearchService.SearchProducts(catalog, p => p.Stock > 0);
        SearchService.PrintProducts(inStock, "In Stock");
        Console.WriteLine();

        // Search 4: Clothing products under $100
        var affordableClothing = SearchService.SearchProducts(catalog,
            p => p.Category == "Clothing" && p.Price < 100);
        SearchService.PrintProducts(affordableClothing, "Clothing Under $100");
        Console.WriteLine();

        // ============================================
        // TASK 03: CUSTOM REPORT GENERATOR
        // ============================================
        Console.WriteLine("========== TASK 03: CUSTOM REPORT GENERATOR ==========\n");

        // ============================================
        // 3.1: PRINT REPORTS (using Action<Product>)
        // ============================================

        // Scenario 1: Short Report
        // Action<Product> - takes Product, returns void (just prints)
        Console.WriteLine("--- Short Report ---");
        ReportService.PrintReport(catalog, p =>
            Console.WriteLine($"{p.Name} - ${p.Price}"));
        Console.WriteLine();

        // Scenario 2: Detailed Report
        Console.WriteLine("--- Detailed Report ---");
        ReportService.PrintReport(catalog, p =>
            Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));
        Console.WriteLine();

        // ============================================
        // 3.2: TRANSFORM PRODUCTS (using Func<Product, string>)
        // ============================================

        // Scenario 3: Summary List
        // Func<Product, string> - takes Product, returns string
        var summaryList = ReportService.TransformProducts(catalog,
            p => $"{p.Name} (${p.Price})");

        Console.WriteLine("--- Summary List ---");
        foreach (var summary in summaryList)
        {
            Console.WriteLine(summary);
        }
        Console.WriteLine();

        // Scenario 4: Price Label
        var priceLabels = ReportService.TransformProducts(catalog,
            p => p.Price > 100 ? "Expensive!" : "Affordable");

        Console.WriteLine("--- Price Labels ---");
        for (int i = 0; i < catalog.Count; i++)
        {
            Console.WriteLine($"{catalog[i].Name}: {priceLabels[i]}");
        }
        Console.WriteLine();

        // ============================================
        // 3.3: FILTER PRODUCTS (using Predicate<Product>)
        // ============================================

        // Scenario 5: Low-Stock Alert
        // Predicate<Product> - specifically designed for true/false tests
        var lowStock = ReportService.FilterProducts(catalog, p => p.Stock < 20);

        Console.WriteLine("--- Low-Stock Alert ---");
        foreach (var product in lowStock)
        {
            Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
        }
        Console.WriteLine();

        Console.WriteLine("========== END OF REPORT ==========");
    }
}
