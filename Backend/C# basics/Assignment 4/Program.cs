using System.Text;
using System.Diagnostics;

namespace tmp
{
    public class Program
    {
        static void Main()
        {
            // ==================== Question 01 ====================
            Console.WriteLine("==================== Question 01 ====================");
            Console.WriteLine("String vs StringBuilder Performance Comparison\n");

            // (a) Explanation of inefficiency:
            /* 
             * WHY STRING CONCATENATION IS INEFFICIENT:
             * - Strings in C# are IMMUTABLE (cannot be changed after creation)
             * - Each += operation creates a NEW string object in memory
             * - The old string becomes garbage, waiting for collection
             * - For 5000 iterations, this creates ~5000 temporary objects
             * - Memory overhead: O(n²) due to repeated copying
             */

            // (c) Timing - Original inefficient version
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string productList = "";
            for (int i = 1; i <= 5000; i++)
            {
                productList += "PROD-" + i + ",";
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed using String concatenation: {ts}");

            // (b) Rewritten using StringBuilder
            stopWatch.Reset();
            stopWatch.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5000; i++)
            {
                sb.Append("PROD-" + i + ",");
            }
            string result = sb.ToString();

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed using StringBuilder:      {ts}");

            Console.WriteLine("\n✓ StringBuilder is significantly faster because:");
            Console.WriteLine("  - Uses a mutable buffer.");
            Console.WriteLine("  - Modifies in place without creating new objects");
            Console.WriteLine("  - Time complexity: O(n) instead of O(n²)\n");
            Console.WriteLine("=====================================================\n");

            // ==================== Question 02 ====================
            Console.WriteLine("==================== Question 02 ====================");
            Console.WriteLine("Cinema Ticket Pricing System\n");

            // Get user inputs with validation
            Console.Write("Enter age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            Console.Write("Enter day of week (1=Mon ... 7=Sun): ");
            int dayOfWeek;
            while (!int.TryParse(Console.ReadLine(), out dayOfWeek) || dayOfWeek < 1 || dayOfWeek > 7)
            {
                Console.Write("Invalid input. Please enter a number between 1-7: ");
            }

            Console.Write("Do you have a student ID? (yes/no): ");
            string studentInput = Console.ReadLine()?.ToLower() ?? "no";
            bool hasStudentId = (studentInput == "yes" || studentInput == "y");

            // Calculate price with breakdown
            decimal price = 0;
            string breakdown = "";

            // (a) Using if-else if-else statements
            // Determine base price by age
            if (age < 5)
            {
                price = 0;
                breakdown = $"Base Price (Age {age}): Free\n";
            }
            else if (age >= 5 && age <= 12)
            {
                price = 30;
                breakdown = $"Base Price (Age {age}): 30 LE\n";
            }
            else if (age >= 13 && age <= 59)
            {
                price = 50;
                breakdown = $"Base Price (Age {age}): 50 LE\n";
            }
            else // age >= 60
            {
                price = 25;
                breakdown = $"Base Price (Age {age}): 25 LE\n";
            }

            // (b) Apply weekend surcharge (Friday=6, Saturday=7)
            if ((dayOfWeek == 6 || dayOfWeek == 7) && price > 0)
            {
                price += 10;
                string dayName = dayOfWeek == 6 ? "Friday" : "Saturday";
                breakdown += $"Weekend Surcharge ({dayName}): +10 LE\n";
            }

            // Apply student discount (20% off, applied after weekend surcharge)
            if (hasStudentId && price > 0)
            {
                decimal discount = price * 0.20m;
                price -= discount;
                breakdown += $"Student Discount (20%): -{discount:F2} LE\n";
            }

            // (c) Display final price with breakdown
            Console.WriteLine("\n--- Price Breakdown ---");
            Console.Write(breakdown);
            Console.WriteLine("------------------------");
            Console.WriteLine($"Final Price: {price:F2} LE");
            Console.WriteLine("\n=====================================================\n");

            // ==================== Question 03 ====================
            Console.WriteLine("==================== Question 03 ====================");
            Console.WriteLine("Switch Statement vs Switch Expression\n");

            string fileExtension = ".pdf";
            string fileType;

            // (a) Traditional switch statement
            Console.WriteLine("(a) Using Traditional Switch Statement:");
            switch (fileExtension)
            {
                case ".pdf":
                    fileType = "PDF Document";
                    break;
                case ".docx":
                case ".doc":
                    fileType = "Word Document";
                    break;
                case ".xlsx":
                case ".xls":
                    fileType = "Excel Spreadsheet";
                    break;
                case ".jpg":
                case ".png":
                case ".gif":
                    fileType = "Image File";
                    break;
                default:
                    fileType = "Unknown File Type";
                    break;
            }
            Console.WriteLine($"File Extension: {fileExtension} → {fileType}\n");

            // (b) Switch expression (C# 8.0+)
            Console.WriteLine("(b) Using Switch Expression:");
            fileType = fileExtension switch
            {
                ".pdf" => "PDF Document",
                ".docx" or ".doc" => "Word Document",
                ".xlsx" or ".xls" => "Excel Spreadsheet",
                ".jpg" or ".png" or ".gif" => "Image File",
                _ => "Unknown File Type"
            };
            Console.WriteLine($"File Extension: {fileExtension} → {fileType}");


            Console.WriteLine("=====================================================\n");

            // ==================== Question 04 ====================
            Console.WriteLine("==================== Question 04 ====================");
            Console.WriteLine("Ternary Operator - Nested Conditions\n");

            int temperature = 35;
            string weatherAdvice;

            // Using nested ternary operators
            weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." : temperature < 15 ? "Cold. Wear a jacket." : temperature < 25 ? "Pleasant weather." : temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";

            Console.WriteLine($"Temperature: {temperature}°C");
            Console.WriteLine($"Advice: {weatherAdvice}\n");

            Console.WriteLine("Is the ternary version more readable? NO");
            Console.WriteLine("  - Nested ternary operators are harder to read");
            Console.WriteLine("  - Difficult to maintain and debug");
            Console.WriteLine("\nWhen to use each approach:");
            Console.WriteLine("  - Use if-else: For complex conditions");
            Console.WriteLine("  - Use ternary: For simple binary choices");

            Console.WriteLine("=====================================================\n");

            // ==================== Question 05 ====================
            Console.WriteLine("==================== Question 05 ====================");
            Console.WriteLine("Password Validation System\n");

            string password;
            bool isValid = false;
            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpace = false;
            int attempts = 0;
            int maxAttempts = 5;

            do
            {
                attempts++;
                Console.Write($"Attempt {attempts}/{maxAttempts} - Enter password: ");
                password = Console.ReadLine();

                // Reset flags for each attempt
                hasUpper = false;
                hasDigit = false;
                hasSpace = false;

                // Check minimum length first
                if (password.Length < 8)
                {
                    Console.WriteLine("Password should be at least 8 characters.\n");
                    continue;
                }

                // Check character requirements using foreach
                foreach (char c in password)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        hasUpper = true;
                    }
                    if (c >= '0' && c <= '9')
                    {
                        hasDigit = true;
                    }
                    if (c == ' ')
                    {
                        hasSpace = true;
                    }
                }

                // Validate all requirements
                if (hasUpper && hasDigit && !hasSpace)
                {
                    isValid = true;
                    Console.WriteLine("\n Password accepted!");
                }
                else
                {
                    // Display specific violations
                    Console.WriteLine("Password rejected. Violations:");
                    if (!hasUpper)
                    {
                        Console.WriteLine("  - Must contain at least one uppercase letter");
                    }
                    if (!hasDigit)
                    {
                        Console.WriteLine("  - Must contain at least one digit");
                    }
                    if (hasSpace)
                    {
                        Console.WriteLine("  - Cannot contain spaces");
                    }
                    Console.WriteLine();
                }

                // Check if max attempts reached
                if (attempts >= maxAttempts && !isValid)
                {
                    Console.WriteLine("Account locked. Maximum attempts reached.");
                    break;
                }

            } while (!isValid);

