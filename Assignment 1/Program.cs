using Assignment_1;
using System;
using System.ComponentModel;
//using System.Drawing;

//Question  1:
/*Sum sum1 = new Sum();
Console.WriteLine("Enter 2 numbers");
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
double si = simpleIntrest.getSimpleIntrest(principal, rate, time);
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
Console.WriteLine("The result is :{0}", result);*/


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
}
*/

//Question : 10 
/*
Rectangle rect1 = new Rectangle { Length = 5, Breadth = 10 };
Rectangle rect2 = new Rectangle { Length = 7, Breadth = 8 };

rect1.ComputeArea();
rect2.ComputeArea();

Console.WriteLine("Rectangle 1:");
rect1.DisplayArea();

Console.WriteLine("Rectangle 2:");
rect2.DisplayArea();

Console.WriteLine("Larger Area: " + (rect1.Area > rect2.Area ? rect1.Area : rect2.Area));*/

/*-----------------------------------------------Assignment_2----------------------------------------------------------*/

/*Question1*/

/*delegate int FactorialDelegate(int n);
class Program
{ 
    static void Main()
    {
        FactorialDelegate fact = n =>
        {
            int result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        };
        Console.WriteLine("Factorial: " + fact(6));
    }
}
*/
//Question 2:
/*delegate void ProgressEventHandler(int progress);
class ProgressNotifier
{
    public event ProgressEventHandler? ProgressChanged;
    public void Iterate()
    {
        for (int i = 1; i <= 10000; i++)
        {
            if (i % 5 == 0)
            {
                ProgressChanged?.Invoke((i * 100) / 10000);
            }
        }
    }
}
class Program
{
    static void Main()
    {
        ProgressNotifier notifier = new ProgressNotifier();
        notifier.ProgressChanged += progress => Console.WriteLine($"Progress: {progress}%");
        notifier.Iterate();
    }
}*/

//Question 3:
/*class Quad
{
    public double a, b, c, r1, r2;

    public void GetInput()
    {
        Console.Write("Enter a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        c = double.Parse(Console.ReadLine());
    }

    public double[] CalcRoots()
    {
        double disc = b * b - 4 * a * c;
        if (disc >= 0)
        {
            r1 = (-b + Math.Sqrt(disc)) / (2 * a);
            r2 = (-b - Math.Sqrt(disc)) / (2 * a);
        }
        else
        {
            r1 = r2 = double.NaN;
        }
        return new double[] { r1, r2 };
    }
}

class Program
{
    static void Main()
    {
        Quad q = new Quad();
        q.GetInput();
        double[] roots = q.CalcRoots();
        if (double.IsNaN(roots[0]) || double.IsNaN(roots[1]))
            Console.WriteLine("Complex roots");
        else
            Console.WriteLine($"Roots: r1 = {roots[0]}, r2 = {roots[1]}");
    }
}*/

//Question 4:
/*class Student
{
    public int age;
    public string name;

    public void Input()
    {
        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Enter name: ");
        name = Console.ReadLine();
    }
}

class Imain
{
    static void Main()
    {
        Student[] lstStudent = new Student[5];

        for (int i = 0; i < 5; i++)
        {
            lstStudent[i] = new Student();
            lstStudent[i].Input();
        }

        Console.WriteLine("Students with age >= 24:");
        for (int i = 0; i < 5; i++)
        {
            if (lstStudent[i].age >= 24)
                Console.WriteLine($"Name: {lstStudent[i].name}, Age: {lstStudent[i].age}");
        }
    }
}
*/
//Question 5:
/*class Time
{
    public int hr, min, sec;

    public Time Sum(Time t1, Time t2)
    {
        Time result = new Time();
        result.sec = t1.sec + t2.sec;
        result.min = t1.min + t2.min + result.sec / 60;
        result.sec %= 60;
        result.hr = t1.hr + t2.hr + result.min / 60;
        result.min %= 60;
        return result;
    }
}

class TimeDemo
{
    static void Main()
    {
        Time t1 = new Time { hr = 5, min = 40, sec = 40 };
        Time t2 = new Time { hr = 4, min = 40, sec = 50 };

        Time t3 = new Time();
        t3 = t3.Sum(t1, t2);

        Console.WriteLine($"t1 --> {t1.hr}:{t1.min}:{t1.sec}");
        Console.WriteLine($"t2 --> {t2.hr}:{t2.min}:{t2.sec}");
        Console.WriteLine($"Total Sum t3 --> {t3.hr}:{t3.min}:{t3.sec}");
    }
}
*/

