namespace ClassLibrary
{
    public class Team
    {
        //Egenskaper
        public int NumberOfPlayers;
        public string TeamName = string.Empty;
        public string CoachName = string.Empty;
        public int NumberOfChampionships;

        //Konstruktor (speciell metod) som skapar en instans av klassen Team
        public Team(string teamName)
        {
            TeamName = teamName;
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
