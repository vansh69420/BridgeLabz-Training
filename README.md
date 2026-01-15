# 🚀 BridgeLabz Training`

### 📅 18 December 2025

- 🎉 **Welcome.cs**: A program that displays a welcome message to introduce basic C# output.
- ➕ **Add2Num.cs**: A program to add two numbers and display the result.
- ⭕ **AreaCircle.cs**: A program to calculate and display the area of a circle given its radius.
- 📊 **Avg3Sum.cs**: A program to calculate the average of three numbers.
- 🌡️ **CeliusToFarhenheit.cs**: A program to convert temperature from Celsius to Fahrenheit.
- 🛤️ **KmToMiles.cs**: A program to convert distance from kilometers to miles.
- ⚡ **Power.cs**: A program to calculate the power of a number (base raised to an exponent).
- 📐 **RectPerimeter.cs**: A program to calculate the perimeter of a rectangle.
- 💰 **SimpleInterest.cs**: A program to calculate simple interest based on principal, rate, and time.
- 🛢️ **VolumeCylinder.cs**: A program to calculate the volume of a cylinder given radius and height.

## 📅 19 December 2025

### 📘 C# Fundamentals Practice

---

### 📋 DataTypes.cs

Worked on **C# data types** and **type casting concepts** with clear examples.

#### 🔹 Data Types Covered

- **int** – Integer values (e.g., `5`)
- **double** – High-precision floating-point values (e.g., `5.0`)
- **float** – Floating-point values (e.g., `3.5f`)
- **char** – Single character values (e.g., `'A'`)
- **string** – Sequence of characters (e.g., `"Hello World"`)
- **bool** – Boolean values (`true` / `false`)

#### 🔹 Type Casting

- **Implicit Casting**

  - `int → float`
  - `int → double`
  - `char → int`
  - `char → double`
  - `char → float`

- **Explicit Casting**

  - `int → char`
  - `double → int`
  - `double → float`
  - `double → char`
  - `float → int`
  - `float → double`
  - `float → char`

- **Conversion to String**
  - Used `ToString()` with `int`, `double`, `float`, and `char`

---

### 🔢 Operations.cs

Practiced **operators in C#** with real examples.

#### 🔹 Operators Covered

- **Arithmetic Operators**  
  `+` `-` `*` `/` `%`

- **Relational Operators**  
  `==` `!=` `>` `<` `>=` `<=`

- **Logical Operators**  
  `&&` `||` `!`

- **Assignment Operators**  
  `+=` `-=` `*=` `/=` `%=`

- **Unary Operators**  
  `++` `--` (pre and post increment/decrement)

- **Ternary Operator**  
  `?:` – Used for conditional logic (e.g., finding maximum value)

- **`is` Operator**
  - Used for type checking in inheritance scenarios

---

### 📁 Level 1 Programming Elements

Practiced basic C# programs in `c#-programming-elements/level1/` focusing on user input, calculations, and conversions.

#### 🔹 Programs Completed

- 🧮 **BasicCalculator.cs**: A program that takes two numbers as input and performs basic arithmetic operations (addition, subtraction, multiplication, division).
- 💰 **CourseFeeDiscount.cs**: Calculates the discount amount on a course fee based on given criteria.
- 🌍 **VolumeOfEarth.cs**: Computes the volume of the Earth using mathematical formulas.
- 🛤️ **InputKilometerToMiles.cs**: Converts distance from kilometers to miles with user input.
- 📊 **SamPercentage.cs**: Calculates percentage values, possibly related to a scenario involving Sam.
- 💹 **FindProfitPercentage.cs**: Determines the profit percentage from cost and selling price.
- 🤝 **HandshakeCalculator.cs**: Solves the handshake problem, calculating the number of handshakes among a group of people.
- 📏 **DistanceConverter.cs**: Converts distances between different units (e.g., meters to kilometers).
- 🎓 **InputCourseFeeDiscount.cs**: Applies discount to course fees based on user-provided inputs.
- 🔲 **SquareSide.cs**: Calculates the side length of a square given area or other parameters.
- 📐 **AreaOfTriangle.cs**: Computes the area of a triangle with base and height, including unit conversions.
- 👦 **HarryAge.cs**: Calculates or manipulates age-related data for a scenario involving Harry.
- 📏 **HeightConverter.cs**: Converts height measurements between different units (e.g., feet to centimeters).
- 🛤️ **KIlometerToMiles.cs**: Converts kilometers to miles (note: filename has a typo).
- 🛒 **TotalPurchase.cs**: Calculates the total cost of purchases, possibly with taxes or discounts.
- ✏️ **PenDistribution.cs**: Determines how pens are distributed among people or groups.

---

### 📁 Level 2 Programming Elements

Practiced intermediate C# programs in `c#-programming-elements/level2/` focusing on more complex calculations, conversions, and operations.

#### 🔹 Programs Completed

- 🍫 **DistributingChocolate.cs**: Program to distribute chocolates among people based on given criteria.
- 🔄 **DoubleOperations.cs**: Performs various operations on double data types.
- 🌡️ **FarhenheitToCelsius.cs**: Converts temperature from Fahrenheit to Celsius.
- 💰 **FinalSalary.cs**: Calculates final salary including bonuses or deductions.
- 🔢 **IntOperations.cs**: Demonstrates operations on integer values.
- ➗ **QuotientRemainder.cs**: Calculates quotient and remainder from division operations.
- 💸 **SimpleInterest.cs**: Computes simple interest based on principal, rate, and time.
- 🔄 **Swap.cs**: Swaps the values of two variables.
- 🌡️ **TemperatureConverter.cs**: Converts temperatures between different units.
- ⏰ **TimeDetails.cs**: Handles time-related calculations and conversions.
- 📐 **TriangularPark.cs**: Calculates area or perimeter of a triangular park.
- ⚖️ **WeightConverter.cs**: Converts weight measurements between different units.

---

### ✅ Key Learnings

- Understood C# primitive data types
- Learned implicit vs explicit type casting
- Practiced operator usage for logical conditions
- Improved confidence in writing clean C# console programs
- Developed skills in user input handling and basic calculations

## 📅 20 December 2025

### 🔒 AccessModifier.cs

Worked on **C# access modifiers** demonstrating different levels of accessibility in classes and inheritance.

#### 🔹 Access Modifiers Covered

- **public**: Accessible from anywhere
- **private**: Accessible only within the same class
- **protected**: Accessible within the same class and derived classes
- **internal**: Accessible within the same assembly
- **protected internal**: Accessible within the same assembly or derived classes
- **private protected**: Accessible within the same class or derived classes in the same assembly

#### 🔹 Code Demonstration

- Created `PublicClass` with public members accessible from Main
- Created `InternalClass` with internal members accessible within the same assembly
- Created `BaseClass` with members using all access modifier types
- Created `DerivedClass` inheriting from `BaseClass` to demonstrate inheritance access rules
- In Main method, instantiated classes and accessed members based on their access levels

#### 🔹 Key Points on Access Modifiers

- **public**: No restrictions on access; can be accessed from any code
- **private**: Highest level of restriction; only accessible within the declaring class
- **protected**: Accessible within the declaring class and any derived classes
- **internal**: Accessible within the same assembly but not from other assemblies
- **protected internal**: Accessible within the same assembly or from derived classes in other assemblies
- **private protected**: Accessible within the declaring class or derived classes, but only within the same assembly
- Access modifiers are crucial for encapsulation and controlling the visibility of class members
- Inheritance expands accessibility for protected and related modifiers to derived classes

## 📅 22 December 2025

### Control Flow Level 1 Programs

Practiced control flow statements in C# with programs in `control-flow/Level1/` focusing on conditional statements, loops, and decision-making.

#### 🔹 Programs Completed

- 🔍 **CheckDivisibility.cs**: Checks if a number is divisible by 5.
- 📏 **CheckLargest.cs**: Finds the largest among given numbers.
- 🔢 **CheckNumber.cs**: Performs checks on numbers (e.g., positive, negative, zero).
- 🔢 **Counter.cs**: Implements a counter using loops.
- 🔄 **CounterByFor.cs**: Counter implementation using for loop.
- 🗳️ **EligibleVoter.cs**: Determines if a person is eligible to vote based on age.
- ❗ **FactorialUsingFor.cs**: Calculates factorial using for loop.
- 🔁 **FactorialUsingWhile.cs**: Calculates factorial using while loop.
- 💰 **FindBonus.cs**: Calculates bonus based on criteria.
- 🔄 **FindOddEven.cs**: Identifies if a number is odd or even.
- 📉 **FirstSmallest.cs**: Finds the smallest number in a set.
- 🌿 **NaturalNumber.cs**: Works with natural numbers.
- 🌸 **SpringSeason.cs**: Checks if a date falls in spring season.
- ➕ **SumOfNatruralNum.cs**: Calculates sum of natural numbers.
- 🔢 **SumOfNum2.cs**: Sums up numbers.
- 🛑 **SumOfNumTillZero.cs**: Sums numbers until zero is encountered.
- ➕ **SumUsingFor.cs**: Sum calculation using for loop.
- 📊 **Table.cs**: Generates multiplication table.

### Control Flow Level 2 Programs

Practiced intermediate control flow programs in `control-flow/Level2/` focusing on more complex logic, algorithms, and calculations.

#### 🔹 Programs Completed

- 🏋️ **BMI.cs**: Calculates Body Mass Index based on height and weight.
- 🔢 **CheckPrime.cs**: Checks if a given number is prime.
- 🔍 **Factor.cs**: Finds factors of a number.
- 📅 **FindLeapYear.cs**: Determines if a year is a leap year.
- 📅 **FindLeapYear2.cs**: Another implementation for leap year check.
- ⚡ **FindPower.cs**: Calculates power of a number.
- 🎉 **FizzBuzz.cs**: Implements the classic FizzBuzz problem.
- 🎉 **FizzBuzz2.cs**: Alternative FizzBuzz implementation.
- 📊 **GradeCalculate.cs**: Calculates grades based on scores.
- 🔍 **GreatestFactor.cs**: Finds the greatest factor of a number.
- ✖️ **Multiple.cs**: Works with multiples of numbers.
- 👥 **YoungestTallest.cs**: Finds youngest and tallest among a group.

### Control Flow Level 3 Programs

Practiced advanced control flow programs in `control-flow/Level3/` focusing on number theory, algorithms, and complex calculations.

#### 🔹 Programs Completed

- 🌟 **Abundant.cs**: Checks if a number is abundant.
- 💪 **Armstrong.cs**: Checks for Armstrong numbers.
- 🧮 **Calculator.cs**: Implements a calculator with multiple operations.
- 📅 **DayOfWeek.cs**: Determines the day of the week for a given date.
- 🔢 **DigitCounter.cs**: Counts digits in a number.
- 🔮 **Harshad.cs**: Checks for Harshad numbers.

### ✅ Key Learnings

- Mastered if-else statements for decision making
- Practiced for and while loops for iteration
- Learned to handle user input in control flow scenarios
- Improved logic building for various conditions

## 📅 23 December 2025

### Arrays Level 1 — Brief Summaries

- `CanVote.cs`: Reads 10 ages into an array and prints whether each age is invalid, eligible (>=18), or not eligible.
- `Factors.cs`: Reads a number and collects/prints all its factors, expanding the storage array dynamically if needed.
- `FindPositive.cs`: Reads 5 numbers, labels each as positive-even, positive-odd, negative, or zero; compares first and last elements.
- `FizzBuzz.cs`: Builds a FizzBuzz array up to N and prints Fizz/Buzz/FizzBuzz or the number for each index.
- `MeanHeight.cs`: Reads 11 height values (cm), computes and prints the mean height.
- `MultiDimensional.cs`: Reads a rows×cols matrix, flattens it into a single array, and prints the elements.
- `Multiplication.cs`: Builds and prints the multiplication table (1–10) for a given number using an array.
- `OddEven.cs`: Generates and prints lists of even and odd numbers from 0 up to a given number.
- `SumOfAllNumbers.cs`: Reads positive numbers into an array until non-positive input or full, then prints their sum.
- `Table.cs`: Computes and prints multiplication results for multipliers 6 through 9 for a given number.

## 📅 24 December 2025

### Arrays Level2

- **BMI.cs**: Calculates BMI for multiple persons using separate arrays for weights, heights, BMI values, and weight status, categorizing each person as Underweight, Normal, Overweight, or Obese.
- **BMI2.cs**: Similar to BMI.cs but uses a 2D array for person data (weight, height, BMI) and includes input validation for positive values.
- **Frequency.cs**: Takes a number, extracts its digits into an array, and counts the frequency of each digit (0-9).
- **Largest.cs**: Extracts digits of a number into an array and finds the largest and second largest digits.
- **Largest2.cs**: Similar to Largest.cs but dynamically resizes the array if more than 10 digits.
- **Result.cs**: Calculates percentages and grades for students based on marks in Physics, Chemistry, and Maths using separate arrays, with input validation.
- **Result2.cs**: Similar to Result.cs but uses a 2D array for marks.
- **ReverseNumber.cs**: Reverses the digits of a number by storing them in an array and printing in reverse order.
- **Salary.cs**: Calculates bonuses and new salaries for 10 employees based on years of service, with totals for old salaries, bonuses, and new salaries.
- **YoungestTallest.cs**: Finds the youngest and tallest person among 3 persons by comparing ages and heights.

### Key Points

- Learned to use 1D and 2D arrays for storing multiple data types (integers, doubles, strings).
- Implemented input validation to handle invalid or negative inputs, ensuring data integrity.
- Performed various calculations like BMI, percentages, and bonuses using array data.
- Used loops for array traversal and conditional logic for categorization (weight status, grades).
- Manipulated digits of numbers using arrays for frequency counting and finding largest/second largest digits.
- Dynamically resized arrays when the number of digits exceeds initial capacity.
- Calculated totals and aggregates across arrays for salaries, bonuses, and marks.

## 📅 25 December 2025

### Methods Level 1 Programs

Practiced basic method implementations in C# with programs in `methods/Level1/` focusing on mathematical calculations, conditionals, and returning values.

#### 🔹 Programs Completed

