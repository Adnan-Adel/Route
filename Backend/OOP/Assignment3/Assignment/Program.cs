namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== OOP Assignment 03 - Part 01 ==========\n");

            // ==================== Question 1 ====================
            Console.WriteLine("==================== Question 1 ====================");
            Console.WriteLine("Identify the type of relationship\n");

            Console.WriteLine("a) A University has Departments. If the university is closed,");
            Console.WriteLine("   the departments no longer exist.");
            Console.WriteLine("   Answer: COMPOSITION");
            Console.WriteLine("   Reason: Strong ownership - departments cannot exist without university");
            Console.WriteLine("   Lifetime: Department lifetime depends on University (dies with it)\n");

            Console.WriteLine("b) A Driver uses a Car. The driver does not own the car.");
            Console.WriteLine("   Answer: ASSOCIATION");
            Console.WriteLine("   Reason: Temporary 'uses' relationship without ownership");
            Console.WriteLine("   Lifetime: Driver and Car have independent lifetimes");

            Console.WriteLine("c) A Dog is an Animal.");
            Console.WriteLine("   Answer: INHERITANCE");
            Console.WriteLine("   Reason: 'IS-A' relationship - Dog IS-A type of Animal");
            Console.WriteLine("   Implementation: Dog derives from Animal base class\n");

            Console.WriteLine("d) A Team has Players. If the team is deleted, the players still exist.");
            Console.WriteLine("   Answer: AGGREGATION");
            Console.WriteLine("   Reason: Weak ownership - players can exist independently");
            Console.WriteLine("   Lifetime: Player lifetime independent of Team\n");

            Console.WriteLine("e) A method receives a Logger as a parameter and calls it inside");
            Console.WriteLine("   the method only.");
            Console.WriteLine("   Answer: DEPENDENCY");
            Console.WriteLine("   Reason: Temporary usage - method depends on Logger to function");
            Console.WriteLine("   Lifetime: No ownership, just uses Logger temporarily\n");

            Console.WriteLine("=====================================================\n");

            // ==================== Question 2 ====================
            Console.WriteLine("==================== Question 2 ====================");
            Console.WriteLine("Access Modifiers and Sealed Keyword\n");

            Console.WriteLine("--- a) Protected field accessibility ---");
            Console.WriteLine("Question: Parent class has protected field. Can child in different");
            Console.WriteLine("          assembly access it? Through object instance from outside?\n");

            Console.WriteLine("Answer Part 1: YES - Child class in different assembly CAN access");
            Console.WriteLine("               protected field through inheritance");

            Console.WriteLine("Answer Part 2: NO - Cannot access through object instance from outside");

            Console.WriteLine("Key Point: Protected works through INHERITANCE, not object access\n");

            Console.WriteLine("--- b) protected internal vs private protected ---\n");

            Console.WriteLine("protected internal:");
            Console.WriteLine("  - Accessible from SAME ASSEMBLY (any class)");
            Console.WriteLine("  - OR from DERIVED CLASSES (any assembly)");

            Console.WriteLine("private protected:");
            Console.WriteLine("  - Accessible ONLY from SAME ASSEMBLY");
            Console.WriteLine("  - AND ONLY from DERIVED CLASSES");

            Console.WriteLine("--- c) sealed keyword ---\n");

            Console.WriteLine("sealed on CLASS:");
            Console.WriteLine("  - Prevents inheritance");
            Console.WriteLine("  - No class can derive from a sealed class");
            Console.WriteLine("  - Use: Final implementation, prevent modification via inheritance\n");

            Console.WriteLine("sealed on METHOD:");
            Console.WriteLine("  - Prevents further overriding in derived classes");
            Console.WriteLine("  - Can ONLY be used on override methods");
            Console.WriteLine("  - Stops the override chain\n");

            Console.WriteLine("--- d) Can you create object from sealed class? ---\n");

            Console.WriteLine("Answer: YES, absolutely!");
            Console.WriteLine("Reason: sealed ONLY prevents INHERITANCE, not INSTANTIATION\n");

            Console.WriteLine("=====================================================\n");
        }
    }
}
