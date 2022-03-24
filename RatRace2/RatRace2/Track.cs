namespace RatRace2
{
    public class Track
    {
        public string Name;
        public int TrackLength;
        public bool Wind = false;

        public Track(string name, int trackLength)
        {
            Name = name;
            TrackLength = trackLength;
        }
        public Track(string name, int trackLength, bool wind)
        {
            Name = name;
            TrackLength = trackLength;
            Wind = wind;
        }
    }
}