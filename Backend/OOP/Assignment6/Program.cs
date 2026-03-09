namespace Assignment6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== OOP Assignment 06 - Part 01 ==========\n");

        // ==================== Question 1 ====================
        Console.WriteLine("==================== Question 1 ====================");
        Console.WriteLine("Abstraction vs Encapsulation\n");

        Console.WriteLine("ABSTRACTION:");
        Console.WriteLine("  - The process of exposing only what the user needs");
        Console.WriteLine("  - Hiding HOW it is implemented");
        Console.WriteLine("  - Focuses on WHAT an object does");
        Console.WriteLine("  - Implemented using interfaces and abstract classes\n");

        Console.WriteLine("ENCAPSULATION:");
        Console.WriteLine("  - Focuses on HOW data is protected");
        Console.WriteLine("  - Hiding internal state/data");
        Console.WriteLine("  - Implemented using access modifiers and properties\n");

        Console.WriteLine("Real-world Example:");
        Console.WriteLine("  TV Remote Control:");
        Console.WriteLine("  - Abstraction: You see buttons (Volume, Channel, Power)");
        Console.WriteLine("    You know WHAT it does, not HOW it works internally");
        Console.WriteLine("  - Encapsulation: Internal circuits are hidden inside the case");
        Console.WriteLine("    You cannot directly access the IR transmitter or chip\n");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 2 ====================
        Console.WriteLine("==================== Question 2 ====================");
        Console.WriteLine("Abstract Class vs Interface\n");

        Console.WriteLine("Interface:");
        Console.WriteLine("  - Contract - any class implements it must implement all methods");
        Console.WriteLine("  - Cannot instantiate an object from interface");
        Console.WriteLine("  - Can have default methods but they belong to interface, not the class");
        Console.WriteLine("  - No fields, no constructors");
        Console.WriteLine("  - A class can implement multiple interfaces");
        Console.WriteLine("  - Defines WHAT you can do (roles and capabilities)\n");

        Console.WriteLine("Abstract Class:");
        Console.WriteLine("  - Can have abstract methods (must be implemented) + concrete methods (already implemented)");
        Console.WriteLine("  - Cannot instantiate an object from abstract class");
        Console.WriteLine("  - Default methods are inherited by children");
        Console.WriteLine("  - Can have fields and constructors");
        Console.WriteLine("  - Single inheritance only");
        Console.WriteLine("  - Defines WHAT you are (identity and shared behavior)\n");
        Console.WriteLine("When to choose:");
        Console.WriteLine("  Interface → When unrelated classes need same behavior");
        Console.WriteLine("  Abstract Class → When classes share common base and identity\n");
        Console.WriteLine("=====================================================\n");

        // ==================== Question 3 ====================
        Console.WriteLine("==================== Question 3 ====================");
        Console.WriteLine("Abstract Class Analysis\n");

        Console.WriteLine("a) Can you write: Appliance a = new Appliance(\"LG\"); ?\n");
        Console.WriteLine("   NO - Cannot instantiate abstract class");
        Console.WriteLine("   Reason: Appliance is abstract - compiler prevents direct instantiation\n");

        Console.WriteLine("b) Difference between the three methods:\n");
        Console.WriteLine("   PowerConsumption() → ABSTRACT");
        Console.WriteLine("     - No implementation in base class");
        Console.WriteLine("     - Derived classes MUST provide implementation");
        Console.WriteLine("     - Every appliance has different power consumption\n");

        Console.WriteLine("   Status() → VIRTUAL");
        Console.WriteLine("     - Has default implementation (\"Standby\")");
        Console.WriteLine("     - Derived classes CAN override if needed");
        Console.WriteLine("     - Optional customization\n");

        Console.WriteLine("   Label() → CONCRETE (fully implemented)");
        Console.WriteLine("     - Complete implementation in base class");
        Console.WriteLine("     - Inherited by all children");
        Console.WriteLine("     - Cannot be overridden\n");

        Console.WriteLine("c) Status() on Toaster object:\n");
        Console.WriteLine("   Returns: \"Standby\"");
        Console.WriteLine("   Reason: Toaster doesn't override Status(), so it uses");
        Console.WriteLine("           the default implementation from base class\n");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 4 ====================
        Console.WriteLine("==================== Question 4 ====================");
        Console.WriteLine("Partial Classes and Extension Methods\n");

        Console.WriteLine("a) What is a partial class? Why split Calculator?\n");
        Console.WriteLine("   A partial class allows you to split a single class definition");
        Console.WriteLine("   across multiple files - compiler merges them into one class.\n");

        Console.WriteLine("   Why split:");
        Console.WriteLine("     - Organize large classes");
        Console.WriteLine("     - Team collaboration (different files, less merge conflicts)");
        Console.WriteLine("     - Separate auto-generated code from manual code");
        Console.WriteLine("     - Logical grouping (e.g., calculations vs logging)\n");

        Console.WriteLine("b) What is a partial method?\n");
        Console.WriteLine("   A partial method is declared in one part of a partial class");
        Console.WriteLine("   and optionally implemented in another part.\n");

        Console.WriteLine("   If OnCalculated() implementation is deleted:");
        Console.WriteLine("     - Code STILL compiles ✓");
        Console.WriteLine("     - Compiler removes all calls to OnCalculated()");
        Console.WriteLine("     - No runtime error - it's optional by design\n");

        Console.WriteLine("c) What is an extension method?\n");
        Console.WriteLine("   Extension method lets you add methods to existing types");
        Console.WriteLine("   without modifying source code or using inheritance.\n");

        Console.WriteLine("   Three rules:");
        Console.WriteLine("     1. Must be in a static class");
        Console.WriteLine("     2. Must be a static method");
        Console.WriteLine("     3. First parameter must use 'this' keyword\n");

        Console.WriteLine("d) What will this code print?\n");
        Console.WriteLine("   Calculator calc = new Calculator();");
        Console.WriteLine("   double result = calc.Add(19.5, 0.5);");
        Console.WriteLine("   Console.WriteLine(result.ToCurrency());\n");

        Console.WriteLine("   Output: $20.00");
        Console.WriteLine("   Reason: 19.5 + 0.5 = 20, formatted as currency with 2 decimals\n");

        Console.WriteLine("=====================================================\n");
    }
}
