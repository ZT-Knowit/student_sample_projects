namespace ObjectOrientedProgramming
{
    using ClassLibrary;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar en instans av klassen MunicipalityTeams
            //Datatyp (MunicipalityTeams) -> variabelnamn (staarenTeams)  -> tilldelningsoperator (=) ->
            //instansieringsnyckelord (new) -> konstruktoranrop (MunicipalityTeams())
            MunicipalityTeams staarenTeams = new MunicipalityTeams();

            //Anropar metoden ListTeams på instansen staarenTeams
            staarenTeams.ListTeams();

            //Lägger till ett nytt lag i kommunen
            staarenTeams.AddTeam(new FootballTeam("IFK Östersund"));
            
            //Anropar metoden ListTeams på instansen staarenTeams igen
            staarenTeams.ListTeams();

            //Loopar igenom listan med lag och uppmanar dem att träna
            foreach (Team team in staarenTeams.Teams)
            {
                team.Practice();
            }
        }

    }
}
