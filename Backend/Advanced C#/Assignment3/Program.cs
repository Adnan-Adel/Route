namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {
        // ========================================
        // EXERCISE 1: STUDENT GRADE MANAGER
        // ========================================
        Console.WriteLine("========== ASSIGNMENT 3: COLLECTIONS ==========\n");

        Console.WriteLine("========== EXERCISE 1: STUDENT GRADE MANAGER ==========\n");

        // 1. Create a List<int> with grades
        List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

        // 2. Print collection, Count, first and last grade
        Console.WriteLine("Original Grades:");
        PrintList(grades);
        Console.WriteLine($"Count: {grades.Count}");
        Console.WriteLine($"First: {grades[0]}");
        Console.WriteLine($"Last: {grades[^1]}"); // or grades[grades.Count - 1]
        Console.WriteLine();

        // 3. Sort ascending, then print
        grades.Sort();
        Console.WriteLine("Sorted Grades (Ascending):");
        PrintList(grades);
        Console.WriteLine();

        // 4. Get the first grade above 90
        int firstAbove90 = grades.First(g => g > 90);
        Console.WriteLine($"First grade above 90: {firstAbove90}");
        Console.WriteLine();

        // 5. Get all grades below 75 (failing grades)
        List<int> failingGrades = grades.Where(g => g < 75).ToList();
        Console.WriteLine("Failing Grades (below 75):");
        PrintList(failingGrades);
        Console.WriteLine();

        // 6. Remove all failing grades (below 75)
        grades.RemoveAll(g => g < 75);
        Console.WriteLine("After removing failing grades:");
        PrintList(grades);
        Console.WriteLine();

        // 7. Check if any grade equals 100
        bool hasPerfectScore = grades.Any(g => g == 100);
        Console.WriteLine($"Has perfect score (100): {hasPerfectScore}");
        Console.WriteLine();

        // 8. Create List<string> where each grade becomes "Grade: X"
        List<string> gradeLabels = grades.Select(g => $"Grade: {g}").ToList();
        Console.WriteLine("Grade Labels:");
        foreach (var label in gradeLabels)
        {
            Console.WriteLine(label);
        }

        Console.WriteLine("\n===========================================\n");

        // ========================================
        // EXERCISE 2: LEADERBOARD
        // ========================================
        Console.WriteLine("========== EXERCISE 2: LEADERBOARD ==========\n");

        // 1. Add entries (SortedDictionary automatically sorts by key)
        SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>
        {
            { 500, "Ahmed" },
            { 200, "Sara" },
            { 800, "Ali" },
            { 350, "Mona" }
        };

        // 2. Print all entries (automatically sorted by score)
        Console.WriteLine("Leaderboard (sorted by score):");
        foreach (var entry in leaderboard)
        {
            Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
        }
        Console.WriteLine();

        // 3. Access first key and first value
        int firstKey = leaderboard.Keys.First();
        string firstValue = leaderboard.Values.First();
        Console.WriteLine($"First Key: {firstKey}");
        Console.WriteLine($"First Value: {firstValue}");
        Console.WriteLine();

        // 4. Check if score 500 exists
        bool hasScore500 = leaderboard.ContainsKey(500);
        Console.WriteLine($"Score 500 exists: {hasScore500}");
        Console.WriteLine();

        // 5. Safely get player with score 999
        if (leaderboard.TryGetValue(999, out string? player))
        {
            Console.WriteLine($"Player with score 999: {player}");
        }
        else
        {
            Console.WriteLine("Score 999 not found");
        }
        Console.WriteLine();

        // 6. Remove player with score 200 and print updated list
        leaderboard.Remove(200);
        Console.WriteLine("After removing score 200:");
        foreach (var entry in leaderboard)
        {
            Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
        }

        Console.WriteLine("\n===========================================\n");

        // ========================================
        // EXERCISE 3: PHONE BOOK
        // ========================================
        Console.WriteLine("========== EXERCISE 3: PHONE BOOK ==========\n");

        // 1. Create Dictionary with 4 contacts
        Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            { "Ahmed", "0123456789" },
            { "Sara", "0111222333" },
            { "Ali", "0155667788" },
            { "Mona", "0199887766" }
        };

        Console.WriteLine("Initial Phone Book:");
        PrintDictionary(phoneBook);
        Console.WriteLine();

        // 2. Add new contact using [] syntax (add or update)
        phoneBook["Omar"] = "0122334455";
        Console.WriteLine("After adding Omar:");
        PrintDictionary(phoneBook);
        Console.WriteLine();

        // 3. Try adding duplicate using .Add() - catch exception
        try
        {
            phoneBook.Add("Ahmed", "0100000000"); // Duplicate key!
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error adding duplicate: {ex.Message}");
        }
        Console.WriteLine();

        // 4. Try adding duplicate using .TryAdd() - print whether it succeeded
        bool added = phoneBook.TryAdd("Ahmed", "0100000000");
        Console.WriteLine($"TryAdd duplicate 'Ahmed': {(added ? "Succeeded" : "Failed")}");

        bool addedNew = phoneBook.TryAdd("Zara", "0188776655");
        Console.WriteLine($"TryAdd new 'Zara': {(addedNew ? "Succeeded" : "Failed")}");
        Console.WriteLine();

        // 5. Search for contact that doesn't exist
        if (phoneBook.ContainsKey("John"))
        {
            Console.WriteLine($"John: {phoneBook["John"]}");
        }
        else
        {
            Console.WriteLine("Contact 'John' not found");
        }
        Console.WriteLine();

        // 6. Get contact with fallback of "Not Found"
        string phone = phoneBook.GetValueOrDefault("Unknown", "Not Found");
        Console.WriteLine($"Phone for 'Unknown': {phone}");
        Console.WriteLine();

        // 7. Print all Keys on one line, then all Values on another
        Console.WriteLine("All Keys:");
        Console.WriteLine(string.Join(", ", phoneBook.Keys));
        Console.WriteLine("\nAll Values:");
        Console.WriteLine(string.Join(", ", phoneBook.Values));

        Console.WriteLine("\n===========================================\n");

        // ========================================
        // EXERCISE 4: UNIQUE EMAIL VALIDATOR
        // ========================================
        Console.WriteLine("========== EXERCISE 4: UNIQUE EMAIL VALIDATOR ==========\n");

        // 1. Create HashSet with case-insensitive comparer
        HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // 2. Add emails (duplicates ignored due to case-insensitive comparison)
        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");    // Duplicate (case-insensitive)
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");     // Duplicate (case-insensitive)

        // 3. Print Count - how many are actually stored?
        Console.WriteLine($"Emails Count: {emails.Count}");
        Console.WriteLine("Explanation: Only 2 emails stored because HashSet uses");
        Console.WriteLine("OrdinalIgnoreCase comparer, treating 'ahmed@test.com' and");
        Console.WriteLine("'AHMED@test.com' as the same, and 'sara@test.com' and");
        Console.WriteLine("'Sara@Test.Com' as the same.\n");

        Console.WriteLine("Stored emails:");
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
        Console.WriteLine();

        // 4. Create two sets
        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

        Console.WriteLine($"Set A: {string.Join(", ", setA)}");
        Console.WriteLine($"Set B: {string.Join(", ", setB)}");
        Console.WriteLine();

        // 5. Print UnionWith, IntersectWith, ExceptWith

        // UnionWith - all unique elements from both sets
        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);
        Console.WriteLine($"UnionWith (A ∪ B): {string.Join(", ", union)}");

        // IntersectWith - common elements
        HashSet<int> intersect = new HashSet<int>(setA);
        intersect.IntersectWith(setB);
        Console.WriteLine($"IntersectWith (A ∩ B): {string.Join(", ", intersect)}");

        // ExceptWith - elements in A but not in B
        HashSet<int> except = new HashSet<int>(setA);
        except.ExceptWith(setB);
        Console.WriteLine($"ExceptWith (A - B): {string.Join(", ", except)}");
        Console.WriteLine();

        // 6. Use IsSubsetOf to check if {1,2} is subset of Set A
        HashSet<int> subset = new HashSet<int> { 1, 2 };
        bool isSubset = subset.IsSubsetOf(setA);
        Console.WriteLine($"Is {{1, 2}} a subset of Set A? {isSubset}");

        Console.WriteLine("\n===========================================\n");

        // ========================================
        // EXERCISE 5: PRINT QUEUE SIMULATOR
        // ========================================
        Console.WriteLine("========== EXERCISE 5: PRINT QUEUE SIMULATOR ==========\n");

        // Create Queue and enqueue 5 documents
        Queue<string> printQueue = new Queue<string>();
        printQueue.Enqueue("Report.pdf");
        printQueue.Enqueue("Invoice.pdf");
        printQueue.Enqueue("Letter.docx");
        printQueue.Enqueue("Resume.pdf");
        printQueue.Enqueue("Photo.jpg");

        // 1. Print queue contents and Count
        Console.WriteLine("Print Queue:");
        foreach (var doc in printQueue)
        {
            Console.WriteLine(doc);
        }
        Console.WriteLine($"Count: {printQueue.Count}");
        Console.WriteLine();

        // 2. Use Peek to see next document (without removing)
        string nextDoc = printQueue.Peek();
        Console.WriteLine($"Next document to print (Peek): {nextDoc}");
        Console.WriteLine($"Queue Count after Peek: {printQueue.Count}");
        Console.WriteLine();

        // 3. Process queue: Dequeue each and print
        Console.WriteLine("Processing queue:");
        while (printQueue.Count > 0)
        {
            string doc = printQueue.Dequeue();
            Console.WriteLine($"Printing: {doc}");
        }
        Console.WriteLine();

        // 4. Try TryDequeue on empty queue
        if (printQueue.TryDequeue(out string? result))
        {
            Console.WriteLine($"Dequeued: {result}");
        }
        else
        {
            Console.WriteLine("TryDequeue on empty queue: Failed (returns false, no exception)");
        }

        Console.WriteLine("\n===========================================\n");

        // ========================================
        // EXERCISE 6: BROWSER HISTORY (UNDO)
        // ========================================
        Console.WriteLine("========== EXERCISE 6: BROWSER HISTORY (UNDO) ==========\n");

        // Create Stack for browser history
        Stack<string> history = new Stack<string>();

        // 1. Push 5 URLs
        history.Push("google.com");
        history.Push("github.com");
        history.Push("stackoverflow.com");
        history.Push("youtube.com");
        history.Push("claude.ai");

        Console.WriteLine("Browser History (Stack):");
        foreach (var url in history)
        {
            Console.WriteLine(url);
        }
        Console.WriteLine();

        // 2. Use Peek to see current page (top of stack)
        string currentPage = history.Peek();
        Console.WriteLine($"Current page (Peek): {currentPage}");
        Console.WriteLine($"Stack Count after Peek: {history.Count}");
        Console.WriteLine();

        // 3. Press "back" 3 times using Pop
        Console.WriteLine("Pressing 'back' 3 times:");
        for (int i = 0; i < 3; i++)
        {
            string leavingPage = history.Pop();
            Console.WriteLine($"Leaving: {leavingPage}");
        }
        Console.WriteLine();

        // 4. Print current page after going back
        if (history.Count > 0)
        {
            Console.WriteLine($"Current page after going back: {history.Peek()}");
        }
        Console.WriteLine();

        // 5. Try TryPop on empty stack
        // First, empty the stack
        while (history.Count > 0)
        {
            history.Pop();
        }

        if (history.TryPop(out string? page))
        {
            Console.WriteLine($"Popped: {page}");
        }
        else
        {
            Console.WriteLine("TryPop on empty stack: Failed (returns false, no exception)");
        }

        Console.WriteLine("\n===========================================\n");
    }

    // ========================================
    // HELPER METHODS
    // ========================================
    static void PrintList(List<int> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }

    static void PrintDictionary(Dictionary<string, string> dict)
    {
        foreach (var entry in dict)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
