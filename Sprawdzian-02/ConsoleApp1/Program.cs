using ConsoleApp1;

//Zadanie 1
Point3d point1 = new Point3d(1.5, 5.75, -7.0);
Console.WriteLine(point1.GetDistanceFromOrigin());

//Zadanie 2
Adult person1 = new Adult();
person1.Name = "John";

Adult person2 = new Adult();
person2.Name = "Jane";

Child child1 = new Child();
child1.Name = "Kevin";
child1.Father = person1;
child1.Mother = person2;

Child child2 = new Child();
child2.Name = "Mike";
child2.Father = person1;
child2.Mother = person2;

Child child3 = new Child();
child3.Name = "Wendy";
child3.Father = person1;
child3.Mother = person2;

Child[] children = { child1, child2, child3 };

person1.Children = children;
person2.Children = children;

Console.Write($"Dorośli {person1.Name} i {person2.Name} mają {children.Length} dzieci:");
for (int i = 0; i < children.Length; i++)
{
    Console.Write( $" {children[i].Name}" );
}
Console.WriteLine();


//Zadanie 3
Adult humanAdult = new Adult();
Console.WriteLine(humanAdult.EatSnack());
// should return "Cake."

Child childAdult = new Child();
Console.WriteLine(childAdult.EatSnack());
// should return "Ice cream!"

//Zadanie 4
Human[] humans = { new Adult(), new Child() };
foreach (var h in humans)
{
    if (h is ISinger)
    {
        Console.WriteLine((h as ISinger).Sing());
    }
}

//Zadanie 5 ???


//Zadanie 6
Book book1 =  new Book("Ulysses", "James Joyce", 1922);
Book book2 = new Book("Lolita", "Vladimir Nabokov", 1955);
Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
Book book4 = new Book("In Search of Lost Time", "Marcel Proust", 1913);

List<Book> books = new List<Book>();
books.Add(book1);
books.Add(book2);
books.Add(book3);
books.Add(book4);

var authors = books.Select(book => book.Author).OrderBy(author => author);
foreach (var author in authors)
{
    Console.WriteLine(author);
}

books.Add(new Book("Lalka", "Bolesław Prus", 1980));


var oldBook = books.Where(book => DateTime.Now.Year - book.YearPublished > 100);
foreach (var old in oldBook)
{
    Console.WriteLine(old.Title);
}


var theOldestBook = books.OrderBy(book => book.YearPublished).FirstOrDefault();
if(theOldestBook != null)
{
    books.Remove(theOldestBook);
}

foreach (var book in books)
{
    Console.WriteLine($"{book.Title} {book.Author} {book.YearPublished}");
}