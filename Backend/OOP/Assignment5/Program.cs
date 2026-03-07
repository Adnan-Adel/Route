namespace Assignment5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== OOP Assignment 05 - Part 01 ==========\n");

        // ==================== Question 1 ====================
        Console.WriteLine("==================== Question 1 ====================");
        Console.WriteLine("What is an interface in C#?\n");

        Console.WriteLine("An interface defines a contract that a class must follow.");
        Console.WriteLine("It specifies what a class can do, not how it does it.\n");

        Console.WriteLine("Why use interfaces over concrete classes:");
        Console.WriteLine("  1. Enable polymorphism without inheritance");
        Console.WriteLine("     - Unrelated classes can share common behavior");
        Console.WriteLine("  2. Remove tight coupling between classes");
        Console.WriteLine("     - Depend on abstractions, not implementations");
        Console.WriteLine("  3. Enable multiple inheritance of behavior");
        Console.WriteLine("     - A class can implement multiple interfaces\n");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 2 ====================
        Console.WriteLine("==================== Question 2 ====================");
        Console.WriteLine("Interface Name Collision\n");

        Console.WriteLine("a) Problem:");
        Console.WriteLine("   Both interfaces have a method called Greet()");
        Console.WriteLine("   The class Translator implements both interfaces but provides only 1 Greet()");
        Console.WriteLine("   This single method satisfies both interfaces - cannot distinguish between them\n");

        Console.WriteLine("b) Solution: Explicit Interface Implementation");
        Console.WriteLine("   Implementing interface members in a way that they are accessible");
        Console.WriteLine("   only through the interface reference.\n");

        Console.WriteLine("Fixed Code:");
        Console.WriteLine("void IEnglishSpeaker.Greet()");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Hello\");");
        Console.WriteLine("}");
        Console.WriteLine("void IArabicSpeaker.Greet()");
        Console.WriteLine("{");
        Console.WriteLine("    Console.WriteLine(\"Ahlan\");");
        Console.WriteLine("}\n");

        Console.WriteLine("c) Cannot call directly:");
        Console.WriteLine("   We can't call it directly from Translator object");
        Console.WriteLine("   Must use interface reference\n");

        Console.WriteLine("Right way to call:");
        Console.WriteLine("Translator t = new Translator();");
        Console.WriteLine("((IEnglishSpeaker)t).Greet(); // Hello");
        Console.WriteLine("((IArabicSpeaker)t).Greet();  // Ahlan\n");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 3 ====================
        Console.WriteLine("==================== Question 3 ====================");
        Console.WriteLine("Shallow Copy vs Deep Copy\n");

        Console.WriteLine("Shallow Copy:");
        Console.WriteLine("  - Copies object but copies references for reference-type fields");
        Console.WriteLine("  - Nested objects are shared between original and copy\n");

        Console.WriteLine("When to use:");
        Console.WriteLine("  - Object is immutable");
        Console.WriteLine("  - No nested reference state");

        Console.WriteLine("Deep Copy:");
        Console.WriteLine("  - Copies the object and all nested objects");
        Console.WriteLine("  - Creates fully independent duplicates\n");

        Console.WriteLine("When to use:");
        Console.WriteLine("  - Objects must be isolated");
        Console.WriteLine("  - Modifications should not affect original\n");

        Console.WriteLine("Risk of shallow copy with reference-type fields:");
        Console.WriteLine("  - Reference-type fields are shared");
        Console.WriteLine("  - Changing one affects the other");
        Console.WriteLine("  - Unexpected side effects\n");

        Console.WriteLine("=====================================================\n");

        // ==================== Question 4 ====================
        Console.WriteLine("==================== Question 4 ====================");
        Console.WriteLine("Code Output Analysis\n");

        Console.WriteLine("Output:");
        Console.WriteLine("e1: Dev - Testing");
        Console.WriteLine("e2: QA - Testing\n");

        Console.WriteLine("Explanation:");
        Console.WriteLine("  - It is a shallow copy, not a deep copy");
        Console.WriteLine("  - Inner reference types (Department) are shared");
        Console.WriteLine("  - Changing e2.Dept.Name affected both e1 and e2");
        Console.WriteLine("  - But e2.Title = \"QA\" didn't change e1.Title");
        Console.WriteLine("  - Because string is immutable - creates a new one for e2\n");

        Console.WriteLine("=====================================================\n");
    }
}
