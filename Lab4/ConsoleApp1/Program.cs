using ConsoleApp1;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //  Zadanie 1
            Console.WriteLine(QuadraticEquation(1, 4, 8, 4));

            //  Zadanie 2
            double x = 10;
            double y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            //  Zadanie 3
            Console.WriteLine(Multiply(1.0, 5.0));
            Console.WriteLine(Multiply(1.0, 5.0, 3.0));
            Console.WriteLine(Multiply(1.0, 2.0, 2.0, 2.0, 2.0));

            //  Zadanie 4
            PrintDayOfTheWeek(DayOfTheWeek.Saturday);

            //  Zadanie 5
            DateTime now = DateTime.Now;
            Console.WriteLine(ShowFullDate(now));

            //  Zadanie 6
            Console.WriteLine(Devide(5.0, 0.0));

            Console.WriteLine(SetYourNewPassword("123456789Ab!"));
        }

        //  Zadanie 1
        public static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
        {
            return a * x * x + b * x + c;
        }

        //  Zadanie 2
        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        //  Zadanie 3
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        public static double Multiply(params double[] list)
        {
            double result = 1;
            foreach (double x in list)
            {
                result += x;
            }
            return result;
        }

        //  Zadanie 4
        enum DayOfTheWeek : ushort
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void PrintDayOfTheWeek(DayOfTheWeek day)
        {
            Console.WriteLine($"{day} = {(int)day}");
            if ((int)day < 6)
            {
                Console.WriteLine("Praca :(");
            }
            else
            {
                Console.WriteLine("Wolne :)");
            }
        }

        //  Zadanie 5
        public static string ShowFullDate(DateTime date)
        {
            return $"{date.Day}.{date.Month}.{date.Year} {date.Hour}:{date.Minute}:{date.Second} {date.DayOfWeek}";
        }

        //  Zadanie 6
        public static double Devide(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                return 0.0;
            }
        }

        //  Zadanie 7
        public static string SetYourNewPassword(string password)
        {
            var upperCapsRegex = new Regex(@"[A-Z]");
            var lowerCapsRegex = new Regex(@"[a-z]");
            var specialCharsRegex = new Regex(@"\|!#%&/()=»«@£§€{}-;'<>_,");
            var numberRegex = new Regex(@"[0-9]");

            if (password == "")
            {
                throw new ArgumentException("Brak hasła");
            }

            if (password.Length < 10)
            {
                throw new FormatException("Minimalnie 10 znaków");
            }

            if (!upperCapsRegex.IsMatch(password))
            {
                throw new FormatException("Musi zawierać duża literę");
            }

            if (!lowerCapsRegex.IsMatch(password))
            {
                throw new FormatException("Musi zawierać mała literę");
            }

            if (!specialCharsRegex.IsMatch(password))
            {
                throw new FormatException("Musi zawierać znak specjalny");
            }

            if (!numberRegex.IsMatch(password))
            {
                throw new FormatException("Musi zawierać cyfrę");
            }


            return password;
        }
    }
}
