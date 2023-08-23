using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zufallszahlengenerator initialisieren
            Random random = new Random();

            // Würfeln
            int d4 = random.Next(1, 5); // Werte zwischen 1 und 4
            int d6 = random.Next(1, 7); // Werte zwischen 1 und 6
            int d8 = random.Next(1, 9); // Werte zwischen 1 und 8
            int d10 = random.Next(1, 11); // Werte zwischen 1 und 10
            int d12 = random.Next(1, 13); // Werte zwischen 1 und 12
            int d20 = random.Next(1, 21); // Werte zwischen 1 und 20

        }
    }
}using System;