- 🍫 **Chocolate.cs**: Distributes chocolates among students and calculates remainder using quotient-remainder method.
- 🔢 **CountRounds.cs**: Calculates number of rounds that can be formed with given triangle sides' perimeter.
- 🔍 **FindNumber.cs**: Determines if a number is positive, negative, or zero using a method.
- 🤝 **HandshakeCalculator.cs**: Computes total handshakes among people using combinatorial formula.
- 🤝 **HandshakeCalculator2.cs**: Alternative implementation of handshake calculation.
- 📏 **LargestSmallest.cs**: Finds largest and smallest among three numbers, returns as array.
- ➗ **QuotientRemainder.cs**: Calculates quotient and remainder of division, returns as array.
- 💰 **SimpleInterest.cs**: Computes simple interest based on principal, rate, and time.
- 🌸 **SpringSeason.cs**: Checks if given date falls in spring season (March 20 - June 20).
- ➕ **SumOfNNumbers.cs**: Calculates sum of first N natural numbers using formula.
- 📐 **Trignometric.cs**: Computes sine, cosine, and tangent of an angle in degrees.
- 🌬️ **WindChill.cs**: Calculates wind chill temperature using weather formula.

### Methods Level 2 Programs

Practiced intermediate method usage in C# with programs in `methods/Level2/` focusing on arrays, random generation, and complex calculations.

#### 🔹 Programs Completed

- 🏋️ **BMICalculator.cs**: Calculates BMI for 10 persons using 2D arrays, categorizes weight status.
- 🔢 **Factors.cs**: Finds all factors of a number, computes sum, product, and sum of squares.
- 📅 **FindLeapYear.cs**: Checks if a given year is a leap year.
- 👥 **FriendComparison.cs**: Compares ages and heights of three friends to find youngest and tallest.
- 🔍 **NumberAnalysis.cs**: Analyzes 5 numbers for positive/negative, even/odd, and compares first/last elements.
- 🔢 **Quadratic.cs**: Solves quadratic equations and finds real roots.
- 🎲 **RandomNumberAnalysis.cs**: Generates 5 random 4-digit numbers, finds average, min, max.
- 🗳️ **StudentVoteChecker.cs**: Checks voting eligibility for 10 students based on age.
- ➕ **SumOfNNumbers.cs**: Calculates sum using both recursion and formula, compares results.
- 🔄 **UnitConvertor.cs**: Provides comprehensive unit conversions (length, temperature, weight, volume).

### Methods Level 3 Programs

Practiced advanced method implementations in C# with programs in `methods/Level3/` focusing on algorithms, matrix operations, and number theory.

#### 🔹 Programs Completed

- 📅 **Calendar.cs**: Displays a calendar for any given month and year using Gregorian algorithm.
- 📐 **CollinearPoints.cs**: Checks if three points are collinear using slope and area methods.
- 📏 **DistanceAndLine.cs**: Calculates Euclidean distance between points and finds line equation.
- 💼 **EmployeeBonus.cs**: Generates random salaries and service years for 10 employees, calculates bonuses.
- ⚽ **FootballTeamHeight.cs**: Analyzes heights of 11 football players (sum, mean, shortest, tallest).
- 🔢 **MatrixOperations.cs**: Implements matrix addition, subtraction, multiplication, transpose, determinant, and inverse.
- 🔍 **NumberChecker.cs**: Comprehensive number analysis (prime, armstrong, palindrome, duck, harshad, etc.).
- 🔐 **OTPGenerator.cs**: Generates 10 unique 6-digit OTPs and verifies uniqueness.
- 📊 **StudentMarks.cs**: Generates random scores for students, calculates totals, averages, percentages.

### ✅ Key Learnings

- Mastered method creation and usage with parameters and return values
- Learned to work with arrays as method parameters and return types
- Implemented mathematical formulas and algorithms using methods
- Practiced random number generation and data validation
- Developed skills in matrix operations and number theory
- Improved code organization by separating logic into reusable methods
- Enhanced understanding of method overloading and different return types

## 📅 26 December 2025

### 🔤 C# String Fundamentals

Practiced basic string operations and exception handling in C# with programs in `c#-string/` focusing on string manipulation, conversions, and error handling.

#### 🔹 Programs Completed

- ⚠️ **ArgumentOutOfRange.cs**: Demonstrates `ArgumentOutOfRangeException` when substring index exceeds string length.
- 🔍 **CompareString.cs**: Compares two strings character-by-character and using built-in `Equals()` method.
- ⚠️ **FormatExceptionDemo.cs**: Shows `FormatException` when parsing non-numeric string to integer.
- ⚠️ **IndexOutOfRange.cs**: Illustrates `IndexOutOfRangeException` when accessing string index out of bounds.
- ⚠️ **IndexOutOfRangeArrays.cs**: Demonstrates `IndexOutOfRangeException` for array access beyond bounds.
- 🔤 **Lowercase.cs**: Converts string to lowercase using custom method and built-in `ToLower()`.
- ⚠️ **NullReference.cs**: Shows `NullReferenceException` when accessing methods on null string.
- 🔤 **ReturnCharacter.cs**: Converts string to character array using custom method and `ToCharArray()`.
- ✂️ **SubString.cs**: Extracts substring using custom character access and built-in `Substring()`.
- 🔤 **Uppercase.cs**: Converts string to uppercase using custom method and built-in `ToUpper()`.
- 📏 **WordLengthCalculator.cs**: Splits sentence into words and calculates lengths without using `Split()`.

### 🔤 Advanced C# String Operations

Practiced advanced string manipulation techniques in C# with programs in `extras-c#-string/` focusing on algorithms, pattern matching, and text processing.

#### 🔹 Programs Completed

- 🔄 **AnagramsString.cs**: Checks if two strings are anagrams by sorting and comparing characters.
- 🔢 **CountVowelsConsonants.cs**: Counts vowels and consonants in a given string.
- 📊 **FrequentCharacter.cs**: Finds the most frequently occurring character in a string.
- 🔤 **LexicographicallyComparison.cs**: Compares two strings lexicographically (dictionary order).
- 📏 **LongestWord.cs**: Identifies the longest word in a sentence.
- 🔄 **PalindromeString.cs**: Checks if a string reads the same forwards and backwards.
- ✂️ **RemoveCharacter.cs**: Removes all occurrences of a specific character from a string.
- 🧹 **RemoveDuplicate.cs**: Eliminates duplicate characters from a string.
- 🔄 **ReplaceWord.cs**: Replaces occurrences of a word in a sentence with another word.
- 🔄 **Reverse.cs**: Reverses the characters in a string.
- 🔍 **SubstringOccurence.cs**: Counts how many times a substring appears in a main string.
- 🔄 **ToggleCase.cs**: Toggles the case (upper/lower) of each character in a string.

### ✅ Key Learnings

- Mastered string manipulation without relying on built-in methods
- Learned exception handling for common string-related errors
- Implemented character-level operations and conversions
- Developed algorithms for text analysis and pattern matching
- Practiced array-based string processing techniques
- Enhanced understanding of ASCII values and character transformations
- Improved skills in parsing and validating string inputs
- Gained experience with substring operations and word processing

## 📅 27 December 2025

### 🕒 C# Built-in DateTime Operations

Practiced DateTime and TimeZone operations in C# with programs in `extras-c#-built-in/Level1/` focusing on date arithmetic, comparisons, formatting, and time zone conversions.

#### 🔹 Programs Completed

- 📅 **DateArithmetic.cs**: Performs date arithmetic operations (add days, months, years, subtract weeks) on user-input date.
- 🔍 **DateComparison.cs**: Compares two dates using `DateTime.Compare()` to determine which is earlier, later, or same.
- 📝 **DateFormatting.cs**: Displays current date in various formats (dd/MM/yyyy, yyyy-MM-dd, full date with day).
- 🌍 **TimeZoneDemo.cs**: Converts current UTC time to IST (India Standard Time) and PST (Pacific Standard Time) using `TimeZoneInfo`.

### 🧮 C# Built-in Mathematical Operations

Practiced mathematical computations and algorithms in C# with programs in `extras-c#-built-in/Level2/` focusing on calculators, sequences, number theory, and conversions.

#### 🔹 Programs Completed

- 🧮 **BasicCalculator.cs**: Menu-driven calculator for addition, subtraction, multiplication, division with error handling for division by zero.
- ❗ **Factorial.cs**: Calculates factorial of a number using recursion, with input validation for negative numbers.
- 🔢 **FibonacciGenerator.cs**: Generates Fibonacci sequence up to N terms using iterative approach.
- 🔗 **GcdLcm.cs**: Computes GCD using Euclidean algorithm and LCM using formula, handles zero inputs.
- 📈 **MaximumOfThree.cs**: Finds maximum among three numbers using conditional logic.
- 🎯 **NumberGuessing.cs**: Implements binary search algorithm for computer to guess user's number between 1-100.
- 🔄 **PalindromeChecker.cs**: Checks if a string is palindrome using two-pointer technique, case-insensitive.
- 🔍 **PrimeNumberChecker.cs**: Determines if a number is prime using trial division up to square root.
- 🌡️ **TemperatureConverter.cs**: Converts between Fahrenheit and Celsius with menu selection.

### ✅ Key Learnings

- Mastered DateTime operations for date manipulation and formatting
- Learned time zone conversions using built-in .NET classes
- Implemented recursive algorithms for factorial and iterative for sequences
- Developed menu-driven console applications with input validation
- Practiced number theory algorithms (GCD, LCM, prime checking)
- Enhanced skills in user interaction and feedback loops
- Gained experience with mathematical conversions and error handling
- Improved understanding of built-in .NET methods for common operations

## 📅 28 December 2025

### 🎲 SnakesAndLadder.cs

Implemented a complete Snake and Ladder game in C# supporting 2-4 players with interactive gameplay, dice rolling, and win conditions.

#### 🔹 Game Features

- **Multiplayer Support**: Accepts 2-4 players with custom names
- **Dice Rolling**: Random dice rolls (1-6) using `Random` class
- **Snakes & Ladders**: Predefined positions for snakes (down) and ladders (up)
- **Game Board**: 100-position board with win condition at position 100
- **Turn-based Play**: Sequential player turns with dice roll prompts
- **Position Tracking**: Displays movement from old to new position
- **Win Detection**: Automatic win detection when reaching position 100

#### 🔹 Technical Implementation

- Used arrays to store snake and ladder start/end positions
- Implemented helper methods: `RollDice()`, `ApplySnakeOrLadder()`, `CheckWin()`
- Input validation for player count (2-4 players)
- Game loop continues until a player wins
- Console-based user interface with emojis for visual appeal

#### 🔹 Key Learnings

- Practiced array manipulation for game state management
- Implemented game logic with conditional checks and loops
- Learned random number generation for dice simulation
- Developed turn-based multiplayer game mechanics
- Enhanced user input handling and validation

## 📅 29 December 2025

### Scenario-Based Programs

Practiced real-world scenario implementations in C# with programs in `scenario-based/` focusing on game development, text processing, data analysis, and temperature monitoring.

#### 🔹 Programs Completed

- 📝 **SentenceFormatter.cs**: A dual-purpose text processing program with sentence formatting and paragraph analysis capabilities.

  - **Sentence Formatter**: Capitalizes first letters after punctuation, adds proper spacing, handles case conversion manually without built-in methods
  - **Paragraph Analyzer**: Counts words, finds longest word, performs case-insensitive word replacement using custom string manipulation

- 📊 **StudentScoreManager.cs**: A student performance analysis system that manages scores for multiple students.

  - Reads scores for N students with input validation (no negative scores)
  - Calculates average, highest, and lowest scores
  - Displays all scores above the calculated average
  - Uses array-based data storage and processing

- 🌡️ **TemperatureAnalyzer.cs**: A weather data analysis program processing 7 days of hourly temperature readings.
  - Analyzes 2D array of temperature data (7 days × 24 hours)
  - Identifies hottest and coldest days with their temperatures
  - Calculates and displays average temperature for each day
  - Demonstrates 2D array traversal and statistical computations

#### 🔹 Technical Highlights

- **Custom String Manipulation**: Implemented character-level operations without relying on built-in string methods
- **Array Processing**: Extensive use of 1D and 2D arrays for data storage and analysis
- **Input Validation**: Robust error handling for invalid inputs (empty strings, negative scores)
- **Statistical Calculations**: Average computation, min/max finding, frequency analysis
- **Menu-Driven Interfaces**: User choice selection for different program functionalities

#### 🔹 Key Learnings

- Mastered manual string processing techniques using character arrays
- Developed skills in multi-dimensional array operations
- Implemented data validation and error handling patterns
- Practiced statistical analysis on structured data
- Enhanced understanding of real-world problem decomposition
- Improved code organization with helper methods and modular design

## 📅 30 December 2025

### 📚 Library Management System

Developed a **comprehensive Library Management System** in `scenario-based/LibraryManagementSystem.cs` implementing role-based access control and book inventory management.

#### 🔹 System Features

- **Role-Based Access**: Separate menus for Librarians and Members with different permissions
- **Book Inventory**: Pre-loaded with 15 technical books stored in a 2D array (Title, Author, Status)
- **Search Functionality**: Case-insensitive partial title search with custom string manipulation
- **Book Operations**: Checkout, return, add, and remove books with status tracking
- **Dynamic Array Management**: Manual array resizing for adding/removing books

#### 🔹 User Roles & Permissions

- **👨‍💼 Librarian**:

  - View all books in the library
  - Search for specific books
  - Checkout books for members
  - Return checked-out books
  - Add new books to inventory
  - Remove books from inventory

- **👤 Member**:
  - Search for available books
  - Checkout books (if available)

#### 🔹 Technical Implementation

- **Data Structure**: 2D string array for book storage (`string[,]` with dimensions [books, 3])
- **Custom String Functions**: Implemented `ToLower()` and `ContainIgnoreCase()` without built-in methods
- **Array Manipulation**: Manual copying and resizing arrays for dynamic book management
- **Menu-Driven Interface**: Console-based navigation with input validation
- **Status Tracking**: Real-time book availability updates ("Available" / "Checked Out")

#### 🔹 Key Code Highlights

- Manual string case conversion using ASCII arithmetic
- Partial string matching for search functionality
- Array expansion/contraction for dynamic inventory
- Switch-case menu systems for user interaction
- Error handling for invalid inputs and not-found books

#### 🔹 Learning Outcomes

- Advanced array manipulation techniques
- Custom string processing algorithms
- Role-based system design principles
- Dynamic data structure management
- User interface design for console applications
- Problem decomposition for complex scenarios

### 🎓 Educational Quiz Grader

