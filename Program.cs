using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace
{
    internal class Program
    {

    }
    public class BookMarker
    {
        public List<Bet> Bets;
        public Bet PlaceBet(Race race, Rat rat, Player player, int money)
        {
            return Bet;
        }
        public void PayOutWinnings(Bet bet)
        {

        }

    }

    internal class Player
    {
        public string Name;
        public int Money;
        public List<Bet> Bets;

    }
    public class Bet
    {
        private int Money;
        private Player _player;
        private Race _race;
        private Rat _rat;
        public void PayWinnings()
        {

        }

    }
    internal class Race
    {
        public int RaceID;
        public List<Rat> Rats;
        public Track RaceTrack;
        private Rat _winner;
        private string _log;
        public void ConductRace()
        {

        }
        public Rat GetWinner()
        {

        }
        public string GetRaceReport()
        {

        }
        private void LogRace()
        {

        }

    }
    public class Track
    {
        public string Name;
        public int TrackLength;

    }
    public class Rat
    {
        public string Name;
        private int _position;
        public int Position { get; set; }

        public void ResetRat()
        {

        }
        public int MoveRat()
        {
            return _position;
        }

    }

    internal class RNG
    {
        private Random _rng;
        public int Range(int upper, int lower)
        {

        }
    }
    internal class raceManager
    {
        public List<Track> Tracks;
        public List<Player> Players;
        public List<Race> Races;
        public List<Rat> Rats;
        public Race CreateRace(int Raceid, List<Rat> rats, Track track)
        {

        }
        public Track CreateTrack(string name, int tracklength)
        {

        }
        public void ConductRace(Race race)
        {

        }
        public Rat CreateRat(string name)
        {

        }
        public Player CreatePlayer(string name, int money)
        {

        }

    }
}