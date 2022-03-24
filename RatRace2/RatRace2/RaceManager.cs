using System.Collections.Generic;

namespace RatRace2
{
    internal class RaceManager
    {
        public List<Track> Tracks;
        public List<Player> Players;
        public List<Race> Races;
        public List<Rat> Rats;
        public BookMaker BookMaker = new BookMaker();
        public enum TrackSize 
        {
            Short_Track = 1000,
        }
        public RaceManager()
        {
            Tracks = new List<Track>(); 
            Players = new List<Player>(); 
            Races = new List<Race>();  
            Rats = new List<Rat>();
            // Lavere de 2 rats man kan vælge imellem
            CreateRat("Hamilton");
            CreateRat("Riccardo");

            // Laver tracket "Short Track"
         Track myTrack = CreateTrack("SilverStone", (int) TrackSize.Short_Track, true);
           
            // Laver racet
            CreateRace(1, Rats, Tracks[0]);
            CreatePlayer("Player 1", 200);
            CreatePlayer("Player 2", 200);
        }
        
            // Laver track instance
        public Track CreateTrack(string name, int tracklength, bool wind)
        {
            Track track = new Track(name,tracklength,wind);
            //Track track2 = new Track
            Tracks.Add(track);
            return track;
            

        }
        
        // Laver "create player" function
        public Player CreatePlayer(string name, int money)
        {
            Player player = new Player(name,money);
            Players.Add(player);
            return player;
        }

        // Laver "create rat" function
        public Rat CreateRat(string name)
        {
            Rat rat = new Rat(name);
            Rats.Add(rat);
            return rat;
        }

        // Laver "crate race" function
        public Race CreateRace(int RaceID, List<Rat> rats, Track track) 
        {
            Race race = new Race(RaceID, rats, track);
            Races.Add(race);
            return race;
        }

        public void ConductRace(Race race)
        { 
            race.ConductRace();
        }
        

        
        


    }
}
