/* Zadanie 1 */
Console.WriteLine("Zmienne i typy danych \nZadanie 1");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";

/* Rozwiązanie - Zadanie 1 */
Console.WriteLine($"Byte: {byteVariable}");
Console.WriteLine($"Int: {integralVariable}");
Console.WriteLine($"Long: {longVariable}");
Console.WriteLine($"Char - ASCII: {charVariable1}");
Console.WriteLine($"Char - znak: {charVariable2}");
Console.WriteLine($"Duoble: {doubleVariable}");
Console.WriteLine($"Float: {floatVariable}");
Console.WriteLine($"String: {stringVariable} \n");

/* Przykład 1 */
Console.WriteLine("Przykład 1");
// Konwersja niejawna
int x = 100;
long bigX = x;
System.Console.WriteLine($"Int -> long: {bigX}");

// Konwersja jawna
double doubleX = 1234.7;
int intX;
intX = (int)doubleX;
System.Console.WriteLine($"Duoble -> int: {intX} \n");


/* Zadanie 2 */
Console.WriteLine("Zadanie 2");
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
long ex2Long = num;

// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
int ex2Int = (int)bigNum;

// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
int ex2Int2 = int.Parse(stringNum);

// zbadaj zachowanie programu
Console.WriteLine($"Int -> Long: {byteVariable}");
Console.WriteLine($"Long -> Int: {integralVariable}");
Console.WriteLine($"String -> Int: {longVariable} \n");

/* Zadanie 3 */
Console.WriteLine("Zadanie 3");
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;

// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
int c = a + b;

// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
int d = a - b;

// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
int e = a * b;

// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
int f = a / b;

// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
int g = a % b;

// wypisz na ekran c,d,e,f,g
Console.WriteLine($"Dodawanie: {c} \nOdejmowanie: {d} \nMnożenie: {e} \nDzielenie: {f} \nReszta dzielenia: {g}");

// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
Console.WriteLine($"Mnożenie \"price\" samej przez siebie: {price * price}");

// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
Console.WriteLine($"Mnożenie \"doubleVal\" samej przez siebie: {doubleVal * doubleVal}");

// zastanów się skąd się bieże różnica
// Odp. Double - naukowe, decimal - ekonomiczne (np. pieniadze)

// wypisz na ekran wynik pola koła o promieniu równym radius (P = pi*r^2)
Console.WriteLine($"Pola koła = {Math.PI * ((int)radius ^ 2)}");

// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
Console.WriteLine($"Godzin: {(int)time / 60}");
Console.WriteLine($"Minut: {(int)time}");
Console.WriteLine($"Sekund: {time * 60}\n");

/* Zadanie 4 */
Console.WriteLine("Zadanie 4");
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement += toIncrement;

// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;

Console.WriteLine($"toIncrement - powiększona: {toDivide}");
Console.WriteLine($"toDivide - podzielona: {toIncrement}\n");

/* Zadanie 5 */
Console.WriteLine("Zadanie 5");
double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
sinValue = Math.Sin(degree);
Console.WriteLine($"sinValue = sinus(degree): {sinValue}\n");

/* Zadanie 6 */
Console.WriteLine("Zadanie 6");
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
DateTime date = new DateTime(year, month, day, hour, minute, 0);
Console.WriteLine($"Data: {date}");

// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
date = date.AddMonths(3);
date = date.AddHours(-1);
Console.WriteLine($"Data (+3 mies, -1 godz): {date}");

// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
Console.WriteLine($"Dzień tygodnia: {date.DayOfWeek}\n");


/* Zadanie 7 */
Console.WriteLine("Zadanie 7");
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";

// stwórz nową zmienną typu string jako złączenie powyższych.
// pamiętaj o brakujących odstępach
string fourthPart = firstPart + " " + secondPart + " " + thirdPart;

// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
Console.WriteLine($"Drukowanymi: {fourthPart.ToUpper()}");

// oraz liczbę przedstawiającą długość tego ciągu znaków
Console.WriteLine($"Długość ciągu znaków: {fourthPart.Length}\n");

/* Zadanie 8 */
Console.WriteLine("Zadanie 8");
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool isTriangle = (lengthB + lengthC) > lengthA;
Console.WriteLine($"Czy trójkąt? {isTriangle}");

// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
if (isTriangle)
{
    bool isRightTriangle = (lengthC * lengthC + lengthA * lengthA) == lengthB * lengthB;
    Console.WriteLine($"Czy prostokątny? {isRightTriangle}");
}


/* Zadanie 9 */
Console.WriteLine("\nZadanie 9");
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if(conditionalString.Length > 10)
{
    Console.WriteLine(conditionalString);
}

/* zadanie 10 */
Console.WriteLine("\nZadanie 10");
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if(temperature > 20)
{
    Console.WriteLine("Ciepło");
}
else
{
    Console.WriteLine("Zimno");
}

/* zadanie 11 */
Console.WriteLine("\nZadanie 11");
Console.WriteLine($"{(temperature > 20 ? "Ciepło" : "Zimno")}");

/* zadanie 12 */
Console.WriteLine("\nZadanie 12");
int code = 16;
int quantity = 99;
decimal productPrice = 3.5m;
decimal sellPrice;

if(code < 10)
{
    sellPrice = productPrice;
}
else if(code <= 15)
{
    sellPrice = (decimal)0.95*productPrice;
}
else
{
    if(quantity < 10)
    {
        sellPrice = (decimal)1.05*productPrice;
    }
    else if(quantity < 20)
    {
        sellPrice = productPrice;
    }
    else if(quantity < 100)
    {
        int res = quantity / 10;
        sellPrice = (100-res)/100*productPrice;
    }
    else
    {
        sellPrice = (decimal)0.90*productPrice;
    }
}

Console.WriteLine($"Price: {sellPrice}");


/* zadanie 13 */
Console.WriteLine("\nZadanie 13");
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;

    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;

    case '2':
        Console.WriteLine($"Decimal number: 2");
        break;

    case '3':
        Console.WriteLine($"Decimal number: 3");
        break;

    case '4':
        Console.WriteLine($"Decimal number: 4");
        break;

    case '5':
        Console.WriteLine($"Decimal number: 5");
        break;

    case '6':
        Console.WriteLine($"Decimal number: 6");
        break;

    case '7':
        Console.WriteLine($"Decimal number: 7");
        break;

    case '8':
        Console.WriteLine($"Decimal number: 8");
        break;

    case '9':
        Console.WriteLine($"Decimal number: 9");
        break;

    case 'A':
        Console.WriteLine($"Decimal number: 10");
        break;

    case 'B':
        Console.WriteLine($"Decimal number: 11");
        break;

    case 'C':
        Console.WriteLine($"Decimal number: 12");
        break;

    case 'D':
        Console.WriteLine($"Decimal number: 13");
        break;

    case 'E':
        Console.WriteLine($"Decimal number: 14");
        break;

    case 'F':
        Console.WriteLine($"Decimal number: 15");
        break;

    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}