//Question 6
/*using System.IO;

class FileCopy
{
    static void Main()
    {
        string inputPath = "input.txt";
        string outputPath = "output.txt";

        try
        {
            string content = File.ReadAllText(inputPath);

            File.WriteAllText(outputPath, content);

            Console.WriteLine("File content copied successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}*/

//Question 7:
/*class FileRead
{
    static void Main()
    {
        string inputPath = "input.txt";

        try
        {
            string[] lines = File.ReadAllLines(inputPath);
            Console.WriteLine("Words ending with 'g':");
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (word.EndsWith("g", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}*/

//Question 8:
/*public interface ICalc
{
    int Add(int x, int y);
    int Diff(int x, int y);
}

public class Calc : ICalc
{
    public int Add(int x, int y) => x + y;
    public int Diff(int x, int y) => x - y;
}

public class Program
{
    public static void Main()
    {
        ICalc calc = new Calc();
        Console.WriteLine(calc.Add(5, 3));
        Console.WriteLine(calc.Diff(5, 3));
    }
}
*/
//Question 9:
/*public interface Shape
{
    void Get();
    void Display();
}

public class Rectangle : Shape
{
    int l, b;

    public void Get()
    {
        Console.Write("Enter length: ");
        l = int.Parse(Console.ReadLine());
        Console.Write("Enter breadth: ");
        b = int.Parse(Console.ReadLine());  
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle Area: {l * b}");
    }
}

public class Square : Shape
{
    int s;

    public void Get()
    {
        Console.Write("Enter side: ");
        s = int.Parse(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine($"Square Area: {s * s}");
    }
}

public class Program
{
    public static void Main()
    {
        Shape rect = new Rectangle();
        Shape sqr = new Square();

        Console.WriteLine("Rectangle:");
        rect.Get();
        rect.Display();

        Console.WriteLine("Square:");
        sqr.Get();
        sqr.Display();
    }
}
*/

/*public abstract class Vehicle
{
    public abstract void StartEngine();
    public void StopEngine() => Console.WriteLine("Engine stopped.");
}

public class Airplane : Vehicle
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int MaxCapacity { get; set; }

    public Airplane(string model, string manufacturer, int maxCapacity)
    {
        Model = model;
        Manufacturer = manufacturer;
        MaxCapacity = maxCapacity;
    }

    public override void StartEngine() => Console.WriteLine("Airplane engine started. Performing pre-flight checks...");

    public void TakeOff() => Console.WriteLine("Airplane is taking off.");
    public void Land() => Console.WriteLine("Airplane is landing.");
}

public class Program
{
    public static void Main()
    {
        Airplane airplane = new Airplane("Boeing 747", "Boeing", 416);

        Console.WriteLine($"Model: {airplane.Model}");
        Console.WriteLine($"Manufacturer: {airplane.Manufacturer}");
        Console.WriteLine($"Max Capacity: {airplane.MaxCapacity}");

        airplane.StartEngine();
        airplane.TakeOff();
        airplane.Land();
        airplane.StopEngine();
    }
}*/
//Question 11
/*using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }
}

public class Imain
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Alice", Address = "New York", Salary = 50000 },
            new Employee { ID = 2, Name = "Bob", Address = "Chicago", Salary = 30000 },
            new Employee { ID = 3, Name = "Charlie", Address = "Los Angeles", Salary = 45000 },
            new Employee { ID = 4, Name = "Diana", Address = "Miami", Salary = 20000 }
        };

        var highEarners = employees.Where(e => e.Salary > 40000);

        foreach (var emp in highEarners)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Address: {emp.Address}, Salary: {emp.Salary}");
        }
    }
}*/
/*Qno12*/
/*using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sumOfOdds = arr.Where(x => x % 2 != 0).Sum();

        Console.WriteLine($"Sum of odd numbers: {sumOfOdds}");
    }
}
*/