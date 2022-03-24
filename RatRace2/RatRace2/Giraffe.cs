using System;

namespace RatRace2
{
    public class Giraffe
    {
        public string Name;
        private int _position;

        // GiraffeClass constructor, so that it is visible in RaceManager class
        public Giraffe(string name)
        {
            Name = name;
            _position = 0;
        }
        // Abstract class
        abstract class GiraffeSound
        {
            public abstract void animalSound();
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public void ResetGiraffe()
        {
            Name = "";
            _position = 0;
        }
        public int MoveGiraffe()    
        {
            _position = _position + RNG.Range(1, 1151);
            return _position;
        }

    }
}
