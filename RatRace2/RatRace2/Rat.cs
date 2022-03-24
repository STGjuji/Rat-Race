namespace RatRace2
{
    public class Rat
    { 
        public string Name;
        private int _position;

        // RatClass constructor, so that it is visible in RaceManager class
        public Rat(string name)
        {
            Name = name;
            _position = 0;
        }
        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public void ResetRat()
        {
            Name = "";
            _position = 0;
        }
        public int MoveRat()
        {
            _position = _position + RNG.Range(1, 251);
            return _position;
        }

    }
}
