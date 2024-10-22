using System.Collections.Generic;

// Zadanie 1
Console.WriteLine("Zadanie 1");
int task1 = 10;
do
{
    Console.WriteLine(task1);
    task1--;
}
while (task1>=0);

// Zadanie 2
Console.WriteLine("\nZadanie 2");
string task2 = "";
do
{
    Console.Write("Podaj hasło: ");
    task2 = Console.ReadLine();
    Console.Write("\n");
}
while (task2 != "koniec");

// Zadanie 3
Console.WriteLine("\nZadanie 3");
int task3 = 1;
while (task3 <= 100)
{
    if(task3 % 2 == 0)
    {
        Console.WriteLine(task3);
    }
    task3++;
}

// Zadanie 4
Console.WriteLine("\nZadanie 4");
for(int i = 1; i <= 15; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}

// Zadanie 5
Console.WriteLine("\nZadanie 5");
List<int> numbers = new() { 4, 25, 35, 42, 55, 78, 99, 101 };

foreach(int value in numbers)
{
    if(value % 7 == 0)
    {
        Console.WriteLine(value);
    }
}

// Zadanie 6
Console.WriteLine("\nZadanie 6");
foreach (int value in numbers)
{
    if (value % 7 == 0)
    {
        Console.WriteLine(value);
        break;
    }
}

// Zadanie 7
Console.WriteLine("\nZadanie 7");
double[] task7 = new double[20];

for(int i = 0; i < 20; i++)
{
    task7[i] = i; 
}

// Zadanie 8
Console.WriteLine("\nZadanie 8");
int[,] task8 = {{ 1, 2, 3, 4 },
                { 1, 2, 3, 4 },
                { 1, 2, 3, 4 }};

int[,] task8result = new int[4, 3];

for (int i = 0; i < task8.GetLength(0); i++)
{
    for (int j = 0; j < task8.GetLength(1); j++)
    {
        Console.Write($"{task8[i, j]}   ");

        task8result[j,i] = task8[i, j];
    }
    Console.Write("\n");
}

Console.WriteLine("Rozwiązanie: ");
for (int i = 0; i < task8result.GetLength(0); i++)
{
    for (int j = 0; j < task8result.GetLength(1); j++)
    {
        Console.Write($"{task8result[i, j]}   ");
    }
    Console.Write("\n");
}

// Zadanie 10
Console.WriteLine("\nZadanie 10");
static void upper(string value)
{
    Console.WriteLine($"Rozwiązanie: {value.ToUpper()}");
}

Console.WriteLine("Podaj wyraz: ");
string task10 = Console.ReadLine();
upper(task10);

// Zadanie 11
Console.WriteLine("\nZadanie 11");
static void task11Fun(int x, int y)
{
    char[,] chars = new char[x, y];
 
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            chars[i, j] = '$';
        }
    }

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Console.Write($"{chars[i, j]}   ");
        }
        Console.Write("\n");
    }
}

Console.WriteLine("Podaj x: ");
int task11x = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj y: ");
int task11y = int.Parse(Console.ReadLine());
task11Fun(task11x, task11y);

// Zadanie 12
Console.WriteLine("\nZadanie 12");

static string evenOrOdd(int value)
{
    if (value % 2 == 0)
    {
        return "Even";
    }
     
    return "Odd";
}

Console.WriteLine("Podaj liczbę: ");
int task12 = int.Parse(Console.ReadLine());
Console.WriteLine($"Number {task12} is {evenOrOdd(task12)}");

// Zadanie 13
Console.WriteLine("\nZadanie 13");

static int getNumber()
{
    Console.WriteLine("Podaj liczbę: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

static char[,] setArrayChar(int x , int y)
{
    char[,] chars = new char[x, y];

    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            if(i == 0 || i == x - 1 || j == 0 || j == y - 1)
            {
                chars[i, j] = '#';
            }
            else
            {
                chars[i, j] = ' ';
            }
        }
    }

    return chars;
}

static void showArray(char[,] chars)
{
    for(int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            Console.Write(chars[i, j]);
        }
        Console.Write("\n");
    }
}

int task13n = getNumber();
int task13m = getNumber();

char[,] task13array = setArrayChar(task13n, task13m);
showArray(task13array);


// Zadanie 14
Console.WriteLine("\nZadanie 14");
Console.WriteLine("Podaj funkcje kwadratowa w kolejności:\n1. a\n2. b\n3. c");
static double getNumberFun()
{   
    double value = double.Parse(Console.ReadLine());
    return value;
}

static double deltaFun(double a, double b, double c)
{
    double res = Math.Pow(b,2) - 4*a*c;
    return res;
}

static void showSolution(double delta, double a, double b)
{
    if(delta < 0)
    {
        Console.WriteLine("Brak rozwiązań");
    }
    else if(delta == 0)
    {
        Console.WriteLine("Jedno rozwiązanie");
        Console.WriteLine($"X = {-b/(2*a)}");
    }
    else
    {
        Console.WriteLine("Dwa rozwiązania");
        Console.WriteLine($"X1 = {(-b-Math.Sqrt(delta))/ (2 * a)}");
        Console.WriteLine($"X2 = {(-b+Math.Sqrt(delta))/ (2 * a)}");
    }
}



double a = getNumberFun();
double b = getNumberFun();
double c = getNumberFun();

double delta = deltaFun(a, b, c);

showSolution(delta, a, b);