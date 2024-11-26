using ConsoleApp1;

// Zadanie 1
double GetDistance(Coords[] coords)
{
    double distance = 0;
    for (int i = 1; i < coords.Length; i++)
    {
        distance += Math.Sqrt(Math.Pow(coords[i].X - coords[i - 1].X, 2) + Math.Pow(coords[i].Y - coords[i - 1].Y, 2));
    }

    return distance;
}


Coords p1 = new Coords(1.0, 1.0);
Coords p2 = new Coords(2.0, 2.0);
Coords p3 = new Coords(3.0, 3.0);
Coords p4 = new Coords(4.0, 4.0);
Coords p5 = new Coords(5.0, 5.0);

Coords[] points = { p1, p2, p3, p4, p5 };


Console.WriteLine($"Dystans: {GetDistance(points)}");

// Zadanie 2
static (int min, int max) GetMinAndMax(int[] args)
{
    return (args.Min(), args.Max());
}

int[] array = new int[20];
for (int i = 0; i < 20; i++)
{
    array[i] = i;
}

Console.WriteLine(GetMinAndMax(array));

// Zadanie 3
Person person1 = new Person();
person1.FirstName = "John";
person1.LastName = "Doe";
DateTime date = new DateTime(2004, 2, 26);
person1.BirthDate = date;
person1.EmailAddress = "gmail@gmail.com";
Console.WriteLine($"Person = {person1.FirstName} {person1.LastName}, Birth: {person1.BirthDate.ToString("dd.MM.yyyy")}, E-mail: {person1.EmailAddress} ");
Console.WriteLine($"Lat = {person1.GetAge()}");
Console.WriteLine($"Pełnoletni = {person1.IsAdult()}");


// Lab06
Person person2 = new Person() { FirstName = "John", LastName = "Doe" };
Person person3 = new Person() { FirstName = "Jane", LastName = "Doe", BirthDate = new DateTime(1999, 5, 11) };
Person person4 = new Person() { FirstName = "Jill", LastName = "Doe", BirthDate = new DateTime(2001, 2, 4), EmailAddress = "jill@gmail.com" };


Person child = Person.NewlyBornChild;
child.FirstName = "Brian";
child.LastName = "Doe";

Person person5 = null;
Console.WriteLine(person5.FirstName);
if (person5 is null)
{
    Console.WriteLine("Person is null");
}
else
{
    Console.WriteLine($"Name = {person5.GetFullName()}");
}
Console.WriteLine(person5 is null ? "Person is null" : $"Name = {person5.GetFullName()}");
Console.WriteLine((person5 ?? new Person("N", "N")).GetFullName());