using System;

namespace RatRace2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Rydere CMD så det ser pænere ud.
            Console.Clear();

            Console.WriteLine("\nDav Jacob! Klar til at se min smukke kode virke?! \nTryk enter hvis du er.");
            Console.ReadLine();
            Console.Clear();


            // Lavere racet.
            RaceManager rm = new RaceManager();


            Console.Clear();
            // For loopet tæller mængde af lavet race, og printer dem ud der er.
            Console.WriteLine("Hvilket race ville du bette på?");
            for (int i = 0; i < rm.Races.Count; i++)
            {
                Console.WriteLine(i + ") " + rm.Races[i].RaceTrack.Name);
            }
            
            // Beder brugeren om at vælge race.
            Race selectedRace = rm.Races[int.Parse(Console.ReadLine())];
            Console.Clear();
            
            // Viser alle de rats man kan bette på
            Console.WriteLine("Hvilke Rat ville du bette på?:");
            for (int i = 0; i < selectedRace.Rats.Count; i++)
            {
                Console.WriteLine(i + ") " +selectedRace.Rats[i].Name);
            }
           // Beder brugeren om at vælge hvilke rat de ville bette på.
            Console.Write("Jacob, Vælg din rat: ");
            Rat selectedRatP1 = selectedRace.Rats[int.Parse(Console.ReadLine())];

            Console.Write("\nOliver, Vælg din rat: ");
            Rat selectedRatP2 = selectedRace.Rats[int.Parse(Console.ReadLine())];

            // Skriv den mængde du ville bette på, din rat.
            Console.Clear();
            Console.WriteLine("Vælg Bet mængde Jacob:");
            int amountP1 = int.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("Vælg Bet mængde Oliver:");
            int amountP2 = int.Parse(Console.ReadLine());

            // Pladsere bet mængden.
            rm.BookMaker.PlaceBet(selectedRace, selectedRatP1, rm.Players[0], amountP1);
            rm.BookMaker.PlaceBet(selectedRace, selectedRatP2, rm.Players[1], amountP2);
            
            // Trækker den mængde de bettede fra "deres konto"
            rm.Players[0].Money -= amountP1;
            rm.Players[1].Money -= amountP2;

            // Printer deres mængde af penge de havde før racet.
            Console.Clear();
            Console.WriteLine("Jacob Mængde penge før racet. = " + rm.Players[0].Money);
            Console.WriteLine("Oliver Mængde penge før racet = " + rm.Players[1].Money);

            // Kører racet.
            Console.WriteLine("\n Race er skudt igang!");
            rm.ConductRace(rm.Races[0]);
            Console.WriteLine(rm.Races[0].GetRaceReport());
            Console.WriteLine("The winner is: " +  rm.Races[0].GetWinner().Name);
            
            // Hvis den rat player 1 havde valgt vinder, så gang deres bet med 2.
            if (selectedRatP1.Name == rm.Races[0].GetWinner().Name)
            {
                rm.Players[0].Money += (amountP1*2);
            }
            // Hvis den rat player 2 havde valgt vinder, så gang deres bet med 2.
            if (selectedRatP2.Name == rm.Races[0].GetWinner().Name)
            {
                rm.Players[1].Money += (amountP2 * 2);
            }

            // Viser playerens final bank status.
            Console.WriteLine("Jacob, mængde af penge efter racet = " + rm.Players[0].Money);
            Console.WriteLine("Oliver, mængde af penge efter racet = " + rm.Players[1].Money);

            Console.WriteLine("Yay! Det virkede!");
        }
    }
}
