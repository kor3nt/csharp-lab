using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            
            for(int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Kończę zadanie 1");
        }

        static void PrintTriangle(int h) 
        {
            string symbol = "$";
            for (int i = 0; i < h; i++)
            {
                for (int j = h; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(symbol);
                symbol += "$$";
            }
        }

        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

            // tutaj rozwiązanie zadania 3
            string finalText = "";

            if(today.Hour < 12)
            {
                finalText = "Dzień dobry, ";
            }
            else
            {
                finalText = "Dobry wieczór, ";
            }
            finalText += $"dzisiaj {today.DayOfWeek}, czyli {(int)today.DayOfWeek} dzień tygodnia";

            Console.WriteLine(finalText);

            Console.WriteLine("Kończę zadanie 3");
        }

        static double FindMaxAbsoluteValue(double[] args)
        {
            double max = 0;
            foreach(double x in args)
            {
                if(Math.Abs(x) > max) 
                    { max = x; }
            }
            return max;
        }

        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }


        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.

            Console.WriteLine("Rozpoczynam pętlę.");

            int number = 0;
            do
            {
                Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić. (0 - koniec)");
                try
                {
                    number = int.Parse(Console.ReadLine());

                    if (number == 1)
                    {
                        Zadanie_1();
                    }
                    else if (number == 2)
                    {
                        Zadanie_2();
                    }
                    else if (number == 3)
                    {
                        Zadanie_3();
                    }
                    else if (number == 4)
                    {
                        Zadanie_4();
                    }
                    else
                    {
                        Console.WriteLine("Nie ma takiego zadania, wybierz ponownie.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wartość nie jest cyfrą!");
                }
            }
            while (number != 0);
            

            Console.WriteLine("Kończę pętlę.");
        }

    }
}