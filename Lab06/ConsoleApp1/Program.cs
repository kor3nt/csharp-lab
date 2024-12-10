using ConsoleApp1;
using System;

// Lab05, Lab06, Lab07
Person person1 = new Person();
person1.FirstName = "John";
person1.LastName = "Doe";
DateTime date = new DateTime(2004, 2, 26);
person1.BirthDate = date;
person1.EmailAddress = "gmail@gmail.com";
Console.WriteLine($"Person = {person1.FirstName} {person1.LastName}, Birth: {person1.BirthDate.ToString("dd.MM.yyyy")}, E-mail: {person1.EmailAddress} ");
Console.WriteLine($"Lat = {person1.GetAge()}");
Console.WriteLine($"Pełnoletni = {person1.IsAdult()}");

Person person2 = new Person();
person2.FirstName = "Anna";
person2.LastName = "Kowalska";
DateTime date2 = new DateTime(2004, 2, 26);
person2.BirthDate = date;
person2.EmailAddress = "gmail@gmail.com";

Person.Relate(person1, person2);
Console.WriteLine($"Związek: {person1.Partner.FirstName} i {person2.Partner.FirstName}");

//person1.Pet = new Animal() { species = "cat", name = "Puszek" };
//person1.AdoptAPet(new Animal() { species = "cat", name = "Puszek" });

//Animal pet1 = new Animal() { species = "dog", name = "Maksiu" };

person1.appearance = new Appearance() { EyesColor = "blue", HairColor = "brown", HasFreckles = false };

Animal animal = new Dog();
Console.WriteLine(animal.Sound);
animal.Move();
//animal.FetchBall();

Dog dog = new Dog();
Console.WriteLine(dog.Sound);
dog.Move();
dog.FetchBall();
dog.ProduceMilk();

dog.Walk();
dog.Swim();

IWalkable walkableDog = new Dog();
walkableDog.Walk();


Cat cat = new Cat();
Console.WriteLine(cat.Sound);
cat.Move();
cat.ThrowOfTheTable();

Salmon salmon = new Salmon();
salmon.Swim();

Animal[] animalArray = new Animal[] { new Dog(), new Cat(), new Salmon() };
foreach (Animal x in animalArray)
{
    if (x is Mammal)
    {
        (x as Mammal).ProduceMilk();
    }

    if (x is ISwimmable)
    {
        (x as ISwimmable).Swim();
    }
}