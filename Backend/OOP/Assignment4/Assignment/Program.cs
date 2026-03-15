namespace Assignment4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== OOP Assignment 04 - Part 01 ==========\n");

        // ==================== Question 1 ====================
        Console.WriteLine("==================== Question 1 ====================");
        Console.WriteLine("Static Binding vs Dynamic Binding\n");

        Console.WriteLine("--- STATIC BINDING (Early Binding) ---");
        Console.WriteLine("Definition: Method call resolved at COMPILE TIME by the compiler");
        Console.WriteLine("Decision based on: REFERENCE TYPE (compile-time type)");

        Console.WriteLine("Examples of Static Binding:");
        Console.WriteLine("a) Method Overloading");
        Console.WriteLine("   - Multiple methods with same name but different parameters");
        Console.WriteLine("   - Compiler decides which method to call based on arguments");
        Console.WriteLine("   - Example: Add(int, int) vs Add(double, double)\n");

        Console.WriteLine("b) Operator Overloading");
        Console.WriteLine("   - Redefine how operators work with custom types");
        Console.WriteLine("   - Compiler resolves which operator version to use");
        Console.WriteLine("   - Example: + operator for Point class\n");

        Console.WriteLine("c) Method Hiding (using 'new' keyword)");
        Console.WriteLine("   - Child class hides parent's method with 'new'");
        Console.WriteLine("   - Compiler chooses based on REFERENCE type, not object type");
        Console.WriteLine("   - Example: Parent ref = new Child(); → calls Parent's method\n");

        Console.WriteLine("--- DYNAMIC BINDING (Late Binding) ---");
        Console.WriteLine("Definition: Method call resolved at RUNTIME by CLR");
        Console.WriteLine("Decision based on: OBJECT TYPE (actual runtime type)");

        Console.WriteLine("Examples of Dynamic Binding:");
        Console.WriteLine("a) Method Overriding (using 'virtual' and 'override')");
        Console.WriteLine("   - Parent marks method as 'virtual'");
        Console.WriteLine("   - Child overrides with 'override'");
        Console.WriteLine("   - CLR chooses based on ACTUAL object type at runtime");
        Console.WriteLine("   - Example: Animal ref = new Dog(); → calls Dog's method\n");

        Console.WriteLine("b) Abstract Methods");

        Console.WriteLine("c) Interface Implementation");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 2 ====================
        Console.WriteLine("==================== Question 2 ====================");
        Console.WriteLine("Method Overloading vs Method Overriding\n");
        Console.WriteLine("Method Overloading: ");
        Console.WriteLine(" - Same name, different params");
        Console.WriteLine(" - Binding: Static (compile-time)");
        Console.WriteLine(" - Parameters must differ");

        Console.WriteLine("Method Overriding: ");
        Console.WriteLine(" - Redefine parent's method in child");
        Console.WriteLine(" - Binding: Dynamic (runtime)");
        Console.WriteLine(" - Parameters must be identical");
        Console.WriteLine(" - uses keywords: virtual, override");

        Console.WriteLine("--- Method Overloading Example ---");
        Console.WriteLine("public class Calculator");
        Console.WriteLine("{");
        Console.WriteLine("    public int Add(int a, int b) { return a + b; }");
        Console.WriteLine("    public double Add(double a, double b) { return a + b; }");
        Console.WriteLine("    public int Add(int a, int b, int c) { return a + b + c; }");
        Console.WriteLine("}");
        Console.WriteLine("// Compiler chooses based on arguments passed\n");

        Console.WriteLine("--- Method Overriding Example ---");
        Console.WriteLine("public class Animal");
        Console.WriteLine("{");
        Console.WriteLine("    public virtual void MakeSound() { Console.WriteLine(\"Some sound\"); }");
        Console.WriteLine("}");
        Console.WriteLine("public class Dog : Animal");
        Console.WriteLine("{");
        Console.WriteLine("    public override void MakeSound() { Console.WriteLine(\"Bark!\"); }");
        Console.WriteLine("}");
        Console.WriteLine("// Runtime chooses based on actual object type\n");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 3 ====================
        Console.WriteLine("==================== Question 3 ====================");
        Console.WriteLine("Keywords used for method overriding\n");

        Console.WriteLine("1. 'virtual' Keyword");
        Console.WriteLine("   Location: Parent class");
        Console.WriteLine("   Purpose: Marks a method as overridable");
        Console.WriteLine("   Meaning: \"This method CAN be overridden in derived classes\"");
        Console.WriteLine("   Requirements:");
        Console.WriteLine("      - Cannot be used with static, or private methods");
        Console.WriteLine("      - Provides default implementation");
        Console.WriteLine("   Example:");
        Console.WriteLine("      public virtual void Display() { Console.WriteLine(\"Base\"); }\n");

        Console.WriteLine("2. 'override' Keyword");
        Console.WriteLine("   Location: Child class");
        Console.WriteLine("   Purpose: Provides new implementation for virtual method");
        Console.WriteLine("   Meaning: \"I'm replacing the parent's implementation\"");
        Console.WriteLine("   Requirements:");
        Console.WriteLine("      - Parent method must be virtual");
        Console.WriteLine("      - Must have identical signature (name, params, return type)");
        Console.WriteLine("      - Cannot override sealed or non-virtual methods");
        Console.WriteLine("   Example:");
        Console.WriteLine("      public override void Display() { Console.WriteLine(\"Derived\"); }\n");

        Console.WriteLine("3. 'abstract' Keyword");
        Console.WriteLine("   Location: Abstract parent class");
        Console.WriteLine("   Purpose: Forces derived classes to provide implementation");
        Console.WriteLine("   Example: public abstract void Calculate();\n");

        Console.WriteLine("4. 'sealed' Keyword");
        Console.WriteLine("   Location: Derived class");
        Console.WriteLine("   Purpose: Stops the override chain");
        Console.WriteLine("   Example: public sealed override void Display() { }\n");

        Console.WriteLine("5. 'new' Keyword (Method Hiding)");
        Console.WriteLine("   Location: Derived class");
        Console.WriteLine("   Purpose: Hides parent's method (static binding)");
        Console.WriteLine("   Example: public new void Display() { }\n");

        Console.WriteLine("6. 'base' Keyword");
        Console.WriteLine("   Location: Derived class");
        Console.WriteLine("   Purpose: Calls parent's implementation");
        Console.WriteLine("   Example: base.Display();\n");

        Console.WriteLine("=====================================================\n");
    }
}
