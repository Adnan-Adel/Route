namespace Assignment5;

public class Program
{
    static void Main()
    {
        bool isParsed;

        // ==================== Part 1: Enums ====================
        Console.WriteLine("==================== Part 1: Enums ====================");
        Console.WriteLine("Q1: Day of the Week\n");

        // Q1: Day of the Week
        DayOfWeek day;
        int dayNumber;

        Console.Write("Enter a day number (1-7): ");
        isParsed = int.TryParse(Console.ReadLine(), out dayNumber);

        day = (DayOfWeek)dayNumber;

        Console.WriteLine($"Day: {day}");

        switch (day)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("It's the Weekend");
                break;
            default:
                Console.WriteLine("It's a Workday");
                break;
        }

        Console.WriteLine("\n=======================================================\n");

        // ==================== Part 2: Arrays ====================
        Console.WriteLine("==================== Part 2: Arrays ====================");
        Console.WriteLine("Q1: Array Statistics\n");

        // Q1: Array Statistics
        int size = 0;
        do
        {
            Console.Write("Enter array size: ");
            isParsed = int.TryParse(Console.ReadLine(), out size);
        } while (!isParsed || size <= 0);

        int[] arr = new int[size];

        // Read array elements from user
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element [{i}]: ");
            isParsed = int.TryParse(Console.ReadLine(), out arr[i]);
        }

        // Calculate statistics
        int sum = 0, max = arr[0], min = arr[0];
        double average = 0.0;

        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        average = (double)sum / size;

        // Display results
        Console.WriteLine($"\nSum     = {sum}");
        Console.WriteLine($"Average = {average}");
        Console.WriteLine($"Max     = {max}");
        Console.WriteLine($"Min     = {min}");
        Console.Write("Reverse = ");

        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
            if (i > 0) Console.Write(", ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Q2: Student Grades Matrix\n");

        // Q2: Student Grades Matrix
        int[,] studentsGrades = new int[3, 4];
        int[] studentSums = new int[3];
        double[] studentAvgs = new double[3];

        // Read grades for all students
        for (int std = 0; std < 3; std++)
        {
            Console.WriteLine($"Student {std + 1}:");
            for (int subj = 0; subj < 4; subj++)
            {
                Console.Write($"  Enter grade for subject {subj + 1}: ");
                isParsed = int.TryParse(Console.ReadLine(), out studentsGrades[std, subj]);
                studentSums[std] += studentsGrades[std, subj];
            }
            Console.WriteLine();
        }

        // Calculate averages
        for (int std = 0; std < 3; std++)
        {
            studentAvgs[std] = (double)studentSums[std] / 4.0;
        }

        // Display student averages
        Console.WriteLine("--- Student Average Scores ---");
        for (int std = 0; std < 3; std++)
        {
            Console.WriteLine($"Student {std + 1} Average: {studentAvgs[std]:F2}");
        }

        // Calculate and display overall class average
        double classAverage = (studentAvgs[0] + studentAvgs[1] + studentAvgs[2]) / 3.0;
        Console.WriteLine($"\nOverall Class Average: {classAverage:F2}");

        Console.WriteLine("\n=======================================================\n");
        // ==================== Part 3: Functions (Methods) ====================
        Console.WriteLine("==================== Part 3: Functions (Methods) ====================");
        Console.WriteLine("Q1: Basic Calculator Functions\n");

        // Q1: Basic Calculator Functions
        double num1, num2;
        char op;

        Console.Write("Enter first number: ");
        isParsed = double.TryParse(Console.ReadLine(), out num1);

        Console.Write("Enter second number: ");
        isParsed = double.TryParse(Console.ReadLine(), out num2);

        Console.Write("Enter operation (+, -, *, /): ");
        isParsed = char.TryParse(Console.ReadLine(), out op);

        switch (op)
        {
            case '+':
                Console.WriteLine($"Result: {Add(num1, num2)}");
                break;
            case '-':
                Console.WriteLine($"Result: {Subtract(num1, num2)}");
                break;
            case '*':
                Console.WriteLine($"Result: {Multiply(num1, num2)}");
                break;
            case '/':
                double result;
                bool success = Divide(num1, num2, out result);
                if (success)
                {
                    Console.WriteLine($"Result: {result}");
                }
                // Error message is already printed in Divide method
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }

        Console.WriteLine("\n-------------------------------------------------------");
        Console.WriteLine("Q2: Circle Calculator with out\n");

        // Q2: Circle Calculator with out
        double radius;
        Console.Write("Enter circle radius: ");
        isParsed = double.TryParse(Console.ReadLine(), out radius);

        double area, circumference;
        bool validRadius = CalculateCircle(radius, out area, out circumference);

        if (validRadius)
        {
            Console.WriteLine($"Area: {area:F2}");
            Console.WriteLine($"Circumference: {circumference:F2}");
        }
        else
        {
            Console.WriteLine("Error: Radius must be positive!");
        }

        Console.WriteLine("\n=======================================================\n");

        // ==================== Console Application project ====================
        Console.WriteLine("==================== Student Grade Manager ====================");
        int[] scores = new int[5];

        for (int i = 0; i < 5; i++)
        {
            do
            {
                Console.Write($"Enter score for Student {i + 1}: ");
                isParsed = int.TryParse(Console.ReadLine(), out scores[i]);

                if (!isParsed || scores[i] < 0 || scores[i] > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a score between 0-100.");
                    isParsed = false;
                }
            } while (!isParsed);
        }

        Console.WriteLine("\n--- Report ---");

        for (int i = 0; i < 5; i++)
        {
            Grade grade = GetGrade(scores[i]);
            Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {grade}");
        }

        double ScoresAverage = CalculateAverage(scores);
        int MinScore, MaxScore;
        GetMinMax(scores, out MinScore, out MaxScore);

        Console.WriteLine($"\nAverage: {ScoresAverage:F1}");
        Console.WriteLine($"Highest Score: {MaxScore}");
        Console.WriteLine($"Lowest Score: {MinScore}");

        Console.WriteLine("\n===========================================");

    }

    // Method definitions
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static bool Divide(double a, double b, out double result)
    {
        result = 0.0;
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return false;
        }
        result = a / b;
        return true;
    }

    static bool CalculateCircle(double radius, out double area, out double circumference)
    {
        area = 0.0;
        circumference = 0.0;

        if (radius <= 0)
        {
            return false;
        }

        area = Math.PI * radius * radius;
        circumference = 2 * Math.PI * radius;
        return true;
    }


    // ---------------------------------------------------------
    static Grade GetGrade(int score)
    {
        if (score >= 90)
            return Grade.A;
        else if (score >= 80)
            return Grade.B;
        else if (score >= 70)
            return Grade.C;
        else if (score >= 60)
            return Grade.D;
        else
            return Grade.F;
    }
    static double CalculateAverage(int[] scores)
    {
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        return (double)sum / scores.Length;
    }
    static void GetMinMax(int[] scores, out int min, out int max)
    {
        min = scores[0];
        max = scores[0];

        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < min)
                min = scores[i];
            if (scores[i] > max)
                max = scores[i];
        }
    }
}



public enum DayOfWeek
{
    Saturday = 1,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}

public enum Grade
{
    A,
    B,
    C,
    D,
    F
}
