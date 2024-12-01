using Assignment_1;
using System.ComponentModel;

//Question  1:
/*Sum sum1 = new Sum();
Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int sum = sum1.getSum(a, b);
Console.WriteLine($"The sum is :{sum}");  
Console.ReadLine();*/

//Question 2:
/*SI simpleIntrest = new SI();
Console.Write("Enter the principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the rate of interest (in %): ");
double rate = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the time (in years): ");
double time = Convert.ToDouble(Console.ReadLine());
double si  = simpleIntrest.getSimpleIntrest(principal , rate , time);
Console.WriteLine("The simple intrest is :{0}", si);
Console.ReadLine();*/


//Question 3:
/*Console.Write("Enter the coefficient a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the coefficient b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the coefficient c: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Invalid input: 'a' cannot be 0 for a quadratic equation.");
    return;
}
QuadraticEquation equation = new QuadraticEquation(a, b, c);
equation.CalculateRoots();*/

//Question 4:
/*const int PassingMarks = 35;
const int FullMarks = 100;
int totalSubjects = 5;

int[] marks = new int[totalSubjects];
Console.WriteLine("Enter the marks for five subjects (out of 100):");

for (int i = 0; i < totalSubjects; i++)
{
    Console.Write($"Subject {i + 1}: ");
    marks[i] = Convert.ToInt32(Console.ReadLine());

    if (marks[i] < 0 || marks[i] > FullMarks)
    {
        Console.WriteLine("Invalid marks! Marks should be between 0 and 100.");
        return;
    }
}

foreach (int mark in marks)
{
    if (mark < PassingMarks)
    {
        Console.WriteLine("Result: Fail (One or more subjects below passing marks)");
        return;
    }
}
int totalMarks = 0;
foreach (int mark in marks)
{
    totalMarks += mark;
}

double percentage = (totalMarks / (double)(FullMarks * totalSubjects)) * 100;
string division;
if (percentage >= 60)
{
    division = "First Division";
}
else if (percentage >= 45)
{
    division = "Second Division";
}
else if (percentage >= 35)
{
    division = "Third Division";
}
else
{
    division = "Fail";
}
Console.WriteLine($"Result: Pass");
Console.WriteLine($"Total Marks: {totalMarks}/{FullMarks * totalSubjects}");
Console.WriteLine($"Percentage: {percentage:F2}%");
Console.WriteLine($"Division: {division}");*/


//Question 5:
/*Calculator calculator = new Calculator();
Console.WriteLine("Enter the first integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second integer: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the symbol ");
string? op = Console.ReadLine();
int result = calculator.calculate(a, b, op);
Console.WriteLine("The result is :{0}", result);
*/

//Question:6
/*string[] arr = { "Saugat", "Satish", "Madu", "Yubraj" };
Console.Write($"The names that contain the letter 't' are : ");
foreach (string str in arr)
{
    if (str.Contains('t'))
    {
        Console.Write($"{str}, ");
    }
}*/

//Question:7
/*int n = 5;
string[] arr = new string[n];
Console.WriteLine("Enter n number of strings:");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Console.ReadLine();
}
Array.Sort(arr);
Console.WriteLine("The Sorted array in alphabetical order is: ");
foreach (string s in arr)
{
    Console.WriteLine(s);
}*/

//Question:8
/*Console.Write("Enter the size of the array: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int minValue = array[0];
int maxValue = array[0];

for (int i = 1; i < n; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
}
Console.WriteLine($"The minimum value in the array is: {minValue}");
Console.WriteLine($"The maximum value in the array is: {maxValue}");*/

//Question: 9 
/*int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


Console.WriteLine("Original 2D Array:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nUpper Triangle of the 2D Array:");
for (int i = 0; i < 3; i++)
{
    for (int j = i; j < 3; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}*/