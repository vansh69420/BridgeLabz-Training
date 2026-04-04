using System;

class EduQuizGrader
{
    // Multidimensional array to store:
    // Column 0 -> Question
    // Column 1 -> Correct Answer
    // Each row represents one question
    static string[,] quizData =
    {
        { "Which keyword is used to define a class in C#?", "class" },
        { "Which data type stores whole numbers?", "int" },
        { "Which loop runs at least once?", "do-while" },
        { "Which operator is used for logical AND?", "&&" },
        { "What is the entry point method of a C# program?", "Main" },
        { "Array index in C# starts from?", "0" },
        { "Which keyword is used to create an object?", "new" },
        { "Which data type stores true or false?", "bool" },
        { "Which statement handles multiple conditions?", "switch" },
        { "Which operator is used in ternary condition?", "?:" }
    };

    // Program execution starts from Main
    public static void Main(string[] args)
    {
        // Creating object because non-static methods cannot be called directly
        EduQuizGrader quiz = new EduQuizGrader();
        quiz.Start();
    }

    // Controls program flow and role selection
    void Start()
    {
        Console.WriteLine("=== EduQuiz : Student Quiz Grader ===");
        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Teacher");
        Console.WriteLine("2. Student");

        // Taking user choice
        int choice = Convert.ToInt32(Console.ReadLine());

        // Switch used for role-based access
        switch (choice)
        {
            case 1:
                TeacherMenu(); // Teacher can view questions and answers
                break;
            case 2:
                StudentMenu(); // Student can attempt quiz
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }

    // Displays all questions with correct answers (Teacher role)
    void TeacherMenu()
    {
        Console.WriteLine("\n--- Teacher View (Questions & Answers) ---");

        // Loop through all questions
        for (int i = 0; i < quizData.GetLength(0); i++)
        {
            Console.WriteLine("Q " + (i + 1) + ": " + quizData[i, 0]);
            Console.WriteLine("Answer: " + quizData[i, 1]);
            Console.WriteLine();
        }
    }

    // Handles quiz flow for student
    void StudentMenu()
    {
        // Total number of questions
        int totalQuestion = quizData.GetLength(0);

        // Array to store student answers
        string[] studentAns = new string[totalQuestion];

        Console.WriteLine("\n--- Quiz Started ---");

        // Asking questions one by one
        for (int i = 0; i < totalQuestion; i++)
        {
            Console.WriteLine("Q " + (i + 1) + ": " + quizData[i, 0]);
            Console.Write("Your Answer: ");
            studentAns[i] = Console.ReadLine() ?? "";
        }

        // Calculating score
        int score = CalculateScore(studentAns);

        // Showing per-question feedback
        ShowFeedback(studentAns);

        // Displaying final result
        ShowResult(score, totalQuestion);
    }

    // Calculates total score by comparing correct and student answers
    int CalculateScore(string[] studentAns)
    {
        int marks = 0;

        for (int i = 0; i < quizData.GetLength(0); i++)
        {
            // Case-insensitive comparison of answers
            if (quizData[i, 1].Equals(studentAns[i], StringComparison.OrdinalIgnoreCase))
            {
                marks++;
            }
        }
        return marks;
    }

    // Displays correct/incorrect feedback for each question
    void ShowFeedback(string[] studentAns)
    {
        Console.WriteLine("\n--- Detailed Feedback ---");

        for (int i = 0; i < quizData.GetLength(0); i++)
        {
            if (quizData[i, 1].Equals(studentAns[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question " + (i + 1) + " : Correct");
            }
            else
            {
                Console.WriteLine(
                    "Question " + (i + 1) +
                    " : Incorrect (Correct: " + quizData[i, 1] + ")"
                );
            }
        }
    }

    // Calculates percentage and displays pass/fail result
    void ShowResult(int score, int total)
    {
        // Percentage calculation
        double percentage = (score * 100.0) / total;

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Score: " + score + "/" + total);
        Console.WriteLine("Percentage: " + percentage + "%");

        // Ternary operator used for pass/fail decision
        string result = percentage >= 40 ? "PASS" : "FAIL";
        Console.WriteLine("Final Result: " + result);
    }
}
