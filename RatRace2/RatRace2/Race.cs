using System.Collections.Generic;

namespace RatRace2
{
    public class Race
    {
        public int RaceID;
        public List<Rat> Rats;
        public Track RaceTrack;
        private Rat _winner;
        private string _log;

        public Race(int raceID, List<Rat> rats, Track raceTrack)
        {
            RaceID = raceID;
            Rats = rats;
            RaceTrack = raceTrack;
        }

        public void ConductRace()
        {
            bool go = true;
            while (go)
            {
                // Rykker 
                // Move rats and their position + check for the winning rat
                for (int i = 0; i < Rats.Count; i++)
                {

                    // Move each rat randomly by a number between 1-25, untill one of the rats reach the end or beond the track, then the loop will break.
                    Rats[i].MoveRat();
                    if (Rats[i].Position >= RaceTrack.TrackLength)
                    {
                        // Winner has been found and exits loop.
                        _winner = Rats[i];
                        go = false;
                        // Log-entry. This tells about the current state of the rats in the race.
                        _log += Rats[i].Name + " Har rykket til position " + Rats[i].Position + " Ud af " + RaceTrack.TrackLength + "\n";
                        break;
                    }
                    else
                    {
                        // Log-entry. This tells about the current state of the rats in the race.
                        _log += Rats[i].Name + " Har rykket til position " + Rats[i].Position + " Ud af " + RaceTrack.TrackLength + "\n";
                    }
                    
                }
                
            }
        }
        public Rat GetWinner()
        {
           
            return _winner;
        }
        public string GetRaceReport()
        {
           // TODO: Write a winning text
            return _log;
        }
        private void LogRace()
        {

        }

    }
}
