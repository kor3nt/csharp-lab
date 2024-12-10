using ConsoleApp1;
using System;

Console.WriteLine("Zadanie 1 \n");
Messenger<Letter> messenger = new Messenger<Letter>();
messenger.Message = new Letter() { Content = "Message" };
messenger.Send();

Console.WriteLine("\nZadanie 2 \n");
IEnumerable<string> array = new[] { "Pomidor", "Ogorek", "Cebula", "Papryka" };

foreach (string i in array)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nZadanie 3 \n");

ICollection<string> arrayColl = new List<string>() { "Pomidor", "Ogorek", "Cebula", "Papryka" };
arrayColl.Remove("Ogorek");
arrayColl.Add("Ziemniak");


foreach (string i in arrayColl)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Does the collection contains 4? {arrayColl.Contains("Cebula")}");
Console.WriteLine($"Is the collection readonly? {arrayColl.IsReadOnly}");
Console.WriteLine($"Numbers of items in the collection: {arrayColl.Count}");
arrayColl.Clear();


List <Book> library = new List<Book>();


string input;
do
{
    Console.WriteLine("1. Dodaj książkę\n2. Wyświetl wszystkie książki\n3. Wyszukaj książki\nQ. Koniec");
    input = Console.ReadLine();

}
while (input != "Q" && input != "q");