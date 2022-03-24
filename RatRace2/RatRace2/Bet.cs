namespace RatRace2
{
    public class Bet
    {
        private int Money;
        private Player _player;
        private Race _race;
        private Rat _rat;

        public Bet(int money, Player player, Race race, Rat rat)
        {
            Money = money;
            _player = player;
            _race = race;
            _rat = rat;
        }

        public void PayWinnings()
        {
            //TODO: - hvordan skal paywinnings tages i brug?
        }

    }
}
