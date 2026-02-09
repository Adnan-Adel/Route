using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");

          

            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 1: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════
            
            Console.WriteLine("QUESTION 1: REGIONS");

            Console.WriteLine("- #region and #endregion are preprocessor directives for code organization.");
            Console.WriteLine("- They allow collapsing/expanding sections of code.");
            Console.WriteLine("- Can be nested for hierarchical organization");

            //Nested Region Example
            #region Nested Region Example
            #region Inner Region
            Console.WriteLine("- This demonstrates nested regions");
            #endregion
            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════
            
            Console.WriteLine("QUESTION 2: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT");

        

            // EXPLICIT DECLARATION ---> you specify type explicitly
            int explicitNumber = 42;
            string explicitName = "John";
            Console.WriteLine($"explicitNumber = {explicitNumber}");
            Console.WriteLine($"explicitName = {explicitName}");
        

            // IMPLICIT DECLARATION ---> use 'var' keyword, and compiler infers type.
            var implicitNumber = 42;
            var implicitName = "John";
            Console.WriteLine($"implicitNumber = {implicitNumber} (type: {implicitNumber.GetType()})");
            Console.WriteLine($"implicitName = {implicitName} (type: {implicitName.GetType()})");
           
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 3: CONSTANTS");

            Console.WriteLine("Syntax: const <type> <name> = <value>;");

            // Constant examples
            const double PI = 3.14159;
            const int MAX_STUDENTS = 30;
            const string COMPANY_NAME = "Tech Corp";
            Console.WriteLine($"PI = {PI}");
            Console.WriteLine($"MAX_STUDENTS = {MAX_STUDENTS}");
            Console.WriteLine($"COMPANY_NAME = {COMPANY_NAME}");

            Console.WriteLine("Why to use a constant instead of a regular var?");
            Console.WriteLine("constants are compile-time evaluated, and they are immutable, value cannot be changed after declaration.");
            Console.WriteLine("also constants show intention that this value should never change.");

           

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE");
            
            // Class-level variable
            Console.WriteLine($"Class-level: classField = {classField}");
            Console.WriteLine("- Accessible throughout entire class");
            Console.WriteLine("- Lifetime: they live as object lives, and for static fields they live for entire program execution.");

            // Method-level variable
            int methodVariable = 50;
            Console.WriteLine($"Method-level: methodVariable = {methodVariable}");
            Console.WriteLine("- Accessible only within this method");
            Console.WriteLine("- Lifetime: Exists only while method executes");
            Console.WriteLine("- Destroyed when method returns");

        
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════
            Console.WriteLine("QUESTION 5: BLOCK-LEVEL SCOPE");
            Console.WriteLine("Block-level scope: Variables declared within { } are only accessible within that block");

            if (true)
            {
                int blockVariable = 100;
                Console.WriteLine($"Inside block: blockVariable = {blockVariable}");
            }
            // blockVariable is NOT accessible here - would cause compile error
            // Console.WriteLine(blockVariable); // ERROR

            Console.WriteLine("Variables are destroyed when block ends");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC");
            Console.WriteLine("Variable lifetime: Duration for which a variable exists in memory\n");

            Console.WriteLine("LOCAL VARIABLES:");
            Console.WriteLine("- Created when method/block is entered");
            Console.WriteLine("- Destroyed when method/block exits");
            Console.WriteLine("- Each method call creates new instances");

            Console.WriteLine("\nSTATIC VARIABLES:");
            Console.WriteLine("- Created when program starts (or first accessed)");
            Console.WriteLine("- Exist for entire program lifetime");
            Console.WriteLine("- Shared across all instances");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 7: GARBAGE COLLECTOR");
            Console.WriteLine("Garbage Collector (GC): Automatic memory management system in .NET");

            Console.WriteLine("\nFunctions:");
            Console.WriteLine("1. Automatically reclaims memory from unused objects");
            Console.WriteLine("2. Prevents memory leaks");
            Console.WriteLine("3. Frees developers from manual memory management");

            Console.WriteLine("\nHow it affects object lifetime:");
            Console.WriteLine("- Objects live on the heap until no references exist");
            Console.WriteLine("- GC determines when objects are unreachable");
            Console.WriteLine("- GC runs periodically or when memory is needed");
            Console.WriteLine("- Non-deterministic: You can't predict WHEN GC runs");


            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 8: VARIABLE SHADOWING");
            Console.WriteLine("Variable shadowing: When an inner scope variable has the same name as outer scope");

            Console.WriteLine("NOT allowed within same method (nested blocks)");

            int x = 10;
            Console.WriteLine($"Method scope: x = {x}");

            // This would cause compile error - C# prevents shadowing in nested blocks:
            // if (true)
            // {
            //     int x = 20; // ERROR: A local or parameter named 'x' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
            // }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 9: C# NAMING RULES");

            Console.WriteLine("1. Must start with letter (a-z, A-Z) or underscore (_)");
            Console.WriteLine("   Valid: name, _name, Name");
            Console.WriteLine("   Invalid: 1name, @name");

            Console.WriteLine("\n2. Can contain letters, digits, and underscores only");
            Console.WriteLine("   Valid: name123, my_variable");
            Console.WriteLine("   Invalid: my-variable, my.variable, my variable");

            Console.WriteLine("\n3. Cannot use C# reserved keywords (unless prefixed with @)");
            Console.WriteLine("   Invalid: int, class, for");
            Console.WriteLine("   Valid: @int, @class (using @ prefix)");

            Console.WriteLine("\n4. Case-sensitive");
            Console.WriteLine("   name, Name, NAME are all different variables");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 10: NAMING CONVENTIONS");

            Console.WriteLine("\n(a) LOCAL VARIABLES: camelCase");
            Console.WriteLine("   - Start with lowercase letter");
            Console.WriteLine("   - Capitalize first letter of subsequent words");
            Console.WriteLine($"   Examples: studentAge, firstName, accountBalance");

            Console.WriteLine("\n(b) CLASS NAMES: PascalCase");
            Console.WriteLine("   - Start with uppercase letter");
            Console.WriteLine("   - Capitalize first letter of each word");
            Console.WriteLine("   Examples: StudentRecord, BankAccount, DatabaseConnection");

            Console.WriteLine("\n(c) CONSTANTS: UPPER_CASE or PascalCase");
            Console.WriteLine("   - All uppercase with underscores (common)");
            Console.WriteLine("   - OR PascalCase (Microsoft convention)");
            Console.WriteLine($"   Examples: MAX_VALUE, PI_VALUE, DEFAULT_NAME");
            Console.WriteLine("   Or: MaxValue, PiValue, DefaultName");
            
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 11: ERROR TYPES");

            Console.WriteLine("\n1. SYNTAX ERRORS:");
            Console.WriteLine("   - Violations of C# language rules");
            Console.WriteLine("   - Detected at COMPILE TIME");
            Console.WriteLine("   - Program won't compile until fixed");
            Console.WriteLine("   Example: int x = 5  // Missing semicolon");
            Console.WriteLine("   Example: if (x = 5) // Using = instead of ==");

            Console.WriteLine("\n2. RUNTIME ERRORS (Exceptions):");
            Console.WriteLine("   - Occur during program EXECUTION");
            Console.WriteLine("   - Program compiles successfully");
            Console.WriteLine("   - Causes program to crash if unhandled");
            Console.WriteLine("   Example is division by zero");

            Console.WriteLine("\n3. LOGICAL ERRORS:");
            Console.WriteLine("   - Program runs without crashing");
            Console.WriteLine("   - Produces INCORRECT results");
            Console.WriteLine("   - Hardest to find (no error messages)");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 12: EXCEPTION HANDLING IMPORTANCE");

            Console.WriteLine("\nWhy exception handling is important:");
            Console.WriteLine("1. Prevents program crashes - keeps application running");
            Console.WriteLine("2. Provides graceful error recovery");
            Console.WriteLine("3. Improves user experience with meaningful error messages");
            Console.WriteLine("4. Allows cleanup of resources (files, connections)");

            Console.WriteLine("\nWhat happens WITHOUT exception handling:");
            Console.WriteLine("- Program terminates immediately");
            Console.WriteLine("- User sees cryptic error messages");
            Console.WriteLine("- Unsaved data may be lost");
            Console.WriteLine("- Resources may not be released properly");

            Console.WriteLine("\nExample without handling:");
            Console.WriteLine("int result = 10 / 0; // Program would crash!");

            Console.WriteLine("\nExample WITH handling:");
            // try
            // {
            //     int result = 10 / 0;
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Error handled gracefully - program continues running!");
            // }


            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 13: TRY-CATCH-FINALLY");

            Console.WriteLine("\nCode Example:");
            try
            {
                Console.WriteLine("1. Try block: Attempting risky operation...");
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine($"Accessing numbers[1] = {numbers[1]}"); // Success
                Console.WriteLine($"Accessing numbers[5] = {numbers[5]}"); // Will throw exception
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"2. Catch block: Exception caught - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("3. Finally block: This ALWAYS executes!");
            }

            Console.WriteLine("\nWhen finally block executes:");
            Console.WriteLine("- ALWAYS runs, whether exception occurs or not");
            Console.WriteLine("- Perfect for cleanup: closing files, releasing resources");

            Console.WriteLine("\nExample with no exception:");
            try
            {
                Console.WriteLine("Try: No error here");
            }
            catch (Exception)
            {
                Console.WriteLine("Catch: Won't execute");
            }
            finally
            {
                Console.WriteLine("Finally: Still executes!");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 14: COMMON BUILT-IN EXCEPTIONS");

            Console.WriteLine("1. NullReferenceException");
            Console.WriteLine("   - Occurs when accessing member of null object");
            Console.WriteLine("   Example:");
            try
            {
                string text = null;
                int length = text.Length; // Accessing member of null
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"   Caught: {ex.GetType().Name}");
            }

            Console.WriteLine("\n2. IndexOutOfRangeException");
            Console.WriteLine("   - Occurs when array/list index is invalid");
            Console.WriteLine("   Example:");
            try
            {
                int[] arr = { 1, 2, 3 };
                int value = arr[10]; // Index 10 doesn't exist
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"   Caught: {ex.GetType().Name}");
            }

            Console.WriteLine("\n3. DivideByZeroException");
            Console.WriteLine("   - Occurs when dividing integer by zero");
            Console.WriteLine("   Example:");
            // try
            // {
            //     int result = 10 / 0;
            // }
            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine($"   Caught: {ex.GetType().Name}");
            // }

            Console.WriteLine("\n4. FormatException");
            Console.WriteLine("   - Occurs when converting string to wrong format");
            Console.WriteLine("   Example:");
            try
            {
                int number = int.Parse("abc"); // "abc" is not a number
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"   Caught: {ex.GetType().Name}");
            }

            Console.WriteLine("\n5. ArgumentNullException");
            Console.WriteLine("   - Occurs when null passed to method that doesn't accept it");
            Console.WriteLine("   Example:");
            try
            {
                string test = null;
                test = string.IsNullOrEmpty(null) ? "empty" : null;
                if (test == null) throw new ArgumentNullException("test");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"   Caught: {ex.GetType().Name}");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 15: MULTIPLE CATCH BLOCKS");

            Console.WriteLine("\nWhy order matters:");
            Console.WriteLine("- Catch blocks are evaluated TOP to BOTTOM");
            Console.WriteLine("- First matching catch block is executed");
            Console.WriteLine("- More SPECIFIC exceptions must come BEFORE general ones");
            Console.WriteLine("- If general exception (Exception) is first, specific ones are unreachable");

            Console.WriteLine("\nCORRECT ordering (specific to general):");
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[10]);
            }
            catch (IndexOutOfRangeException ex)  // Most specific first
            {
                Console.WriteLine($"Caught IndexOutOfRangeException: {ex.Message}");
            }
            catch (ArgumentException ex)          // More general
            {
                Console.WriteLine($"Caught ArgumentException: {ex.Message}");
            }
            catch (Exception ex)                  // Most general last
            {
                Console.WriteLine($"Caught general Exception: {ex.Message}");
            }

            Console.WriteLine("\nINCORRECT ordering would be:");
            Console.WriteLine("catch (Exception ex)              // Too general - catches everything!");
            Console.WriteLine("catch (IndexOutOfRangeException)  // Unreachable code - compiler error!");

            

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 16: THROW KEYWORD");

            Console.WriteLine("\n1. throw; (RECOMMENDED)");
            Console.WriteLine("   - Preserves ORIGINAL stack trace");
            Console.WriteLine("   - Shows where exception actually occurred");
            Console.WriteLine("   - Better for debugging");

            Console.WriteLine("\n2. throw ex; (AVOID)");
            Console.WriteLine("   - RESETS stack trace to current location");
            Console.WriteLine("   - Loses information about original error");
            Console.WriteLine("   - Makes debugging harder");

            Console.WriteLine("\nExample:");
            // try
            // {
            //     try
            //     {
            //         int result = 10 / 0;
            //     }
            //     catch (Exception ex)
            //     {
            //         Console.WriteLine("Caught exception, re-throwing with 'throw;'");
            //         throw;      // Preserves stack trace - CORRECT
            //         // throw ex; // Would reset stack trace - WRONG
            //     }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Final catch: {ex.GetType().Name}");
            //     Console.WriteLine("Stack trace preserved!");
            // }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 17: STACK AND HEAP MEMORY");

            Console.WriteLine("\nSTACK MEMORY:");
            Console.WriteLine("- Fast access (LIFO - Last In First Out)");
            Console.WriteLine("- Limited size");
            Console.WriteLine("- Automatic memory management");
            Console.WriteLine("- Stores: Value types, method parameters, local variables");
            Console.WriteLine("- Memory released automatically when scope ends");

            Console.WriteLine("\nHEAP MEMORY:");
            Console.WriteLine("- Slower access than stack");
            Console.WriteLine("- Larger size");
            Console.WriteLine("- Managed by Garbage Collector");
            Console.WriteLine("- Stores: Reference types (objects, strings, arrays)");
            Console.WriteLine("- Memory released by GC when no references exist");
          
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 18: VALUE TYPES VS REFERENCE TYPES");

            Console.WriteLine("\nVALUE TYPES (copy by value):");
            int valueA = 10;
            int valueB = valueA;  // Creates a COPY
            valueB = 20;          // Changes only valueB
            Console.WriteLine($"valueA = {valueA}  (unchanged)");
            Console.WriteLine($"valueB = {valueB}  (changed)");
            Console.WriteLine("Each variable has its OWN copy of data");

            Console.WriteLine("\nREFERENCE TYPES (copy by reference):");
            int[] refA = { 10, 20, 30 };
            int[] refB = refA;    // Copies the REFERENCE, not the array
            refB[0] = 999;        // Changes the shared array
            Console.WriteLine($"refA[0] = {refA[0]}  (also changed!)");
            Console.WriteLine($"refB[0] = {refB[0]}  (changed)");
            Console.WriteLine("Both variables point to the SAME object in memory");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 19: OBJECT IN C#");

            Console.WriteLine("\nWhy 'object' is the base type:");
            Console.WriteLine("- System.Object is the root of C# type hierarchy");
            Console.WriteLine("- ALL types (value and reference) derive from object");
            Console.WriteLine("- Enables polymorphism and unified type system");
            Console.WriteLine("- Allows treating any type as 'object'");

            Console.WriteLine("\nMethods inherited from System.Object:");
            Console.WriteLine("1. ToString()   - Returns string representation");
            Console.WriteLine("2. Equals()     - Checks equality with another object");
            Console.WriteLine("3. GetHashCode() - Returns hash code for object");
            Console.WriteLine("4. GetType()    - Returns Type of the object");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

        }
        
        // Helper method for Question 4
        static void DemonstrateScopeMethod()
        {
            Console.WriteLine($"Inside DemonstrateScopeMethod: classField = {classField}");
            // We CAN access classField here (class-level)
            // We CANNOT access methodVariable from Main (method-level)
            // Console.WriteLine($"Inside DemonstrateScopeMethod: methodVariable = {methodVariable}"); --> it will cause an error methodVariable isn't accessible from here.
        }
    }
}
