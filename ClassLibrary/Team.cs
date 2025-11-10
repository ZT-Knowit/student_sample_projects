namespace ClassLibrary
{
    public class Team
    {
        //Privata fält för klassen Team
        private int _numberOfPlayers;
        private string _teamName = string.Empty;
        private int _numberOfChampionships;

        //Property som kapsar in fältet _numberOfPlayers
        public int NumberOfPlayers { get => _numberOfPlayers; set => _numberOfPlayers = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }
        public Coach TeamCoach;
        public int NumberOfChampionships { get => _numberOfChampionships; set => _numberOfChampionships = value; }

        //Konstruktor (speciell metod) som skapar en instans av klassen Team
        public Team(string teamName, Gender coachGender, string coachName, DateTime birthDate)
        {
            TeamCoach = new Coach(coachGender, coachName, birthDate);
            _teamName = teamName;
        }

        public Team(string teamName, Coach coach)
        {
            TeamCoach = coach;
            _teamName = teamName;
        }

        //Virtual talar om att metoden kan
        //åsidosättas (skrivas över) i en subklass
        public virtual void Practice()
        {
            //Skriver ut lagnamnet och vilken träningsaktivitet som pågår
            Console.WriteLine($"{TeamName} tränar hopp och studs.");
        }

    }
}