            Console.WriteLine("=====================================================\n");

            // ==================== Question 06 ====================
            Console.WriteLine("==================== Question 06 ====================");
            Console.WriteLine("Array Processing - Exam Scores Analysis\n");

            int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            // (a) Find and display all failing scores (below 50)
            Console.WriteLine("(a) Failing Scores (below 50):");
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 50)
                {
                    Console.WriteLine($"Index {i}: {scores[i]} (Failing)");
                }
            }
            Console.WriteLine();

            // (b) Find the first score above 90 and stop immediately
            Console.WriteLine("(b) First Score Above 90:");
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 90)
                {
                    Console.WriteLine($"Found at index {i}: {scores[i]}");
                    break;
                }
            }
            Console.WriteLine();

            // (c) Calculate class average, excluding scores below 40
            Console.WriteLine("(c) Class Average (excluding scores < 40):");
            int sum = 0;
            int count = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 40)
                {
                    sum += scores[i];
                    count++;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine($"Sum: {sum}, Count: {count}, Average: {average:F2}\n");

            // (d) Count students in each grade range
            Console.WriteLine("(d) Grade Distribution:");
            int gradeA = 0, gradeB = 0, gradeC = 0, gradeD = 0, gradeF = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 90 && scores[i] <= 100)
                {
                    gradeA++;
                }
                else if (scores[i] >= 80 && scores[i] <= 89)
                {
                    gradeB++;
                }
                else if (scores[i] >= 70 && scores[i] <= 79)
                {
                    gradeC++;
                }
                else if (scores[i] >= 60 && scores[i] <= 69)
                {
                    gradeD++;
                }
                else // below 60
                {
                    gradeF++;
                }
            }

            Console.WriteLine($"A (90-100):  {gradeA} students");
            Console.WriteLine($"B (80-89):   {gradeB} students");
            Console.WriteLine($"C (70-79):   {gradeC} students");
            Console.WriteLine($"D (60-69):   {gradeD} students");
            Console.WriteLine($"F (<60):     {gradeF} students");
            Console.WriteLine("=====================================================\n");
        }
    }
}
