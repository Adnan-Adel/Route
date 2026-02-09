// Q1
Console.WriteLine("Q1: Type Casting - Double to Int");
Console.WriteLine("Code: double d = 9.99; int x = (int)d;");
double d = 9.99;
int x = (int)d;
Console.WriteLine($"Output: {x}");
Console.WriteLine("Explanation: It casted d to int so it took integer part only.\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q2
Console.WriteLine("Q2: Fix Integer Division");
Console.WriteLine("Code: int n = 5; double d2 = (double)n / 2;");
int n = 5;
double d2 = (double)n / 2;
Console.WriteLine($"Output: {d2}");
Console.WriteLine("Explanation: Explicitly cast n as double to keep fraction out of division.\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q3
Console.WriteLine("Q3: Reading User Input as Int");
Console.WriteLine("Code: int age = Convert.ToInt32(Console.ReadLine());");
Console.WriteLine("Simulated Input: 25");
// Simulating user input
string simulatedInput = "25";
int age = Convert.ToInt32(simulatedInput);
Console.WriteLine($"Output: age = {age}\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q4
Console.WriteLine("Q4: Parse Exception");
Console.WriteLine("Code: string s = \"12a\"; int x = int.Parse(s);");
Console.WriteLine("Explanation: Parse() throws FormatException, because int.Parse() expects a valid integer string.");
try
{
    string s = "12a";
    int xParse = int.Parse(s);
    Console.WriteLine(xParse);
}
catch (FormatException ex)
{
    Console.WriteLine($"Result: FormatException - {ex.Message}\n");
}
Console.WriteLine(new string('-', 70) + "\n");

// Q5
Console.WriteLine("Q5: Safe Parsing with TryParse");
Console.WriteLine("Testing with \"12a\":");
string s1 = "12a";
if (int.TryParse(s1, out int x1))
{
    Console.WriteLine(x1);
}
else
{
    Console.WriteLine("Invalid");
}

Console.WriteLine("\nTesting with \"123\":");
string s2 = "123";
if (int.TryParse(s2, out int x2))
{
    Console.WriteLine(x2);
}
else
{
    Console.WriteLine("Invalid");
}
Console.WriteLine();
Console.WriteLine(new string('-', 70) + "\n");

// Q6
Console.WriteLine("Q6: Unboxing");
Console.WriteLine("Code: object o = 10; int a = (int)o; Console.WriteLine(a + 1);");
object o6 = 10;  // Boxing
int a6 = (int)o6; // UnBoxing
Console.WriteLine($"Output: {a6 + 1}");
Console.WriteLine("Process:");
Console.WriteLine("1. Value type (10) is boxed to object type");
Console.WriteLine("2. Object is unboxed back to int with explicit cast");
Console.WriteLine("3. Arithmetic operation: 10 + 1 = 11\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q7
Console.WriteLine("Q7: Invalid Unboxing - Type Mismatch");
Console.WriteLine("Code: object o = 10; long x = (long)o;");
Console.WriteLine("Problem: Boxes an int. Cannot directly unbox int to long (Must unbox to EXACT same type (int)).");
try
{
    object o7 = 10;
    long x7 = (long)o7;
    Console.WriteLine(x7);
}
catch (InvalidCastException ex)
{
    Console.WriteLine($"Result: InvalidCastException - {ex.Message}");
}

Console.WriteLine("\nSolution: Use Convert.ToInt64()");
object o7b = 10;
long x7b = Convert.ToInt64(o7b);
Console.WriteLine($"Output: {x7b}\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q8
Console.WriteLine("Q8: Fix Unboxing with Exception Handling");
Console.WriteLine("Original Code: object o = 10; long x = o; // ERROR");
Console.WriteLine("Solution using try-catch:");
object o8 = 10;
long x8;
try
{
    x8 = (int)o8;
}
catch
{
    x8 = -1;
}
Console.WriteLine($"Output: {x8}\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q9
Console.WriteLine("Q9: Null-Conditional Operator ?.");
Console.WriteLine("Code: string? name = null; Console.WriteLine(name?.Length);");
string? name9 = null;
Console.WriteLine($"Output: {name9?.Length} (blank/null)");
Console.WriteLine("Explanation: The ?. operator is the NULL-CONDITIONAL operator, and name is null so it returns null.\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q10
Console.WriteLine("Q10: Null-Coalescing Operator ??");
Console.WriteLine("Code: string? name2 = null; int length = name2?.Length ?? 0;");
string? name10 = null;
int length10 = name10?.Length ?? 0;
Console.WriteLine($"Output: {length10}");
Console.WriteLine("Process:");
Console.WriteLine("- name2 is null, name2?.Length returns null");
Console.WriteLine("- ?? operator checks if left side is null");
Console.WriteLine("- Since it IS null, returns right side (0)\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q11
Console.WriteLine("Q11: Safe Code with Null-Coalescing");
Console.WriteLine("Code: string? s = null; int x = int.Parse(s ?? \"0\");");
string? s11 = null;
int x11 = int.Parse(s11 ?? "0");
Console.WriteLine($"Output: {x11}");
Console.WriteLine("Explanation: s is null, so s ?? \"0\" evaluates to \"0\", then int.Parse(\"0\") returns 0.\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q12
Console.WriteLine("Q12: Null-Forgiving Operator !");
Console.WriteLine("Code: string? s = null; Console.WriteLine(s!.Length);");
Console.WriteLine("Problem: The ! operator is the NULL-FORGIVING operator.");
Console.WriteLine("It tells compiler: 'I guarantee this is not null'.");
Console.WriteLine("Compiler suppresses null warning, BUT the value IS null at runtime!");
try
{
    string? s12 = null;
    Console.WriteLine(s12!.Length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Result: NullReferenceException - {ex.Message}");
}

Console.WriteLine("\nSolution: Use null-conditional operator");
Console.WriteLine("Code: Console.WriteLine(s?.Length);");
string? s12b = null;
Console.WriteLine($"Output: {s12b?.Length}\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q13
Console.WriteLine("Q13: Convert.ToInt32 with null");
Console.WriteLine("Code: string? s = null; int x = Convert.ToInt32(s);");
string? s13 = null;
int x13 = Convert.ToInt32(s13);
Console.WriteLine($"Output: {x13}");
Console.WriteLine("Explanation: Convert.ToInt32(null) returns 0 (Convert.ToInt32 treats null as 0).\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q14
Console.WriteLine("Q14: Parse vs Convert.ToInt32 Comparison");
Console.WriteLine("Code: string? s = null;");
Console.WriteLine("\nA) int a = int.Parse(s);");
try
{
    string? s14a = null;
    int a14 = int.Parse(s14a);
    Console.WriteLine($"   Output: {a14}");
}
catch (ArgumentNullException)
{
    Console.WriteLine("   Result: ArgumentNullException");
}

Console.WriteLine("\nB) int b = Convert.ToInt32(s);");
string? s14b = null;
int b14 = Convert.ToInt32(s14b);
Console.WriteLine($"   Output: {b14}");

Console.WriteLine("\nComparison in case of null:");
Console.WriteLine("- int.Parse(null) → ArgumentNullException");
Console.WriteLine("- Convert.ToInt32(null) → Returns 0\n");
Console.WriteLine(new string('-', 70) + "\n");

// Q15
Console.WriteLine("Q15: Null-Coalescing with String Methods");
Console.WriteLine("Task: Print 'Guest' when user is null, otherwise print username in uppercase");
Console.WriteLine("\nCode: string userName = user != null ? user.ToUpper() : \"Guest\";");

Console.WriteLine("\nTesting with null:");
string? user15a = null;
string userName15a = user15a != null ? user15a.ToUpper() : "Guest";
Console.WriteLine($"user = null → Output: {userName15a}");

Console.WriteLine("\nTesting with \"john\":");
string? user15b = "john";
string userName15b = user15b != null ? user15b.ToUpper() : "Guest";
Console.WriteLine($"user = \"john\" → Output: {userName15b}\n");
Console.WriteLine(new string('-', 70) + "\n");
