/**********************************************************************************
    nazwa: Gambling
    opis: Funkcja wykorzystując liczby generowane losowo, obsługuje grę w kości

    parametry: brak
    
    zwracany typ i opis: brak
    autor: WIERZEJEJ

    *************************************************************************
    
    nazwa: Summing
    opis: Funkcja obsługuje sumowanie wyników rzutów kością, które wystąpiły więcej
            niż 2 razy

    parametry: brak
    zwracany typ i opis: {int} funkcja zwraca sumę wyników rzutów, które wystąpiły
                          więcej niż 2 razy
    autor: WIERZEJEJ
 **********************************************************************************/

using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace _19._09._2024
{
    public class Kostki
    {
        static List<int> tablica = new List<int>();
        public static void Gambling()
        {
            int value = 0;
            while (value < 3 || value > 10) {
                Console.WriteLine("Ile kostek chcesz rzucić?");
                value = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= value; i++)
            {
                Random rnd = new Random();
                int result = rnd.Next(1, 7);
                tablica.Add(result);
            }

            for (int i = 0;i < value; i++)
            {
                Console.WriteLine("Kostka " + i + ": "+ tablica[i] + "\n");
            }

            int suma = Summing();

            Console.WriteLine("Liczba uzyskanych punktów: " + suma);

            Console.WriteLine("Jeszcze raz? (n/t)");
            char decide = char.Parse(Console.ReadLine());
            if (decide == 't')
            {
                Gambling();
            } 
        }

        public static int Summing()
        {
            int summer = 0;
            for (int i = 0; i < tablica.Count; i++)
            {
                int helper = 0;
                for (int j = 0; j < tablica.Count; j++)
                {
                    if (tablica[i] == tablica[j])
                    {
                        helper++;
                    }
                }
                if (helper > 1)
                {
                    summer = summer + tablica[i];
                }
            }

            return summer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostki.Gambling();

        }
    }
}