Created an **interactive educational quiz system** in `scenario-based/EduQuizGrader.cs` with role-based access for teachers and students, featuring automated grading and detailed feedback.

#### 🔹 System Features

- **Role-Based Access**: Separate interfaces for Teachers (view answers) and Students (take quiz)
- **Quiz Database**: 10 multiple-choice questions on C# fundamentals stored in 2D array
- **Automated Grading**: Case-insensitive answer comparison with instant scoring
- **Detailed Feedback**: Per-question correctness display with correct answers shown for wrong responses
- **Performance Metrics**: Score calculation, percentage, and pass/fail determination (40% threshold)

#### 🔹 User Roles & Functionality

- **👨‍🏫 Teacher**:

  - View all quiz questions with their correct answers
  - Access complete question bank for review purposes

- **👨‍🎓 Student**:
  - Take the 10-question C# fundamentals quiz
  - Receive immediate detailed feedback after completion
  - View final score, percentage, and pass/fail status

#### 🔹 Technical Implementation

- **Data Structure**: 2D string array for question-answer pairs (`string[,]` with dimensions [10, 2])
- **Answer Validation**: Case-insensitive string comparison using `StringComparison.OrdinalIgnoreCase`
- **Score Calculation**: Percentage-based evaluation with ternary operator for pass/fail logic
- **User Interface**: Menu-driven console application with clear navigation
- **Feedback System**: Comprehensive per-question analysis with correct answer disclosure

#### 🔹 Quiz Content Coverage

- C# class definition (`class` keyword)
- Data types (`int`, `bool`)
- Control structures (`do-while`, `switch`)
- Operators (`&&`, `?:`)
- Program structure (`Main` method)
- Array indexing (starts from `0`)
- Object creation (`new` keyword)

#### 🔹 Key Code Highlights

- Role-based menu system with switch-case navigation
- Array iteration for quiz administration and grading
- String comparison techniques for answer validation
- Percentage calculation and conditional result determination
- Structured feedback display with question-by-question breakdown

#### 🔹 Learning Outcomes

- Educational software design principles
- Automated assessment system implementation
- Case-insensitive string handling techniques
- Performance evaluation algorithms
- User role management in applications
- Interactive console-based quiz systems

## 📅 31 December 2025

### 🏦 Bank Account Manager System

Developed a comprehensive **Bank Account Management System** using **Object-Oriented Programming (OOP)** principles in C#. This scenario-based project demonstrates role-based access control, data management, and console-based user interfaces.

#### 🔹 Project Structure

- **Bank.cs**: Core banking operations class managing account data and transactions
- **User.cs**: User model class with properties for user identification and roles
- **BankManager.cs**: Main application class handling user authentication, menus, and program flow

#### 🔹 Key Features Implemented

- **Role-Based Access Control**

  - Customer role: View account, deposit, withdraw
  - Staff role: Add accounts, remove accounts, view any account

- **Account Management Operations**

  - Display account details (balance, minimum balance, creation date)
  - Deposit funds with balance updates
  - Withdraw funds with minimum balance validation
  - Add new accounts with initial balance and minimum balance
  - Remove existing accounts

- **Data Storage**
  - 2D string array for storing account information
  - Dynamic array resizing for account additions/removals
  - Account search functionality by account number

#### 🔹 OOP Concepts Applied

- **Encapsulation**: Private fields and public methods in Bank class
- **Abstraction**: Hiding implementation details of account storage and operations
- **Classes and Objects**: User and Bank classes with instantiation
- **Static Members**: Global bank instance and current user in BankManager

#### 🔹 Technical Highlights

- 2D array manipulation for data storage and retrieval
- String-to-numeric conversions for financial calculations
- DateTime handling for account creation timestamps
- Input validation and error handling for transactions
- Menu-driven console interface with switch-case navigation
- Minimum balance enforcement for withdrawals

#### 🔹 Learning Outcomes

- Implementing role-based systems in console applications
- Managing dynamic data structures in C#
- Applying OOP principles to real-world scenarios
- Building interactive banking system interfaces
- Handling financial data with precision and validation

### 🔢 Math Utility Tool

Developed a comprehensive **Mathematical Utility Tool** implementing fundamental algorithms and mathematical functions in C#. This console-based application provides a menu-driven interface for performing various mathematical calculations.

#### 🔹 Features Implemented

- **Factorial Calculation**: Computes factorial of a given number with input validation for negative numbers
- **Prime Number Check**: Determines whether a number is prime using efficient divisibility testing
- **Greatest Common Divisor (GCD)**: Implements Euclidean algorithm for finding GCD of two numbers
- **Fibonacci Sequence**: Generates nth Fibonacci number using iterative approach

#### 🔹 Technical Implementation

- **Menu-Driven Interface**: Switch-case based navigation system for user interaction
- **Input Validation**: Proper handling of edge cases (negative numbers, invalid inputs)
- **Algorithmic Efficiency**: Optimized implementations for each mathematical function
- **Error Handling**: Graceful handling of invalid inputs and edge cases

#### 🔹 Mathematical Algorithms Covered

- **Factorial**: Iterative multiplication from 1 to n
- **Prime Check**: Division testing up to n/2 for efficiency
- **Euclidean GCD**: Repeated modulo operations until remainder is zero
- **Fibonacci**: Iterative addition of previous two numbers

#### 🔹 Learning Outcomes

- Implementing mathematical algorithms in programming
- Input validation and error handling techniques
- Menu-driven console application development
- Understanding algorithmic complexity and efficiency
- Applying mathematical concepts to practical programming problems

## 📅 1 January 2026

### 🧾 Invoice Generator System

Developed a robust **Invoice Generation System** using Object-Oriented Programming principles in C#. This application parses user input to create invoices with multiple tasks and calculates total amounts.

#### 🔹 Project Structure

- **Invoice.cs**: Core invoice class handling task parsing, display, and total calculation
- **InvoiceUtils.cs**: Utility class with static helper methods for input validation and amount extraction
- **Program.cs**: Main entry point managing user interaction and invoice creation

#### 🔹 Key Features Implemented

- **Task Parsing**: Splits comma-separated input into individual invoice tasks
- **Amount Extraction**: Parses task strings to extract names and monetary amounts
- **Invoice Display**: Formatted output showing each task with its cost
- **Total Calculation**: Sums all task amounts for invoice total
- **Input Validation**: Checks for empty or invalid input strings

#### 🔹 OOP Concepts Applied

- **Encapsulation**: Private methods and fields within Invoice class
- **Static Utility Methods**: Reusable helper functions in InvoiceUtils class
- **Object Instantiation**: Creating Invoice objects from user input
- **Method Overloading**: Using out parameters for multiple return values

#### 🔹 Technical Highlights

- **String Manipulation**: Splitting and trimming input strings
- **Error-Safe Parsing**: TryParse for numeric conversion without exceptions
- **Defensive Programming**: Null and empty string checks throughout
- **Modular Design**: Separation of concerns between classes
- **Console I/O**: User-friendly input prompts and formatted output

#### 🔹 Data Processing Flow

1. User enters comma-separated tasks (e.g., "Logo Design - 3000 INR, Web Page - 4500 INR")
2. Input is validated for emptiness
3. Invoice object parses tasks into name-amount pairs
4. Each task is displayed with formatting
5. Total amount is calculated and shown

#### 🔹 Learning Outcomes

- Building real-world business applications in C#
- String parsing and manipulation techniques
- Implementing utility classes for code reusability
- Error handling and input validation strategies
- Designing modular, maintainable object-oriented code

### 🍽️ Cafeteria Menu Management System

Developed a **Role-Based Cafeteria Menu System** using Object-Oriented Programming principles in C#. This application demonstrates separation of concerns with dedicated classes for data management and application flow.

#### 🔹 Project Structure

- **Cafeteria.cs**: Data management class handling menu items and display logic
- **CafeteriaApp.cs**: Application controller managing user roles and menu interactions
- **Program.cs**: Default entry point (main logic moved to CafeteriaApp for better organization)

#### 🔹 Key Features Implemented

- **Role-Based Access Control**

  - Admin role: View-only access to menu items
  - Student role: Full access to view menu and place orders

- **Menu Management**

  - Fixed array of 10 cafeteria items (sandwiches, burgers, beverages, etc.)
  - Indexed display of menu items
  - Item selection by index number

- **User Interaction**
  - Role selection at application startup
  - Menu-driven interface with numbered options
  - Input validation for menu selections

#### 🔹 OOP Concepts Applied

- **Encapsulation**: Private menu array and public accessor methods
- **Separation of Concerns**: Cafeteria class for data, CafeteriaApp for logic
- **Single Responsibility Principle**: Each class has one clear purpose
- **Static Methods**: Utility functions for menu operations

#### 🔹 Technical Highlights

- **Array-Based Data Storage**: Fixed-size array for menu items
- **Switch-Case Navigation**: Clean menu system implementation
- **Input Validation**: Bounds checking for array access
- **Loop-Based Menus**: Do-while loops for continuous user interaction
- **Modular Code Structure**: Logical separation between data and presentation layers

#### 🔹 Application Flow

1. User selects role (Admin/Student) at startup
2. Admin sees menu display only
3. Student gets interactive menu with view/order options
4. Order placement with index-based item selection
5. Graceful exit with confirmation message

#### 🔹 Learning Outcomes

- Implementing role-based systems in console applications
- Applying Single Responsibility Principle in class design
- Managing fixed data structures (arrays) in OOP
- Building interactive menu systems with validation
- Separating data logic from user interface logic

## 📅 5 January 2026

### 🏥 Hospital Management System

Practiced advanced Object-Oriented Programming (OOP) concepts in C# by implementing a comprehensive hospital management system in `oops-c#-practice/scenario-based/HospitalManagement/`.

#### 🔹 System Overview

A complete hospital billing and patient management system demonstrating real-world OOP principles including inheritance, polymorphism, abstraction, and encapsulation.

#### 🔹 Classes and Interfaces Implemented

- **IPayable.cs** 📄  
  An interface defining the contract for payable items.

  - Properties: `Amount` (decimal), `IsPaid` (bool)
  - Methods: `ProcessPayment()`, `PrintReceipt()`  
    _Purpose_: Ensures all bills follow a standard payment interface.

- **Doctor.cs** 👨‍⚕️  
  A sealed class representing medical doctors.

  - Properties: `Name`, `Specialization` (both with validation)
  - Constructor validates inputs to prevent empty values.  
    _Purpose_: Encapsulates doctor information with data integrity.

- **Patient.cs** 🏥  
  An abstract base class for all patient types.

  - Properties: `Name`, `Age` (with range validation), `AssignedDoctor` (read-only)
  - Virtual method: `DisplayInfo()` for polymorphic behavior.  
    _Purpose_: Common foundation for different patient categories.

- **InPatient.cs** 🛏️  
  Inherits from Patient for hospitalized patients.

  - Additional properties: `RoomNumber`, `DaysAdmitted`
  - Overrides `DisplayInfo()` to include inpatient-specific details.  
    _Purpose_: Specialized patient type for those requiring admission.

- **OutPatient.cs** 🚶‍♂️  
  Inherits from Patient for clinic visitors.

  - Additional property: `VisitDate` (with future date validation)
  - Overrides `DisplayInfo()` to show visit information.  
    _Purpose_: Specialized patient type for outpatient services.

- **Bill.cs** 💰  
  Implements IPayable for patient billing.

  - Properties: `BillNumber`, `Patient`, `Amount`, `IsPaid`
  - Methods: `ProcessPayment()`, `PrintReceipt()`
  - Features: Prevents duplicate payments, generates formatted receipts.  
    _Purpose_: Handles financial transactions for patient services.

- **Program.cs** 🚀  
  Main application demonstrating the system functionality.
  - Creates doctors and patients (both inpatient and outpatient)
  - Generates bills and processes payments
  - Showcases polymorphism through `DisplayInfo()` calls  
    _Purpose_: Integration and demonstration of all components.

#### 🔹 OOP Concepts Demonstrated

- **🔒 Encapsulation**: Private fields with public properties, input validation, and controlled access.
- **📈 Inheritance**: Patient hierarchy with InPatient and OutPatient extending base functionality.
- **🎭 Polymorphism**: Virtual and overridden methods for different patient types' information display.
- **🎯 Abstraction**: IPayable interface hiding implementation details of payment processing.
- **🔐 Sealed Classes**: Doctor, InPatient, OutPatient prevent unintended inheritance.
- **✅ Data Integrity**: Comprehensive validation for all inputs (names, ages, amounts, dates).

#### 🔹 Key Features

- **Patient Management**: Support for both inpatient and outpatient categories
- **Doctor Assignment**: Each patient assigned to a specialized doctor
- **Billing System**: Automated bill generation with payment tracking
- **Receipt Generation**: Professional formatted payment receipts
- **Input Validation**: Robust error handling and data validation throughout
- **Polymorphic Display**: Unified interface for displaying different patient types

#### 🔹 Application Flow

1. **Setup**: Create doctors with specializations
2. **Patient Registration**: Instantiate patients (in/out) with assigned doctors
3. **Information Display**: Show patient details using polymorphic methods
4. **Bill Creation**: Generate bills for each patient service
5. **Payment Processing**: Process payments through interface abstraction
6. **Receipt Printing**: Generate and display payment confirmations

#### 🔹 Technical Highlights

- **Interface Implementation**: Clean abstraction for payment operations
- **Inheritance Hierarchy**: Well-structured class relationships
- **Method Overriding**: Runtime polymorphism for display methods
- **Exception Handling**: Argument validation with meaningful error messages
- **Read-Only Properties**: Immutable doctor assignments using private setters
- **Sealed Classes**: Preventing further inheritance where not needed

#### 🔹 Learning Outcomes

- Mastering advanced OOP principles in a practical scenario
- Implementing complex inheritance hierarchies
- Using interfaces for abstraction and loose coupling
- Applying encapsulation for data protection and validation
- Demonstrating polymorphism in real-world applications
- Building maintainable and extensible code structures
- Understanding hospital management system requirements
- Practicing professional coding standards and documentation

### **Bird Sanctuary System**

A concise object-oriented demo showcasing inheritance, interfaces, and polymorphism using multiple bird types.

