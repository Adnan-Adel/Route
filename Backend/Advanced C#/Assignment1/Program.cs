using Assignment1.GenericClasses;
using Assignment1.Utilities;
using Assignment1.Interfaces;
using Assignment1.Constraints;
using Assignment1.Variance;
using Assignment1.Inheritance;

namespace Assignment1;




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Q1: What is a generic class? Why use generics?");
        Console.WriteLine("\nDefinition:");
        Console.WriteLine("A generic class uses type parameters replaced with actual types at instantiation.");
        Console.WriteLine("\nWhy Use Generics:");
        Console.WriteLine("1. Type Safety - Compile-time checking");
        Console.WriteLine("2. Performance - No boxing/unboxing");
        Console.WriteLine("3. Code Reuse - One implementation for all types");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q2: Container<T> with Add and Get");
        Container<int> numbers = new Container<int>();
        numbers.Add(10);
        numbers.Add(20);
        Console.WriteLine($"numbers[0] = {numbers.Get(0)}");

        Container<string> names = new Container<string>();
        names.Add("Ahmed");
        names.Add("Sara");
        Console.WriteLine($"names[1] = {names.Get(1)}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q3: Multiple type parameters - Pair<TKey,TValue>");
        Pair<string, int> person = new Pair<string, int>("Ahmed", 25);
        Console.WriteLine($"{person.Key} is {person.Value} years old");

        var (name, age) = person;
        Console.WriteLine($"Deconstructed: {name}, {age}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q4: Generic method - Swap<T>");
        int num1 = 5, num2 = 10;
        Utilities.Utilities.Swap(ref num1, ref num2);
        Console.WriteLine($"After swap: num1={num1}, num2={num2}");

        string word1 = "hello", word2 = "world";
        Utilities.Utilities.Swap<string>(ref word1, ref word2);
        Console.WriteLine($"After swap: word1={word1}, word2={word2}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q5: FindMax<T> generic method");
        int[] numbers2 = { 3, 7, 2, 9, 1 };
        int max = GenericMethods.FindMax2(numbers2);
        Console.WriteLine($"Max: {max}");

        string maxStr = GenericMethods.FindMax2("apple", "zebra", "banana");
        Console.WriteLine($"Max string: {maxStr}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q6: Generic interface - IRepository<T>");
        IRepository<User> repo = new UserRepository();
        repo.Add(new User { Id = 1, Name = "Ahmed" });
        repo.Add(new User { Id = 2, Name = "Sara" });

        User? user = repo.GetById(1);
        Console.WriteLine($"Found: {user?.Name}");

        Console.WriteLine($"Total users: {repo.GetAll().Count()}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q7: 'struct' constraint");
        Constraints.Nullable<int> age2 = new Constraints.Nullable<int>(25);
        Console.WriteLine($"HasValue: {age2.HasValue}, Value: {age2.Value}");

        Constraints.Nullable<int> empty = new Constraints.Nullable<int>();
        Console.WriteLine($"Empty - HasValue: {empty.HasValue}");
        Console.WriteLine($"GetValueOrDefault: {empty.GetValueOrDefault(18)}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q8: 'class' constraint");
        Cache<string> cache = new Cache<string>();
        cache.Set("Hello");
        Console.WriteLine($"Cached: {cache.Get()}");

        cache.Clear();
        Console.WriteLine($"IsEmpty: {cache.IsEmpty}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q9: 'new()' constraint");
        Factory<Product> factory = new Factory<Product>();
        Product p1 = factory.Create();
        Console.WriteLine($"Created: {p1.Name}");

        List<Product> products = factory.CreateMany(3);
        Console.WriteLine($"Created {products.Count} products");

        Product p2 = factory.CreateAndInitialize(p =>
        {
            p.Name = "Laptop";
            p.Price = 1000;
        });
        Console.WriteLine($"Initialized: {p2.Name}, ${p2.Price}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q10: Interface constraint");
        Sorter<int> sorter = new Sorter<int>();
        int[] arr = { 5, 2, 8, 1, 9 };
        sorter.BubbleSort(arr);
        Console.WriteLine($"Sorted: {string.Join(", ", arr)}");

        int min = sorter.FindMin(arr);
        Console.WriteLine($"Min: {min}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q11: Base class constraint");
        EntityRepository<UserEntity> repo2 = new EntityRepository<UserEntity>();
        repo2.Add(new UserEntity { Name = "Ahmed" });
        repo2.Add(new UserEntity { Name = "Sara" });

        var recent = repo2.GetRecent(7);
        Console.WriteLine($"Recent entities: {recent.Count()}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q12: Multiple constraints");
        Console.WriteLine("Example: where T : class, IEntity, new()");
        Console.WriteLine("Combines class, interface, and constructor constraints");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q13: 'default' keyword in generics");
        Console.WriteLine($"default(int) = {default(int)}");
        Console.WriteLine($"default(bool) = {default(bool)}");
        Console.WriteLine($"default(string) = {default(string) ?? "null"}");
        Console.WriteLine($"default(DateTime) = {default(DateTime)}");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q14: SafeList<T>");
        SafeList<int> numbers3 = new SafeList<int>();
        numbers3.Add(10);
        numbers3.Add(20);
        numbers3.Add(30);

        Console.WriteLine($"numbers[1] = {numbers3[1]}");
        Console.WriteLine($"numbers[10] = {numbers3[10]} (default, no exception!)");

        SafeList<string> names2 = new SafeList<string>();
        names2.Add("Ahmed");
        Console.WriteLine($"names2[0] = {names2[0]}");
        Console.WriteLine($"names2[5] = {names2[5] ?? "null"} (default)");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q15: Covariance ('out' keyword)");
        Console.WriteLine("Allows: Derived → Base (Dog → Animal)");
        Console.WriteLine("Used in: IEnumerable<out T>, Func<out TResult>");
        Console.WriteLine("Example: IEnumerable<Dog> → IEnumerable<Animal>");
        CovarianceDemo.Run();
        Console.WriteLine("✓ Covariance demo executed");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q16: Contravariance ('in' keyword)");
        Console.WriteLine("Allows: Base → Derived (Animal → Dog)");
        Console.WriteLine("Used in: Action<in T>, IComparer<in T>");
        Console.WriteLine("Example: Action<Animal> → Action<Dog>");
        ContravarianceDemo.Run();
        Console.WriteLine("✓ Contravariance demo executed");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q17: Covariance vs Contravariance");
        Console.WriteLine("Covariance (out):");
        Console.WriteLine("  - Direction: Derived → Base");
        Console.WriteLine("  - Position: Output (return)");
        Console.WriteLine("  - Think: Producer");

        Console.WriteLine("\nContravariance (in):");
        Console.WriteLine("  - Direction: Base → Derived");
        Console.WriteLine("  - Position: Input (parameter)");
        Console.WriteLine("  - Think: Consumer");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q18: Static members in generic types");
        Console.WriteLine("Each closed type has separate static fields!");
        Console.WriteLine("Counter<int> and Counter<string> have different static data");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q19: Inheriting from generic class");

        Console.WriteLine("\nPattern 1: Generic child");
        CachedRepository<string> cached = new CachedRepository<string>();
        cached.Add("test");
        Console.WriteLine($"Count: {cached.Count}");

        Console.WriteLine("\nPattern 2: Concrete type");
        StringRepository strRepo = new StringRepository();
        strRepo.AddUpperCase("hello");

        Console.WriteLine("\nPattern 3: Add new type parameter");
        KeyedRepository<int, string> keyed = new KeyedRepository<int, string>();
        keyed.AddWithKey(1, "First");
        Console.WriteLine("\n===========================================\n");
        Console.WriteLine("Q20: Cache<TKey, TValue> with expiration");

        GenericClasses.Cache<string, int> scores = new GenericClasses.Cache<string, int>();

        scores.Add("player1", 100);
        scores.Add("player2", 200, TimeSpan.FromSeconds(2));

        Console.WriteLine($"player1: {scores.Get("player1")}");
        Console.WriteLine($"player2: {scores.Get("player2")}");

        Console.WriteLine("Waiting 3 seconds...");
        Thread.Sleep(3000);

        Console.WriteLine($"player1: {scores.Get("player1")} (still valid)");
        // Console.WriteLine($"player2: {scores.Get("player2") ?? 0} (expired)");

        Console.WriteLine($"\nContains player1: {scores.Contains("player1")}");
        Console.WriteLine($"Contains player2: {scores.Contains("player2")}");

        scores["player3"] = 300;
        Console.WriteLine($"player3: {scores["player3"]}");

        Console.WriteLine($"Total items: {scores.Count}");

        scores.Clear();
        Console.WriteLine($"After clear: {scores.Count}");

        Console.WriteLine("\n===========================================\n");
    }
}
