using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace2
{
    internal class Bear
    {
        public string Name;
        private int _position;

        public Bear(string name)
        {
            Name = name;
            _position = 0;
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public void ResetBear()
        {
            Name = "";
            Position = 0;
        }

        public int MoveBear()
        {
            _position = _position + RNG.Range(1, 1088);
                return _position;
        }
    }
}