- **Location:** [oops-c#-practice/scenario-based/BirdSantuarySystem](oops-c#-practice/scenario-based/BirdSantuarySystem)
- **What I implemented (by 5 Jan):**

  - `Bird.cs` — abstract base class with `Name` property and `ToString()` override.
  - `IFlyable.cs` — interface declaring `void Fly()`.
  - `ISwimmable.cs` — interface declaring `void Swim()`.
  - Concrete types: `Eagle`, `Sparrow` (fly only), `Duck`, `Penguin` (swim only), and `Seagull` (both fly + swim).
  - `Utility.cs` — `BirdUtility.ProcessBirds(Bird[] birds)` prints details and invokes behaviors via `is` checks and casting.
  - `Program.cs` — demo entrypoint that constructs a bird array and exercises polymorphism.

- **How to run:**

  - From repo root run: `dotnet run --project oops-c#-practice/scenario-based/BirdSantuarySystem/BirdSantuarySystem.csproj`

- **Highlights:**
  - Separation of concerns: data in `Bird`, behaviors in `IFlyable` / `ISwimmable`.
  - `Seagull` demonstrates multiple capability composition.
  - `BirdUtility` centralizes runtime type-checking and behavior invocation.

### 🚗 Vehicle Rental System

Extended OOP practice by implementing a comprehensive vehicle rental system in `oops-c#-practice/scenario-based/VehicleRent/`, demonstrating inheritance, polymorphism, and abstraction in a real-world rental scenario.

#### 🔹 System Overview

A menu-driven console application for renting different types of vehicles (bikes, cars, trucks) with hourly/daily rates, availability tracking, and bill generation.

#### 🔹 Classes and Interfaces Implemented

- **IRentable.cs** 📄  
  An interface defining the contract for rentable vehicles.

  - Method: `CalculateRent(int duration, bool isHourly)`  
    _Purpose_: Ensures all vehicle types implement rent calculation uniformly.

- **Vehicle.cs** 🚙  
  An abstract base class implementing IRentable for all vehicles.

  - Properties: `VehicleId`, `Brand`, `IsAvailable`, `RentPerDay`, `RentPerHour`
  - Method: `Rent()` to mark vehicle as unavailable
  - Abstract method: `CalculateRent()` for polymorphic implementation.  
    _Purpose_: Common foundation for all vehicle types with shared functionality.

- **Bike.cs** 🏍️  
  Sealed class inheriting from Vehicle for two-wheeler rentals.

  - Rent rates: ₹300/day, ₹40/hour
  - Implements `CalculateRent()` for bike-specific calculations.  
    _Purpose_: Specialized vehicle type for motorcycle rentals.

- **Car.cs** 🚗  
  Sealed class inheriting from Vehicle for four-wheeler rentals.

  - Rent rates: ₹1000/day, ₹150/hour
  - Implements `CalculateRent()` for car-specific calculations.  
    _Purpose_: Specialized vehicle type for passenger car rentals.

- **Truck.cs** 🚚  
  Sealed class inheriting from Vehicle for heavy vehicle rentals.

  - Rent rates: ₹2000/day, ₹300/hour
  - Implements `CalculateRent()` for truck-specific calculations.  
    _Purpose_: Specialized vehicle type for commercial truck rentals.

- **Bill.cs** 💸  
  Static utility class for generating rental bills.

  - Method: `Print()` displays formatted bill with vehicle details, rent type, duration, and total cost.  
    _Purpose_: Handles bill presentation and formatting.

- **Program.cs** 🚀  
  Main application with menu-driven interface.
  - Arrays of Bike, Car, Truck instances
  - Menu system for vehicle type selection
  - Vehicle selection by ID with availability check
  - Rent calculation (hourly/daily) and bill generation.  
    _Purpose_: User interface and system orchestration.

#### 🔹 OOP Concepts Demonstrated

- **🔒 Encapsulation**: Protected fields in Vehicle class with public read-only properties.
- **📈 Inheritance**: Bike, Car, Truck extending Vehicle with specific rent rates.
- **🎭 Polymorphism**: Abstract `CalculateRent()` method implemented differently per vehicle type.
- **🎯 Abstraction**: IRentable interface decoupling rent calculation from implementation.
- **🔐 Sealed Classes**: Bike, Car, Truck prevent further inheritance.
- **🛡️ Data Protection**: Availability tracking and controlled access to vehicle state.

#### 🔹 Key Features

- **Multi-Vehicle Support**: Bikes, cars, and trucks with different pricing
- **Flexible Renting**: Hourly or daily rental options
- **Availability Management**: Real-time tracking of vehicle availability
- **Menu-Driven Interface**: User-friendly console navigation
- **Bill Generation**: Professional formatted rental receipts
- **Input Validation**: ID validation and availability checks

#### 🔹 Application Flow

1. **Vehicle Selection**: Choose from Bike/Car/Truck categories
2. **Availability Display**: Show available vehicles with rates
3. **Vehicle Booking**: Select specific vehicle by ID
4. **Rent Configuration**: Choose hourly/daily and specify duration
5. **Cost Calculation**: Polymorphic rent calculation based on vehicle type
6. **Bill Printing**: Generate and display formatted rental bill

#### 🔹 Technical Highlights

- **Abstract Base Class**: Vehicle providing common functionality
- **Interface Segregation**: IRentable for clean abstraction
- **Polymorphic Arrays**: Arrays of base type holding derived instances
- **Static Utility Class**: Bill for stateless operations
- **Menu System**: Switch-case navigation with input parsing
- **Availability Logic**: Boolean flags for rental state management

#### 🔹 Learning Outcomes

- Implementing polymorphic systems with abstract classes and interfaces
- Building menu-driven console applications
- Managing collections of objects with inheritance
- Applying encapsulation for data integrity
- Creating extensible code structures for similar domains
- Practicing real-world scenario implementation
- Understanding vehicle rental business logic
- Developing user-friendly console interfaces

## 📅 6 January 2026

### 📞 Customer Service Call Management System

Developed a **comprehensive Customer Service Call Management System** implementing object-oriented programming principles with encapsulation, data management, and search functionality.

#### 🔹 System Architecture

**📋 CallLog.cs** - Core Data Model

- **Encapsulation**: Private setters with public getters for data protection
- **Properties**: `PhoneNumber`, `Message`, `Timestamp` with controlled access
- **Constructor**: Parameterized constructor for object initialization
- **String Representation**: Overridden `ToString()` method for formatted display
- **Immutable Design**: Once created, call log data cannot be modified

**🔧 CallManager.cs** - Business Logic Layer

- **Array-Based Storage**: Dynamic call log management using fixed-size array
- **Capacity Management**: Constructor accepts capacity parameter for flexible sizing
- **Add Functionality**: `AddCallLog()` method with overflow protection
- **Search Operations**: Keyword-based search with case-insensitive matching
- **Time Filtering**: Date range filtering for temporal data analysis
- **Error Handling**: Graceful handling of storage capacity limits

**🚀 Program.cs** - Application Entry Point

- **System Initialization**: Creates CallLogManager with specified capacity
- **Sample Data**: Pre-populated with realistic customer service scenarios
- **Demonstration**: Shows search and filtering capabilities in action
- **Time Management**: Uses `DateTime.Now` with relative time calculations

#### 🔹 Key Features Implemented

**🔍 Advanced Search Capabilities**

- **Keyword Search**: Case-insensitive partial matching in message content
- **Time-Based Filtering**: Filter logs within specific date/time ranges
- **Flexible Queries**: Support for various search patterns and criteria

**📊 Data Management**

- **Structured Storage**: Organized call logs with timestamp tracking
- **Capacity Control**: Prevents array overflow with user feedback
- **Real-Time Processing**: Immediate search results and filtering

**🛡️ Robust Design Patterns**

- **Encapsulation**: Private fields with controlled public access
- **Single Responsibility**: Each class handles specific functionality
- **Data Integrity**: Immutable call logs prevent accidental modifications

#### 🔹 Sample Output Scenarios

- **Network Issues**: Multiple logs showing problem reporting and resolution
- **Billing Queries**: Customer service interactions for account-related questions
- **Technical Support**: Internet connectivity and speed-related complaints
- **Time Tracking**: Logs with realistic timestamps for temporal analysis

#### 🔹 Learning Outcomes

- **OOP Principles**: Mastered encapsulation, constructors, and method overriding
- **Array Management**: Dynamic data storage with capacity constraints
- **String Operations**: Case-insensitive searching and text processing
- **DateTime Handling**: Time-based filtering and relative time calculations
- **System Design**: Multi-class architecture with clear separation of concerns
- **Error Handling**: Graceful degradation when storage limits are reached
- **Real-World Modeling**: Practical customer service scenario implementation

## 📅 7 January 2026

### 🏥 Hospital Management System

Developed a **comprehensive Hospital Management System** implementing advanced object-oriented programming principles including inheritance, polymorphism, abstraction, and encapsulation with interface-based design patterns.

#### 🔹 System Architecture

**👨‍⚕️ Doctor.cs** - Sealed Entity Class

- **Sealed Class**: Prevents inheritance to maintain doctor entity integrity
- **Encapsulation**: Private fields with validated public properties
- **Input Validation**: Null/whitespace checks for name and specialization
- **Immutable Design**: Read-only properties after construction

**🏥 Patient.cs** - Abstract Base Class

- **Abstract Class**: Cannot be instantiated directly, serves as base for patient types
- **Protected Constructor**: Ensures proper initialization through derived classes
- **Property Validation**: Age range validation (1-120), name null checks
- **Doctor Association**: Readonly doctor assignment for data integrity
- **Virtual Methods**: `DisplayInfo()` method for polymorphic behavior

**🛏️ InPatient.cs** - Concrete Implementation

- **Sealed Class**: Final implementation preventing further inheritance
- **Inheritance**: Extends Patient abstract class with specific properties
- **Additional Properties**: Room number and days admitted with validation
- **Method Override**: Enhanced `DisplayInfo()` with in-patient specific details
- **Base Method Calling**: Uses `base.DisplayInfo()` for code reuse

**🚶 OutPatient.cs** - Concrete Implementation

- **Sealed Class**: Final implementation for outpatient functionality
- **DateTime Validation**: Prevents future visit dates with business logic
- **Inheritance**: Extends Patient with visit-specific properties
- **Polymorphic Behavior**: Different display implementation than InPatient

**💰 IPayable.cs** - Interface Contract

- **Interface Definition**: Defines payment-related behavior contract
- **Property Contracts**: Amount and IsPaid status requirements
- **Method Contracts**: ProcessPayment() and PrintReceipt() signatures
- **Abstraction**: Separates payment behavior from implementation details

**🧾 Bill.cs** - Interface Implementation

- **Interface Implementation**: Implements IPayable contract fully
- **Readonly Fields**: Immutable bill data after creation
- **Patient Association**: Links bills to specific patients
- **Payment State Management**: Tracks payment status with business rules
- **Validation Logic**: Comprehensive input validation for all parameters

**🚀 Program.cs** - Application Demonstration

- **Polymorphism Demo**: Same method calls on different patient types
- **Interface Usage**: Working with IPayable abstraction
- **Object Creation**: Demonstrates proper constructor usage
- **System Integration**: Shows all components working together

#### 🔹 OOP Principles Implemented

**🔒 Encapsulation**

- Private fields with public property accessors
- Input validation in property setters
- Controlled access to internal state
- Data integrity through validation rules

**🧬 Inheritance**

- Abstract Patient base class with concrete implementations
- Code reuse through base class functionality
- Specialized behavior in derived classes
- Protected constructors for controlled instantiation

**🎭 Polymorphism**

- Virtual method overriding in DisplayInfo()
- Interface-based polymorphism with IPayable
- Same method calls producing different behaviors
- Runtime method resolution based on object type

**🎯 Abstraction**

- Abstract Patient class defining common structure
- IPayable interface hiding payment implementation details
- Public interfaces hiding internal complexity
- Clear separation of concerns between classes

#### 🔹 Advanced Design Patterns

**🔐 Sealed Classes**

- Doctor, InPatient, OutPatient, and Bill are sealed
- Prevents unintended inheritance and maintains design integrity
- Ensures final implementation behavior
- Optimizes performance by eliminating virtual method calls

**📋 Interface Segregation**

- IPayable interface focuses solely on payment operations
- Clean contract definition for billing functionality
- Enables multiple payment implementations if needed
- Promotes loose coupling between components

**✅ Input Validation**

- Comprehensive validation in all property setters
- Business rule enforcement (age ranges, futuates)
- Exception throwing for invalid inputs
- Data integrity maintenance throughout the system

#### 🔹 System Features Demonstrated

**👥 Patient Management**

- Dual patient types (InPatient/OutPatient) with specialized properties
- Polymorphic patient information display
- Doctor assignment with validation
- Age and name validation with business rules

**💳 Billing System**

- Interface-based payment processing
- Bill generation with unique identifiers
- Payment status tracking and validation
- Receipt generation with formatted output

**🏥 Hospital Operations**

- Room assignment for in-patients
- Visit date tracking for out-patients
- Doctor specialization management
- Comprehensive patient information display

#### 🔹 Sample Output Scenarios

- **Patient Registration**: Creating different patient types with validation
- **Doctor Assignment**: Associating patients with specialized doctors
- **Bill Processing**: Generating and processing payments through interface
- **Information Display**: Polymorphic patient information presentation
- **Receipt Generation**: Formatted payment receipts with status tracking

#### 🔹 Learning Outcomes

- **Advanced OOP Mastery**: Implemented all four pillars of OOP in a cohesive system
- **Interface Design**: Created clean contracts for payment functionality
- **Inheritance Hierarchies**: Built proper abstract-to-concrete class relationships
- **Sealed Class Usage**: Applied sealed classes for design integrity
- **Validation Patterns**: Implemented comprehensive input validation strategies
- **Polymorphic Design**: Created flexible systems using method overriding
- **Real-World Modeling**: Translated hospital operations into object-oriented design
- **Exception Handling**: Proper error handling with meaningful exception messages
- **Code Reusability**: Maximized code reuse through inheritance and base method calls
- **System Integration**: Demonstrated how multiple OOP concepts work together## 📅

## 📅 8 January 2026

### 🔗 Data Structures & Algorithms Mastery

Developed comprehensive **Data Structures and Algorithms** implementations in C# covering linked lists, stacks, queues, and hash maps with real-world applications and algorithmic problem-solving techniques.

#### 🔹 Singly Linked List Implementations

**📦 InventoryManagement.cs** - Product Inventory System

- **Node Structure**: ItemNode with id, name, quantity, price, and next pointer
- **Core Operations**: Add items at head, update quantities by ID, calculate total inventory value
- **Business Logic**: Real-time inventory tracking with efficient O(1) insertion
- **Value Calculation**: Iterative traversal for total inventory worth computation

**👥 SocialMedia.cs** - User Management System

- **Node Structure**: UserNode with user ID, name, and next pointer
- **User Operations**: Add new users, search users by ID with linear traversal
- **Social Features**: Basic user registry with efficient user lookup functionality
- **Search Algorithm**: Sequential search with early termination on match

**🎓 StudentRecord.cs** - Academic Management System

- **Node Structure**: StudentNode with roll number, name, age, grade, and next pointer
- **CRUD Operations**: Add at end, delete by roll number, search, update grades, display all
- **Academic Features**: Complete student lifecycle management with grade tracking
- **Advanced Operations**: Tail insertion, node deletion with pointer manipulation

#### 🔹 Doubly Linked List Implementations

**📚 LibraryManagement.cs** - Book Inventory System

- **Node Structure**: BookNode with bidirectional pointers (prev/next)
- **Library Operations**: Add books at tail, count total books, availability tracking
- **Bidirectional Navigation**: Forward and backward traversal capabilities
- **Data Integrity**: Proper head/tail pointer management for efficient operations

**🎬 MovieManagement.cs** - Movie Database System

- **Node Structure**: MovieNode with title, director, year, rating, and bidirectional links
- **Movie Operations**: Add at end, remove by title, display forward/reverse
- **Flexible Display**: Both chronological and reverse-chronological viewing
- **Deletion Logic**: Complex node removal with proper pointer reconnection

**↩️ UndoRedo.cs** - Text Editor State Management

- **Node Structure**: TextNode with text content and bidirectional navigation
- **Editor Features**: Add states, undo/redo functionality, current state display
- **State Management**: Efficient navigation through document history
- **Memory Efficiency**: Linked structure for unlimited undo/redo operations

#### 🔹 Circular Linked List Implementations

**⚙️ RoundRobin.cs** - Process Scheduling Algorithm

- **Node Structure**: ProcessNode with process ID, burst time, and circular next pointer
- **Scheduling Logic**: Round-robin CPU scheduling simulation with time quantum
- **Circular Navigation**: Continuous process execution in circular fashion
- **OS Concepts**: Real-world operating system process management simulation

**📋 TaskScheduler.cs** - Priority Task Management

- **Node Structure**: TaskNode with ID, name, priority, and circular linking
- **Task Operations**: Add tasks, display all tasks in circular order
- **Priority Handling**: Task scheduling with priority-based organization
- **Circular Display**: Continuous task list traversal for scheduling systems

#### 🔹 Stack & Queue Advanced Algorithms

**🚗 CircularTour.cs** - Petrol Pump Problem

- **Algorithm**: Greedy approach for circular tour feasibility
- **Problem Solving**: Find starting point for completing circular journey
- **Optimization**: Single-pass solution with balance and deficit tracking
- **Real-World Application**: Vehicle routing and fuel management systems

**🔄 QueueUsingStack.cs** - Data Structure Conversion

- **Implementation**: Queue operations using two stacks (s1 for enqueue, s2 for dequeue)
- **Amortized Complexity**: O(1) average time for both enqueue and dequeue operations
- **Stack Operations**: Custom stack implementation with push, pop, isEmpty methods
- **Design Pattern**: Adapter pattern for converting stack interface to queue behavior

**🪟 SlidingWindow.cs** - Maximum in Sliding Window

- **Algorithm**: Deque-based approach for finding maximum in each window
- **Optimization**: O(n) time complexity using monotonic deque technique
- **Window Management**: Efficient sliding window maximum with index tracking
- **Array Processing**: Advanced array manipulation for competitive programming

**📊 SortStack.cs** - Recursive Stack Sorting

- **Algorithm**: Recursive approach for sorting stack elements
- **Recursion**: Deep recursion with insertSorted helper function
- **In-Place Sorting**: Stack sorting without additional data structures
- **Algorithmic Technique**: Divide and conquer approach for stack manipulation

**📈 StockSpan.cs** - Stock Span Problem

- **Algorithm**: Stack-based solution for calculating stock price spans
- **Financial Application**: Real-world stock market analysis problem
- **Monotonic Stack**: Decreasing stack for efficient span calculation
- **Time Complexity**: O(n) solution using stack for previous greater elements

#### 🔹 HashMap & Hash Table Implementations

**🗂️ HashMapArrayLinkedList.cs** - Custom Hash Map Implementation

- **Hash Function**: Modulo-based hashing with collision resolution
- **Collision Handling**: Separate chaining using linked lists
- **Core Operations**: Put, Get, Remove with O(1) average time complexity
- **Memory Management**: Dynamic node creation and deletion for hash buckets

**🔢 LongestSequence.cs** - Longest Consecutive Sequence

- **Algorithm**: Array-based approach for finding longest consecutive integers
- **Sequence Detection**: Linear search for consecutive number identification
- **Optimization**: Brute force approach with potential for hash set improvement
- **Problem Solving**: Classic array manipulation and sequence analysis

**🎯 PairWithGivenSum.cs** - Two Sum Problem Variant

- **Algorithm**: Nested loop approach for finding pairs with target sum
- **Brute Force**: O(n²) solution for pair detection
- **Boolean Logic**: Existence check for sum pairs in array
- **Foundation**: Base implementation for more advanced hashing solutions

**🔍 SubarraysWithZeroSum.cs** - Zero Sum Subarray Detection

- **Algorithm**: Prefix sum approach with cumulative sum tracking
- **Subarray Analysis**: Efficient detection of zero-sum contiguous subarrays
- **Sum Tracking**: Array-based storage for previously seen prefix sums
- **Mathematical Insight**: Zero sum detection using cumulative sum properties

**🎲 TwoSum.cs** - Classic Two Sum Problem

- **Algorithm**: Brute force approach for finding indices of target sum
- **Index Tracking**: Return indices of elements that sum to target
- **Array Traversal**: Nested loop structure for comprehensive pair checking
- **LeetCode Classic**: Foundation problem for hash table optimization techniques

#### 🔹 Algorithmic Concepts Mastered

**🔗 Linked List Variations**

- **Singly Linked**: Forward-only traversal with efficient insertion/deletion
- **Doubly Linked**: Bidirectional navigation with prev/next pointers
- **Circular Linked**: Continuous traversal for scheduling and rotation algorithms

**📚 Stack Applications**

- **Recursive Sorting**: Stack-based sorting with recursive insertion
- **Data Structure Conversion**: Queue implementation using dual stacks
- **Monotonic Stack**: Stock span and sliding window maximum problems

**🚀 Queue Algorithms**

- **Circular Tour**: Greedy algorithm for feasibility checking
- **Sliding Window**: Deque-based maximum finding in subarrays
- **Process Scheduling**: Round-robin algorithm simulation

**🗂️ Hashing Techniques**

- **Separate Chaining**: Collision resolution using linked lists
- **Hash Functions**: Modulo-based key distribution
- **Prefix Sum**: Zero-sum subarray detection with cumulative sums

#### 🔹 Real-World Applications Demonstrated

**🏢 Business Systems**

- **Inventory Management**: Product tracking with quantity and value calculations
- **Library Systems**: Book management with availability tracking
- **Student Records**: Academic data management with CRUD operations

**💻 System Programming**

- **Process Scheduling**: Operating system round-robin simulation
- **Text Editors**: Undo/redo functionality with state management
- **Memory Management**: Custom data structure implementations

**📊 Algorithm Problems**

- **Financial Analysis**: Stock span calculation for market analysis
- **Route Planning**: Circular tour problem for logistics
- **Data Processing**: Sliding window maximum for stream processing

#### 🔹 Learning Outcomes

- **Data Structure Mastery**: Comprehensive understanding of linear data structures
- **Algorithm Design**: Problem-solving with optimal time/space complexity
- **Memory Management**: Efficient pointer manipulation and node operations
- **Real-World Modeling**: Translating business requirements into data structures
- **Competitive Programming**: Classic algorithmic problem-solving techniques
- **System Design**: Understanding of how data structures power real applications
- **Code Optimization**: Writing efficient algorithms with proper complexity analysis
- **Debugging Skills**: Complex pointer manipulation and edge case handling
- **Pattern Recognition**: Identifying when to use specific data structures
- **Implementation Skills**: Building data structures from scratch without built-in libraries

## 📅 11 January 2026

### 🔄 Sorting Algorithms Mastery

Developed comprehensive **Sorting Algorithms** implementations in C# covering all major sorting techniques with real-world applications and performance analysis for different data scenarios.

#### 🔹 Elementary Sorting Algorithms

**🫧 BubbleSortMarks.cs** - Student Marks Sorting

- **Algorithm Type**: Comparison-based, stable sorting algorithm
- **Time Complexity**: O(n²) worst and average case, O(n) best case with optimization
- **Space Complexity**: O(1) - in-place sorting algorithm
- **Implementation**: Nested loops with adjacent element swapping
- **Use Case**: Student examination marks sorting for grade analysis
- **Optimization**: Early termination when no swaps occur in a pass

**🎯 SelectionSortScores.cs** - Game Score Ranking

- **Algorithm Type**: Comparison-based, unstable sorting algorithm
- **Time Complexity**: O(n²) in all cases - consistent performance
- **Space Complexity**: O(1) - minimal memory overhead
- **Implementation**: Find minimum element and place at correct position
- **Use Case**: Gaming leaderboard score sorting for rankings
- **Characteristic**: Minimizes number of swaps (exactly n-1 swaps)

**📝 InsertionSortEmployee.cs** - Employee ID Organization

- **Algorithm Type**: Comparison-based, stable, adaptive sorting
- **Time Complexity**: O(n²) worst case, O(n) best case for nearly sorted data
- **Space Complexity**: O(1) - efficient memory usage
- **Implementation**: Insert each element into its correct position in sorted portion
- **Use Case**: Employee database management with ID-based sorting
- **Advantage**: Excellent performance for small datasets and nearly sorted arrays

#### 🔹 Advanced Divide & Conquer Algorithms

**🔀 MergeSortBooks.cs** - Book Price Catalog Sorting

- **Algorithm Type**: Divide and conquer, stable sorting algorithm
- **Time Complexity**: O(n log n) in all cases - guaranteed performance
- **Space Complexity**: O(n) - requires additional memory for merging
- **Implementation**: Recursive division with merge operation for combining sorted subarrays
- **Use Case**: E-commerce book catalog sorting by price for customer browsing
- **Stability**: Maintains relative order of equal elements
- **Recursion Depth**: O(log n) stack space for recursive calls

**⚡ QuickSortProducts.cs** - Product Price Optimization

- **Algorithm Type**: Divide and conquer, unstable, in-place sorting
- **Time Complexity**: O(n log n) average, O(n²) worst case
- **Space Complexity**: O(log n) average for recursion stack
- **Implementation**: Partition-based approach with pivot element selection
- **Use Case**: Product inventory management with price-based sorting
- **Partitioning**: Lomuto partition scheme with last element as pivot
- **Performance**: Generally fastest practical sorting algorithm

#### 🔹 Heap-Based Sorting Algorithm

**🏔️ HeapSortSalary.cs** - Employee Salary Management

- **Algorithm Type**: Comparison-based, unstable, in-place sorting
- **Time Complexity**: O(n log n) in all cases - consistent performance
- **Space Complexity**: O(1) - true in-place sorting
- **Implementation**: Max-heap construction followed by repeated extraction
- **Use Case**: HR salary management and compensation analysis
- **Heap Operations**: Build max-heap, then repeatedly extract maximum
- **Heapify Process**: Maintains heap property during sorting process

#### 🔹 Non-Comparison Based Algorithm

**📊 CountingSortAges.cs** - Age Demographics Analysis

- **Algorithm Type**: Non-comparison, stable, integer sorting
- **Time Complexity**: O(n + k) where k is the range of input values
- **Space Complexity**: O(k) for counting array storage
- **Implementation**: Count occurrences, then reconstruct sorted array
- **Use Case**: Demographic analysis and age-based statistics
- **Range Dependency**: Efficient only when range (k) is not significantly larger than n
- **Stability**: Maintains relative order of equal elements

#### 🔹 Algorithm Comparison & Performance Analysis

| Algorithm          | Time Complexity | Space Complexity | Stability   | In-Place | Best Use Case                      |
| ------------------ | --------------- | ---------------- | ----------- | -------- | ---------------------------------- |
| **Bubble Sort**    | O(n²)           | O(1)             | ✅ Stable   | ✅ Yes   | Small datasets, educational        |
| **Selection Sort** | O(n²)           | O(1)             | ❌ Unstable | ✅ Yes   | Minimize swaps                     |
| **Insertion Sort** | O(n²)           | O(1)             | ✅ Stable   | ✅ Yes   | Nearly sorted data                 |
| **Merge Sort**     | O(n log n)      | O(n)             | ✅ Stable   | ❌ No    | Large datasets, stability required |
| **Quick Sort**     | O(n log n) avg  | O(log n)         | ❌ Unstable | ✅ Yes   | General purpose, fast average      |
| **Heap Sort**      | O(n log n)      | O(1)             | ❌ Unstable | ✅ Yes   | Guaranteed O(n log n)              |
| **Counting Sort**  | O(n + k)        | O(k)             | ✅ Stable   | ❌ No    | Integer data, small range          |

#### 🔹 Real-World Application Scenarios

**📚 Educational Systems**

- **Student Marks**: Bubble sort for small class sizes with grade analysis
- **Score Rankings**: Selection sort for gaming leaderboards and competitions
- **Employee Management**: Insertion sort for maintaining sorted employee records

**💼 Business Applications**

- **E-commerce Catalogs**: Merge sort for product listings requiring stability
- **Inventory Management**: Quick sort for fast product price sorting
- **HR Systems**: Heap sort for salary analysis and compensation planning

**📊 Data Analytics**

- **Demographics**: Counting sort for age-based statistical analysis
- **Performance Metrics**: Various algorithms based on data size and requirements
- **Real-time Systems**: Algorithm selection based on time/space constraints

#### 🔹 Algorithm Selection Criteria

**🔍 Data Size Considerations**

- **Small Data (n < 50)**: Insertion sort for simplicity and efficiency
- **Medium Data (50 < n < 1000)**: Quick sort for balanced performance
- **Large Data (n > 1000)**: Merge sort for guaranteed O(n log n) performance

**⚖️ Stability Requirements**

- **Stable Sorting Needed**: Merge sort, insertion sort, bubble sort, counting sort
- **Stability Not Required**: Quick sort, selection sort, heap sort for better performance

**💾 Memory Constraints**

- **Limited Memory**: In-place algorithms (quick sort, heap sort, insertion sort)
- **Memory Available**: Merge sort for optimal time complexity with extra space

**🎯 Performance Priorities**

- **Average Case Performance**: Quick sort for general-purpose sorting
- **Worst Case Guarantee**: Heap sort or merge sort for consistent performance
- **Best Case Optimization**: Insertion sort for nearly sorted data

#### 🔹 Learning Outcomes

- **Algorithm Mastery**: Comprehensive understanding of all major sorting techniques
- **Complexity Analysis**: Time and space complexity evaluation for algorithm selection
- **Performance Optimization**: Choosing appropriate algorithms based on data characteristics
- **Real-World Applications**: Implementing sorting solutions for business scenarios
- **Code Implementation**: Writing efficient, clean sorting algorithms from scratch
- **Comparative Analysis**: Understanding trade-offs between different sorting approaches
- **Problem-Solving Skills**: Selecting optimal sorting strategy based on constraints
- **Memory Management**: Understanding in-place vs. auxiliary space requirements
- **Stability Concepts**: Implementing stable vs. unstable sorting based on requirements
- **Algorithmic Thinking**: Developing intuition for divide-and-conquer and other paradigm

## 📅 12 January 2026

### 🪵 Custom Furniture Manufacturing System

Developed a **comprehensive furniture manufacturing optimization system** implementing dynamic programming concepts with linked list data structures for wood cutting and revenue maximization scenarios.

#### 🔹 System Architecture

**🏗️ WoodRod.cs** - Product Model Class

- **Encapsulation**: Private fields with getter/setter methods for length and price
- **Business Logic**: Revenue calculation based on length and price per unit
- **Data Representation**: Clean string representation for display purposes

**🔗 UniversalLinkedList.cs** - Generic Data Structure

- **Universal Design**: Generic linked list supporting any object type
- **Dual Functionality**: Both singly and doubly linked list operations
- **Flexible Operations**: Add/remove from both ends (stack and queue behavior)
- **Memory Management**: Proper node creation and pointer management

**🎯 IWoodService.cs** - Service Contract Interface

- **Interface Definition**: Contract for wood cutting optimization services
- **Method Signatures**: Revenue calculation and cutting suggestion methods
- **Abstraction**: Clean separation between interface and implementation

**⚙️ WoodServiceImpl.cs** - Core Business Logic

- **Dynamic Programming**: Recursive approach for optimal revenue calculation
- **Multiple Scenarios**: Maximum revenue, waste-constrained revenue, best cut suggestions
- **Price Chart Management**: Initialization and management of available wood pieces
- **Optimization Algorithms**: Revenue maximization with different constraints

#### 🔹 Business Scenarios Implemented

**💰 Maximum Revenue Calculation**

- **Scenario A**: Calculate maximum possible revenue from 12-foot wood rod
- **Algorithm**: Recursive dynamic programming for optimal cutting strategy
- **Optimization**: Find best combination of cuts to maximize total revenue
- **Real-World Application**: Furniture manufacturing profit optimization

**🗑️ Revenue with Waste Constraint**

- **Scenario B**: Revenue calculation considering acceptable waste limits
- **Waste Management**: Optimize cuts while keeping waste within acceptable range
- **Business Logic**: Balance between revenue maximization and material efficiency
- **Practical Application**: Real manufacturing constraints and material costs

**✂️ Best Cut Suggestion System**

- **Scenario C**: Intelligent cutting recommendations with waste analysis
- **Decision Support**: Provide optimal cutting strategy with waste information
- **Revenue Analysis**: Compare different cutting options for best outcomes
- **Manufacturing Guidance**: Practical recommendations for production planning

#### 🔹 User Interface Features

**📋 WoodMenu.cs** - Interactive Menu System

- **Menu-Driven Interface**: User-friendly console-based navigation
- **Multiple Options**: Access to all optimization scenarios
- **Input Handling**: Robust user input processing and validation
- **Real-Time Calculations**: Immediate results for different scenarios

**🚀 WoodMain.cs** - Application Entry Point

- **System Initialization**: Clean application startup and menu display
- **Service Integration**: Seamless integration of all system components

#### 🔹 Key Features

**🎯 Revenue Optimization**

- Dynamic programming approach for maximum revenue calculation
- Multiple cutting strategies with different constraint scenarios
- Real-time optimization suggestions for manufacturing decisions

**📊 Waste Management**

- Intelligent waste calculation and constraint handling
- Balance between profit maximization and material efficiency
- Practical manufacturing considerations for cost optimization

**🔄 Flexible Data Management**

- Universal linked list for efficient data storage and retrieval
- Generic design supporting various data types and operations
- Memory-efficient operations with proper pointer management

### 🏭 Metal Factory Pipe Cutting System

Developed an **industrial pipe cutting optimization system** using linked list data structures and dynamic programming for metal manufacturing revenue maximization.

#### 🔹 System Architecture

**🔧 PipeNode.cs** - Industrial Product Model

- **Encapsulation**: Private fields with controlled access methods
- **Product Properties**: Length and price attributes with validation
- **Linked Structure**: Next pointer for creating linked list chains
- **Industrial Data**: Representation of metal pipe specifications

**🎯 IPipeCutting.cs** - Manufacturing Interface

- **Service Contract**: Interface defining pipe cutting optimization methods
- **Method Definitions**: Optimized and non-optimized revenue calculation signatures
- **Abstraction Layer**: Clean separation between interface and business logic

**⚙️ PipeUtilityImpl.cs** - Core Manufacturing Logic

- **Price Chart Management**: Initialization of available pipe sizes and prices
- **Optimization Engine**: Dynamic programming for maximum revenue calculation
- **Comparison Analysis**: Optimized vs non-optimized cutting strategies
- **Industrial Algorithms**: Real-world manufacturing optimization techniques

#### 🔹 Manufacturing Scenarios

**🎯 Optimized Revenue Calculation**

- **Dynamic Programming**: Recursive approach for finding optimal cutting combinations
- **Revenue Maximization**: Calculate maximum possible revenue from 8-foot pipe
- **Cutting Strategy**: Intelligent analysis of all possible cutting combinations
- **Manufacturing Efficiency**: Optimal resource utilization for maximum profit

**📊 Non-Optimized Revenue Analysis**

- **Direct Matching**: Simple revenue calculation without optimization
- **Baseline Comparison**: Standard pricing without cutting optimization
- **Performance Benchmark**: Comparison baseline for optimization effectiveness
- **Traditional Approach**: Conventional manufacturing pricing model

#### 🔹 User Interface System

**📋 PipeMenu.cs** - Industrial Menu Interface

- **Manufacturing Dashboard**: Professional console-based interface
- **Operation Selection**: Choose between optimized and standard calculations
- **Real-Time Analysis**: Immediate revenue calculations and comparisons
- **Industrial UX**: User-friendly interface for manufacturing personnel

**🚀 PipeMain.cs** - System Entry Point

- **Application Launcher**: Clean system initialization and startup
- **Service Coordination**: Integration of all manufacturing components

#### 🔹 Industrial Features

**💰 Revenue Optimization**

- Advanced dynamic programming for cutting strategy optimization
- Comprehensive analysis of all possible cutting combinations
- Maximum profit calculation for industrial manufacturing scenarios

**📈 Performance Analysis**

- Direct comparison between optimized and non-optimized approaches
- Clear demonstration of optimization benefits and cost savings
- Real-world manufacturing efficiency improvements

**🔗 Efficient Data Management**

- Linked list implementation for pipe inventory management
- Memory-efficient storage and retrieval of product specifications
- Scalable data structure for industrial-scale operations

#### 🔹 Real-World Applications

**🏗️ Manufacturing Industries**

- **Furniture Production**: Wood cutting optimization for custom furniture manufacturing
- **Metal Processing**: Industrial pipe cutting for construction and infrastructure
- **Resource Management**: Material waste reduction and profit maximization

**💼 Business Operations**

- **Cost Optimization**: Minimize material waste while maximizing revenue
- **Production Planning**: Intelligent cutting strategies for manufacturing efficiency
- **Decision Support**: Data-driven recommendations for production managers

**📊 Industrial Analytics**

- **Performance Metrics**: Comparison between different cutting strategies
- **Efficiency Analysis**: Waste reduction and profit improvement calculations
- **ROI Assessment**: Return on investment analysis for optimization implementations

### � LoanBnuddy Financial Management System

Developed a **comprehensive loan management and approval system** implementing financial algorithms and business logic for loan processing, EMI calculations, and credit assessment.

#### 🔹 System Architecture

**👤 Applicant.cs** - Customer Data Model

- **Encapsulation**: Private credit score with controlled access methods
- **Data Management**: Comprehensive applicant information storage (name, income, loan amount)
- **Business Entity**: Clean representation of loan applicant with validation
- **Information Display**: Professional string representation for reporting

**🎯 IApprovable.cs** - Financial Service Interface

- **Service Contract**: Interface defining loan approval and EMI calculation methods
- **Method Signatures**: Standardized approach for loan processing operations
- **Abstraction Layer**: Clean separation between interface and business implementation

**⚙️ LoanUtilityImpl.cs** - Core Financial Logic

- **Loan Type Management**: Support for Personal, Home, and Auto loans with different rates
- **Credit Assessment**: Intelligent loan approval based on credit score and income criteria
- **EMI Calculation**: Advanced financial mathematics for monthly payment computation
- **Interest Rate Logic**: Dynamic rate adjustment based on loan type and risk factors

#### 🔹 Financial Features

**📊 Loan Approval System**

- **Credit Score Analysis**: Minimum 650 credit score requirement for approval
- **Income Verification**: Income must be at least 50% of requested loan amount
- **Risk Assessment**: Comprehensive evaluation of applicant's financial capacity
- **Automated Decision**: Instant approval or rejection based on predefined criteria

**💳 EMI Calculation Engine**

- **Mathematical Formula**: Compound interest calculation for accurate EMI computation
- **Loan Type Adjustments**: Rate modifications based on Home (-0.1%) or Auto (+0.1%) loans
- **Term Flexibility**: Support for various loan terms with monthly payment calculation
- **Precision Handling**: Accurate financial calculations with proper rounding

**🏦 Multi-Loan Support**

- **Personal Loans**: 11.0% base interest rate for general purpose loans
- **Home Loans**: 8.5% base rate with additional 0.1% discount for EMI calculation
- **Auto Loans**: 9.5% base rate with additional 0.1% premium for EMI calculation
- **Dynamic Pricing**: Intelligent rate assignment based on loan category

#### 🔹 User Interface System

**📋 Menu.cs** - Application Navigation

- **Simple Interface**: Clean menu-driven loan application process
- **User Guidance**: Clear options for loan application and system exit
- **Input Handling**: Robust user choice processing and validation

**🚀 LoanMain.cs** - Application Workflow

- **Complete Process**: End-to-end loan application and approval workflow
- **Data Collection**: Comprehensive applicant information gathering
- **Real-Time Processing**: Immediate loan decision and EMI calculation
- **Results Display**: Professional presentation of approval status and payment details

#### 🔹 Business Applications

**🏢 Financial Services**

- **Loan Processing**: Automated loan approval system for financial institutions
- **Risk Management**: Credit-based decision making for loan approvals
- **EMI Planning**: Accurate monthly payment calculations for borrowers

**📊 Credit Assessment**

- **Score-Based Approval**: Standardized credit evaluation process
- **Income Analysis**: Debt-to-income ratio assessment for loan feasibility
- **Automated Decisions**: Consistent and fair loan approval criteria

**💼 Banking Operations**

- **Multi-Product Support**: Different loan types with varying terms and rates
- **Customer Service**: Instant loan decisions and payment information
- **Financial Planning**: EMI calculations for customer budgeting assistance

#### 🔹 Learning Outcomes

- **Financial Mathematics**: EMI calculation algorithms and compound interest formulas
- **Business Logic Implementation**: Real-world loan approval criteria and risk assessment
- **Interface Design**: Clean separation between business logic and user interface
- **Data Encapsulation**: Proper handling of sensitive financial information
- **Decision Systems**: Automated approval processes based on multiple criteria
- **Financial Product Management**: Understanding different loan types and pricing strategies
- **User Experience Design**: Intuitive loan application workflow and information display
- **Error Handling**: Robust input validation and financial calculation accuracy
- **System Integration**: Coordinating multiple components for complete loan processing
- **Real-World Applications**: Practical financial system design and implementation

## 📅 13 January 2026

### 📚 BookBuddy Library Management System

Developed a **comprehensive library management system** using universal linked list data structures for book cataloging, searching, and alphabetical sorting with dynamic data management.

#### 🔹 System Architecture

**📖 Book.cs** - Literature Data Model

- **Encapsulation**: Private title and author fields with controlled access methods
- **Data Integrity**: Secure book information storage and retrieval
- **Clean Interface**: Getter methods for accessing book properties
- **Professional Display**: Formatted string representation for book listings

**🎯 IBookManager.cs** - Library Service Interface

- **Service Contract**: Interface defining core library management operations
- **Method Standards**: Standardized approach for book operations (add, sort, search, display)
- **Abstraction Layer**: Clean separation between interface and implementation logic

**🔗 UniversalLinkedList.cs** - Generic Data Structure

- **Universal Design**: Generic linked list supporting any object type with bidirectional navigation
- **Flexible Operations**: Add/remove from both ends supporting stack and queue behaviors
- **Memory Efficiency**: Dynamic node management with proper pointer handling
- **Dual Functionality**: Both singly and doubly linked list capabilities

**⚙️ BookUtilityImpl.cs** - Core Library Logic

- **Pre-loaded Catalog**: Initial book collection with classic literature titles
- **Dynamic Management**: Real-time book addition with validation and error handling
- **Search Functionality**: Case-insensitive author-based search with partial matching
- **Sorting Algorithm**: Bubble sort implementation for alphabetical book arrangement

#### 🔹 Library Features

**📚 Book Catalog Management**

- **Initial Collection**: Pre-loaded with "The Alchemist", "1984", "To Kill a Mockingbird"
- **Dynamic Addition**: Real-time book entry with title and author validation
- **Data Validation**: Input sanitization preventing empty or invalid book entries
- **Comprehensive Storage**: Unlimited book capacity with linked list scalability

**🔍 Advanced Search System**

- **Author-Based Search**: Intelligent author name matching with case-insensitive comparison
- **Partial Matching**: Flexible search supporting partial author name queries
- **Result Display**: Clean presentation of matching books with title and author
- **No Results Handling**: User-friendly messaging when no matches are found

**🔤 Alphabetical Sorting**

- **Title-Based Sorting**: Bubble sort algorithm for alphabetical arrangement by book title
- **Case-Insensitive Comparison**: Proper string comparison ignoring case differences
- **In-Memory Sorting**: Efficient array-based sorting with linked list reconstruction
- **User Feedback**: Confirmation messaging upon successful sorting completion

#### 🔹 User Interface System

**📋 BookMenu.cs** - Interactive Library Interface

- **Comprehensive Menu**: Five main options covering all library operations
- **Input Validation**: Robust error handling for invalid user inputs
- **Continuous Operation**: Loop-based menu system for multiple operations
- **Professional Navigation**: Clear option descriptions and user guidance

**🚀 BookMain.cs** - Application Entry Point

- **System Initialization**: Clean application startup with menu activation
- **Service Integration**: Seamless coordination of all library components

#### 🔹 Library Operations

**📖 Book Management**

- **View All Books**: Complete catalog display with formatted book information
- **Add New Books**: Interactive book entry with real-time validation
- **Search by Author**: Intelligent author-based book discovery
- **Alphabetical Sorting**: Organize library catalog in alphabetical order by title

**🔍 Search Capabilities**

- **Flexible Queries**: Support for partial and complete author name searches
- **Case Handling**: Automatic case conversion for consistent search results
- **Multiple Results**: Display all books matching search criteria
- **Search Feedback**: Clear messaging for successful and unsuccessful searches

### 🎬 MovieSchedular Cinema Management System

Developed a **comprehensive cinema scheduling system** using universal linked list data structures for movie management, show time scheduling, and search functionality with dynamic content management.

#### 🔹 System Architecture

**🎭 Movie.cs** - Cinema Content Model

- **Encapsulation**: Private movie title and show time fields with controlled access
- **Data Security**: Secure movie information storage and retrieval methods
- **Clean Interface**: Getter methods for accessing movie properties safely
- **Professional Display**: Formatted string representation for movie listings

**🎯 IMovieManager.cs** - Cinema Service Interface

- **Service Contract**: Interface defining core cinema management operations
- **Method Standards**: Standardized approach for movie operations (add, search, display)
- **Abstraction Layer**: Clean separation between business logic and implementation

**🔗 UniversalLinkedList.cs** - Generic Data Structure

- **Universal Design**: Generic linked list supporting any object type with full navigation
- **Flexible Operations**: Complete CRUD operations with stack and queue behaviors
- **Memory Management**: Efficient dynamic node allocation and deallocation
- **Bidirectional Support**: Both forward and backward traversal capabilities

**⚙️ CinemaUtilityImpl.cs** - Core Cinema Logic

- **Pre-loaded Schedule**: Initial movie lineup with popular titles and show times
- **Dynamic Scheduling**: Real-time movie addition with validation and error handling
- **Search Engine**: Case-insensitive title-based search with partial matching
- **Content Management**: Comprehensive movie catalog with time slot management

#### 🔹 Cinema Features

**🎬 Movie Schedule Management**

- **Initial Lineup**: Pre-loaded with "Inception" (18:30), "Interstellar" (21:15), "Avatar" (16:45)
- **Dynamic Addition**: Real-time movie scheduling with title and time validation
- **Input Validation**: Comprehensive sanitization preventing empty or invalid entries
- **Unlimited Capacity**: Scalable movie storage with linked list architecture

**🔍 Advanced Search System**

- **Title-Based Search**: Intelligent movie title matching with case-insensitive comparison
- **Partial Matching**: Flexible search supporting partial movie title queries
- **Result Display**: Clean presentation of matching movies with title and show time
- **Search Feedback**: User-friendly messaging for successful and unsuccessful searches

**⏰ Show Time Management**

- **Time Slot Tracking**: Comprehensive show time storage and display
- **Schedule Display**: Complete movie lineup with formatted time presentation
- **Time Validation**: Input validation for proper time format handling
- **Schedule Organization**: Systematic movie and time slot management

#### 🔹 User Interface System

**📋 MovieMenu.cs** - Interactive Cinema Interface

- **Streamlined Menu**: Four main options covering all cinema operations
- **Input Validation**: Robust error handling with safe parsing and validation
- **Continuous Operation**: Loop-based menu system for multiple cinema operations
- **Professional Navigation**: Clear option descriptions and user guidance

**🚀 MovieMain.cs** - Application Entry Point

- **System Initialization**: Clean application startup with menu activation
- **Service Coordination**: Seamless integration of all cinema management components

#### 🔹 Cinema Operations

**🎭 Movie Management**

- **View All Movies**: Complete schedule display with formatted movie and time information
- **Add New Movies**: Interactive movie scheduling with real-time validation
- **Search Movies**: Intelligent title-based movie discovery system
- **Schedule Organization**: Systematic management of movie lineup and show times

**🔍 Search and Discovery**

- **Flexible Queries**: Support for partial and complete movie title searches
- **Case Handling**: Automatic case conversion for consistent search results
- **Multiple Results**: Display all movies matching search criteria
- **User Experience**: Clear messaging and intuitive search functionality

#### 🔹 Real-World Applications

**🏢 Entertainment Industry**

- **Cinema Management**: Complete movie scheduling and catalog management systems
- **Library Systems**: Book cataloging and organization for educational institutions
- **Content Management**: Digital media organization and search functionality

**📊 Data Management**

- **Dynamic Collections**: Real-time data addition and organization capabilities
- **Search Systems**: Intelligent content discovery with flexible matching algorithms
- **Sorting Operations**: Alphabetical and chronological data organization

**💼 Business Operations**

- **Inventory Management**: Systematic catalog management for various industries
- **Customer Service**: User-friendly interfaces for content browsing and discovery
- **Information Systems**: Comprehensive data storage and retrieval solutions

#### 🔹 Learning Outcomes

- **Data Structure Mastery**: Advanced linked list implementation and manipulation
- **Generic Programming**: Universal data structures supporting multiple object types
- **Search Algorithms**: Intelligent search implementation with partial matching capabilities
- **Sorting Techniques**: Bubble sort algorithm implementation for data organization
- **Interface Design**: Clean separation between business logic and user interface
- **Memory Management**: Efficient dynamic memory allocation and pointer manipulation
- **User Experience Design**: Intuitive menu systems and user interaction patterns
- **Input Validation**: Robust error handling and data sanitization techniques
- **System Architecture**: Multi-component system design with proper abstraction layers
- **Real-World Applications**: Practical implementation of library and cinema management systems


### 🔍 Searching Algorithms 

Developed comprehensive **Searching Algorithms** implementations in C# covering linear search, binary search, and advanced search techniques with real-world problem-solving applications and algorithmic optimization.

#### 🔹 Linear Search Algorithms

**🔢 FirstNegative.cs** - First Negative Number Detection
- **Algorithm Type**: Sequential linear search with early termination optimization
- **Search Strategy**: Simple iteration with conditional checking and break statement
- **Use Case**: Data analysis for finding first occurrence of negative values in datasets
- **Performance**: Efficient stopping once target condition is met

**📝 SearchWordSentence.cs** - Text Search in Sentence Collections
- **Algorithm Type**: Linear search with string matching capabilities
- **Search Strategy**: Array traversal with built-in string Contains method
- **Use Case**: Text processing and content search in document collections
- **String Matching**: Case-sensitive word detection within sentence arrays

#### 🔹 Binary Search Algorithms

**🎯 FirstLastOccurence.cs** - Boundary Search in Sorted Arrays
- **Algorithm Type**: Modified binary search for finding element boundaries
- **Search Strategy**: Two separate binary searches with boundary adjustment techniques
- **Use Case**: Database range queries and duplicate element analysis
- **Optimization**: Efficient boundary detection in sorted datasets

**⛰️ PeakElement.cs** - Peak Detection Algorithm
- **Algorithm Type**: Binary search variant for finding local maximum elements
- **Search Strategy**: Comparison-based binary search with neighbor checking
- **Use Case**: Signal processing and data analysis for peak identification
- **Local Maximum**: Finding elements greater than their adjacent neighbors

**🔄 RotationPoint.cs** - Rotation Point Detection
- **Algorithm Type**: Binary search in rotated sorted arrays
- **Search Strategy**: Modified binary search comparing with array endpoints
- **Use Case**: Array manipulation and sorted data structure analysis
- **Rotation Analysis**: Finding pivot point in circularly shifted arrays

**🗂️ Search2DMatrix.cs** - 2D Matrix Search
- **Algorithm Type**: Binary search in 2D sorted matrix structures
- **Search Strategy**: Treating 2D matrix as flattened 1D array for binary search
- **Use Case**: Database table searches and spreadsheet data analysis
- **Matrix Indexing**: Efficient row-column conversion for 2D searching

#### 🔹 Challenge Problem Solutions

**🧩 LinearBinaryChallenge.cs** - Hybrid Search Approach
- **First Missing Positive Algorithm**: Linear search with boolean array marking technique
- **Binary Search Component**: Classic binary search implementation for sorted data
- **Hybrid Strategy**: Combines linear marking technique with binary search methods
- **Use Case**: Data validation and integrity checking in numerical datasets
- **Problem Solving**: Demonstrates both linear and binary search in single solution

#### 🔹 Search Strategy Applications

**📊 Data Analysis Applications**
- **Statistical Analysis**: Finding first negative values in financial datasets
- **Signal Processing**: Peak detection in audio and sensor data streams
- **Database Queries**: Range searches and boundary detection in large datasets

**💼 Business Applications**
- **Content Management**: Text search functionality in document collections
- **Inventory Systems**: Product lookup capabilities in sorted catalogs
- **Data Validation**: Missing value detection and integrity checking systems

**🔬 Scientific Computing**
- **Array Processing**: Rotation point detection in circular data structures
- **Matrix Operations**: Efficient searching algorithms in 2D scientific datasets
- **Algorithm Research**: Hybrid approaches combining multiple search techniques

#### 🔹 Performance Characteristics

**🚀 Linear Search Benefits**
- **Simplicity**: Easy to implement and understand for small datasets
- **Flexibility**: Works with unsorted data without preprocessing requirements
- **Early Termination**: Efficient stopping when target condition is met
- **Memory Efficiency**: Constant space complexity with minimal overhead

**⚡ Binary Search Advantages**
- **Logarithmic Performance**: Optimal time complexity for large sorted datasets
- **Scalability**: Excellent performance scaling with increasing data size
- **Predictable Performance**: Consistent search time regardless of target location
- **Space Efficiency**: In-place searching with constant space requirements

**🎯 Specialized Search Techniques**
- **Boundary Detection**: Advanced techniques for finding element ranges and occurrences
- **Peak Finding**: Specialized algorithms for local maximum identification
- **Matrix Searching**: Coordinate conversion techniques for 2D data structures
- **Hybrid Approaches**: Combining multiple algorithmic techniques for complex problems

#### 🔹 Algorithm Selection Criteria

**📈 Data Characteristics**
- **Unsorted Data**: Linear search for guaranteed results without preprocessing
- **Sorted Data**: Binary search for optimal logarithmic performance
- **Small Datasets**: Linear search acceptable due to low computational overhead
- **Large Datasets**: Binary search essential for maintaining performance standards

**🎯 Problem Requirements**
- **First Occurrence**: Modified binary search with left boundary adjustment
- **Range Queries**: First/last occurrence search for comprehensive boundary detection
- **Peak Detection**: Specialized binary search for local maximum finding
- **2D Searching**: Matrix-specific binary search with coordinate conversion

#### 🔹 Learning Outcomes
- **Search Algorithm Mastery**: Comprehensive understanding of linear and binary search techniques
- **Performance Analysis**: Algorithm selection based on data characteristics and requirements
- **Problem-Solving Skills**: Adapting basic search algorithms for specialized requirements
- **Optimization Techniques**: Choosing appropriate search strategy based on performance needs
- **Real-World Applications**: Implementing search solutions for practical business scenarios
- **Algorithm Adaptation**: Modifying standard algorithms for specific problem requirements
- **Efficiency Considerations**: Understanding trade-offs between time and space complexity
- **Data Structure Knowledge**: Working effectively with arrays, matrices, and sorted structures
- **Boundary Detection**: Advanced techniques for finding element ranges and occurrences
- **Hybrid Approaches**: Combining multiple algorithmic techniques for complex problem solving

## 📅 14 January 2026

### ⏱️ Runtime Analysis & Performance Comparison

Developed comprehensive **Runtime Analysis** implementations in C# for comparing algorithm performance across different approaches, measuring execution times, and analyzing computational efficiency in real-world scenarios.

#### 🔹 Fibonacci Algorithm Performance Analysis

**🔢 FibonacciComparison.cs** - Recursive vs Iterative Performance Study
- **Recursive Approach**: Traditional mathematical definition with exponential time complexity
- **Iterative Approach**: Linear time solution with bottom-up dynamic programming
- **Performance Measurement**: Stopwatch-based timing analysis for accurate comparison
- **Test Case**: Fibonacci calculation for n=30 to demonstrate performance differences
- **Analysis Results**: Dramatic performance gap showcasing algorithmic efficiency impact

#### 🔹 Search Algorithm Performance Comparison

**🔍 SearchComparison.cs** - Linear vs Binary Search Efficiency Analysis
- **Linear Search Implementation**: Sequential traversal through unsorted data structures
- **Binary Search Implementation**: Logarithmic search in sorted array structures
- **Large Dataset Testing**: Performance analysis on 1,000,000 element arrays
- **Worst-Case Scenario**: Target element positioned at array end for maximum comparison
- **Performance Metrics**: Millisecond-precision timing for accurate performance measurement

#### 🔹 Sorting Algorithm Performance Benchmarking

**📊 SortingComparison.cs** - Multi-Algorithm Sorting Performance Study
- **Bubble Sort Analysis**: Quadratic time complexity demonstration with nested loops
- **Merge Sort Analysis**: Divide-and-conquer approach with guaranteed O(n log n) performance
- **Quick Sort Analysis**: Average-case optimal performance with partition-based sorting
- **Dataset Generation**: Random number arrays for realistic performance testing
- **Array Cloning**: Identical test data across all algorithms for fair comparison

#### 🔹 Performance Measurement Techniques

**⏱️ Stopwatch Integration**
- **High-Precision Timing**: Millisecond-accurate performance measurement capabilities
- **Start-Stop Methodology**: Clean timing boundaries for accurate algorithm assessment
- **Restart Functionality**: Multiple algorithm testing with consistent timing approach
- **Real-Time Analysis**: Immediate performance feedback for algorithm comparison

**📈 Comparative Analysis Methods**
- **Side-by-Side Testing**: Multiple algorithms tested on identical datasets
- **Scalability Assessment**: Performance behavior analysis across different input sizes
- **Worst-Case Evaluation**: Testing algorithms under maximum computational stress
- **Memory Efficiency**: Space complexity considerations alongside time analysis

#### 🔹 Algorithm Efficiency Insights

**🚀 Performance Characteristics**
- **Exponential vs Linear**: Fibonacci recursive vs iterative performance gap demonstration
- **Linear vs Logarithmic**: Search algorithm efficiency comparison in large datasets
- **Quadratic vs Linearithmic**: Sorting algorithm performance scaling analysis
- **Real-World Impact**: Practical implications of algorithm choice on application performance

**📊 Scalability Patterns**
- **Small Input Performance**: Algorithm overhead impact on small dataset processing
- **Large Input Behavior**: Performance degradation patterns with increasing data size
- **Memory Usage Patterns**: Space-time tradeoffs in different algorithmic approaches
- **Practical Thresholds**: Optimal algorithm selection based on input size characteristics

#### 🔹 Real-World Performance Applications

**💼 Business Decision Making**
- **Algorithm Selection**: Data-driven choices for production system implementations
- **Performance Optimization**: Identifying bottlenecks through systematic measurement
- **Scalability Planning**: Predicting system behavior under increased load conditions
- **Resource Allocation**: Understanding computational requirements for different approaches

**🔬 Scientific Computing**
- **Benchmark Studies**: Establishing performance baselines for algorithm comparison
- **Optimization Research**: Identifying areas for algorithmic improvement
- **Performance Modeling**: Predicting algorithm behavior in various scenarios
- **Efficiency Analysis**: Understanding computational complexity in practical terms

**📱 Application Development**
- **Mobile Performance**: Algorithm selection for resource-constrained environments
- **Web Application Optimization**: Backend algorithm choices for responsive user experience
- **Database Query Optimization**: Search and sort algorithm selection for data processing
- **Real-Time Systems**: Performance-critical algorithm implementation decisions

#### 🔹 Performance Testing Methodology

**🎯 Testing Strategies**
- **Controlled Environment**: Consistent testing conditions for reliable measurements
- **Multiple Iterations**: Statistical significance through repeated performance tests
- **Varied Input Sizes**: Comprehensive analysis across different data scales
- **Edge Case Testing**: Performance behavior under extreme conditions

**📋 Measurement Standards**
- **Timing Precision**: High-resolution performance measurement techniques
- **Memory Profiling**: Space complexity analysis alongside time measurements
- **Comparative Baselines**: Standardized comparison metrics across algorithms
- **Performance Documentation**: Systematic recording of analysis results

#### 🔹 Learning Outcomes
- **Performance Analysis Mastery**: Understanding how to measure and compare algorithm efficiency
- **Algorithmic Complexity**: Practical experience with time and space complexity implications
- **Optimization Techniques**: Identifying performance bottlenecks and improvement opportunities
- **Real-World Applications**: Applying performance analysis to practical development scenarios
- **Decision-Making Skills**: Data-driven algorithm selection based on performance characteristics
- **Benchmarking Expertise**: Systematic approach to algorithm performance evaluation
- **Scalability Understanding**: Predicting algorithm behavior under different load conditions
- **Efficiency Awareness**: Recognition of performance trade-offs in algorithm design
- **Testing Methodology**: Structured approach to performance measurement and analysis
- **Production Readiness**: Preparing algorithms for real-world deployment considerations

### 📒 Address Book System — Version 6

Refactored the Address Book console system to support multiple Address Books in one application. Each Address Book has a unique name and stores contacts using arrays only (no collections).

🔹 System Architecture
👤 Contact.cs — Contact Model Class

Encapsulation: Private fields with separate getter/setter methods
Attributes: FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email
String Representation: ToString() returns formatted contact details
🎯 IAddressBook.cs — Service Contract Interface

Interface Definition: Defines operations like Add, Display, Edit, Delete, Add Multiple
Abstraction: Clean separation between menu and utility logic
⚙️ AddressBookUtilityImpl.cs — Core Business Logic

Multiple Address Book Storage:
addressBookNames[] for book names
addressBooks[][] for contacts per book
contactCount[] for tracking contacts in each book
Unique Name Validation: Checks name before creating a new Address Book
Predefined Contacts: Loads India-based contacts into the Default book at startup
No Constructors Used in utility (as required)
📋 Menu.cs — Interactive Menu System

Menu-Only Responsibility: Shows menu and calls utility methods
Loop System: Runs until Exit is selected
Switch Case Navigation: Structured console menu
🚀 MainClass.cs — Application Entry Point

Single Responsibility: Only calls Menu.Start()
🔹 Key Features (Version 6)
✅ Supports multiple Address Books in one system
✅ Each Address Book has a unique name
✅ Can create a new Address Book and add multiple contacts using existing CreateContact()
✅ Uses arrays only, no collections
✅ Menu runs continuously until Exit

### 📒 Address Book System — Version 7

Enhanced the system to ensure no duplicate entry of the same person inside a particular Address Book.

🔹 What’s New in Version 7 (Compared to Version 6)
✅ Duplicate Prevention Inside an Address Book

Private Validation Method: Checks if a person already exists in the active book
Match Rule: Duplicate means same FirstName + LastName
Behavior:
If duplicate found: prints
"This contact is already in the Address Book"
Then stops contact creation and returns to menu
✅ Works per Address Book (Not Global)

Same person name can exist in a different Address Book, but not twice in the same one.
🔹 Key Features (Version 7)
✅ All Version 6 features
✅ Prevents duplicates inside the active Address Book
✅ Duplicate check happens immediately after entering full name
✅ Returns back to menu after showing duplicate message

### 📒 Address Book System — Version 8

Extended the Address Book console application to support searching contacts across multiple Address Books by City and State. Also enhanced startup data by creating multiple predefined Address Books with predefined contacts (India-based), using arrays only (no collections).

🔹 System Architecture

👤 Contact.cs — Contact Model Class
Encapsulation: All fields are private with separate getter/setter methods
Contact Attributes:
First Name, Last Name
Address, City, State, Zip
Phone Number, Email
Display Support: ToString() returns a formatted contact profile for printing
🎯 IAddressBook.cs — Service Contract Interface
Interface Definition: Defines the contract for Address Book operations
New Methods Added in Version 8:
SearchPersonByCity()
SearchPersonByState()
Abstraction Layer: Menu only calls interface/utility methods; business logic stays in utility
⚙️ AddressBookUtilityImpl.cs — Core Business Logic
Multi-Book Storage (Arrays Only):
addressBookNames[] → stores unique Address Book names
addressBooks[][] → stores contacts separately for each Address Book
contactCount[] → tracks number of contacts in each Address Book
addressBookCount → tracks number of Address Books created
Multiple Predefined Address Books:
Creates multiple books at system startup (example: Default, Family, Office)
Inserts predefined India-based contacts in each book
Cross Address Book Search:
SearchPersonByCity() searches through all address books and prints matching contacts
SearchPersonByState() searches through all address books and prints matching contacts
Implementation Detail: Search is performed using nested loops:
outer loop → address books
inner loop → contacts inside that book
📋 Menu.cs — Interactive Menu System
Menu-Driven Console UI: Provides options to interact with Address Book features
New Options Added in Version 8:
Search Person By City
Search Person By State
Continuous Execution: Runs repeatedly until user selects Exit
No Business Logic in Menu: Menu only displays options and calls utility methods
🚀 MainClass.cs — Application Entry Point
Single Responsibility: Initializes the program and calls Menu
Startup Initialization: Ensures predefined address books and contacts are loaded before operations
🔹 Business Scenarios Implemented (Version 8)

🏙️ Search Person By City (Across Multiple Address Books)
User inputs a city name
System searches every Address Book in the system
Prints:
the Address Book name where the contact exists
the full contact details using ToString()
🗺️ Search Person By State (Across Multiple Address Books)
User inputs a state name
System searches every Address Book in the system
Displays all contacts that match the state across all books
🔹 Key Features (Version 8)

🏷️ Multiple Predefined Address Books
System now starts with multiple predefined address books (India-based)
Each book contains its own predefined contacts
🔍 Cross-Book Search Engine
Search by City across all Address Books
Search by State across all Address Books
Displays which Address Book contains each matching contact
📦 Array-Based Data Handling
No collections used (List, Dictionary, etc.)
Uses arrays for:
Address Book names
Contact storage per Address Book
Contact count tracking

### 📒 Address Book System — Version 10

Enhanced the multi–Address Book console system by adding the ability to count the number of contact persons by City or State across all Address Books. This version continues to use arrays only (no collections) and keeps the menu logic separated from core business logic.

🔹 System Architecture

👤 Contact.cs — Contact Model Class
Encapsulation: Private fields with separate getter/setter methods
Attributes Managed: FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email
Data Representation: ToString() provides formatted contact details for display/search output
🎯 IAddressBook.cs — Service Contract Interface
Purpose: Defines a standard contract for Address Book operations
Version 10 Additions:
CountContactsByCity()
CountContactsByState()
Design Benefit: Ensures counting functionality is part of the formal system capabilities
⚙️ AddressBookUtilityImpl.cs — Core Business Logic
Multi-Address Book Storage (Arrays Only):
addressBookNames[] → stores unique Address Book names
addressBooks[][] → stores contacts for each Address Book separately
contactCount[] → tracks the number of contacts in each Address Book
addressBookCount → tracks how many Address Books exist in the system
Counting Engine (Version 10):
CountContactsByCity():
Takes city input from user
Uses nested loops to scan all Address Books and count contacts matching that city
Prints total count for the entered city
CountContactsByState():
Takes state input from user
Uses nested loops to scan all Address Books and count contacts matching that state
Prints total count for the entered state
Implementation Style:
Uses simple loops and integer counters
No collections (List, Dictionary, etc.)
No constructor used for initialization
📋 Menu.cs — Interactive Menu System
Menu-Driven Console UI: Provides navigation to all features
Version 10 Options Added:
Count Contacts By City
Count Contacts By State
Control Flow: Uses while loop (continuous menu) + switch case selection
Separation of Concerns: Menu only triggers utility methods; all counting logic stays in utility
🚀 MainClass.cs — Application Entry Point
Responsibility: Starts the application by calling Menu
Startup Integration: Ensures system runs through a clean initialization and menu workflow
🔹 Business Scenarios Implemented (Version 10)

🏙️ Count Contacts By City
User enters a city name
System counts contacts across all address books
Output:
Total contacts in city 'CITY_NAME': X
🗺️ Count Contacts By State
User enters a state name
System counts contacts across all address books
Output:
Total contacts in state 'STATE_NAME': X
🔹 Key Features (Version 10)

🔢 Contact Counting Analytics
City-wise contact count across multiple Address Books
State-wise contact count across multiple Address Books
Useful for analyzing distribution of contacts geographically
🧠 Efficient Array-Based Processing
Nested loop scanning:
Address Books loop
Contacts loop
Integer counter accumulation for total matches
No additional data structures or collections used
🧩 Scalable Multi-Book Support
Counting works even when new Address Books and contacts are added
Maintains compatibility with previous versions’ features like Add/Edit/Delete/Search

### 📒 Address Book System — Version 11

Implemented the ability to sort contact entries alphabetically by Person’s name within a selected Address Book. This version continues the multi–Address Book architecture using arrays only (no collections) and keeps all sorting logic inside the utility layer.

🔹 System Architecture

👤 Contact.cs — Contact Model Class
Encapsulation: Private fields with separate getter/setter methods
Attributes: FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email
Display Support: ToString() provides formatted output for display/search features
Sorting Fields Used: FirstName and LastName are used as sorting keys
🎯 IAddressBook.cs — Service Contract Interface
Contract-Based Design: Interface defines all supported Address Book operations
Version 11 Addition:
SortContactsByName()
Benefit: Sorting behavior is exposed through interface while implemented in utility class
⚙️ AddressBookUtilityImpl.cs — Core Business Logic
Multi Address Book Storage (Arrays Only):
addressBookNames[] → stores names of Address Books
addressBooks[][] → stores contacts per Address Book
contactCount[] → maintains contact count for each Address Book
Sorting Engine (Version 11):
SortContactsByName():
asks user for the Address Book name
finds the correct Address Book using name lookup
sorts contacts from index 0 to contactCount[bookIndex] - 1
CompareContactsByName(Contact a, Contact b) (private helper):
compares FirstName first
if FirstName is same, compares LastName
Algorithm Used: Bubble Sort (array-based swapping, no collection sorting)
📋 Menu.cs — Interactive Menu System
Menu-Based Navigation: Added a new option to sort contacts
Version 11 Menu Option:
Sort Contacts By Name
Separation of Concerns: Menu only calls utility.SortContactsByName() and contains no sorting logic
🚀 MainClass.cs — Application Entry Point
Single Responsibility: Starts the system by calling the menu
🔹 Business Scenario Implemented (Version 11)

🔤 Sort Entries Alphabetically by Person’s Name
User enters the Address Book name to sort
System sorts all contacts inside that Address Book in alphabetical order:
First Name (A → Z)
If first name matches, Last Name (A → Z)
Result: Display and other operations now work on sorted data order
🔹 Key Features (Version 11)

✅ Name-Based Sorting
Alphabetical sorting by FirstName and LastName
Sorting is performed on a particular Address Book selected by name
📦 Array-Only Implementation
No use of List, Dictionary, or any collection frameworks
Sorting done with manual swapping inside arrays
🧠 Clean Utility-Layer Logic
Sorting logic contained entirely in AddressBookUtilityImpl
Menu remains only responsible for UI options and method calls