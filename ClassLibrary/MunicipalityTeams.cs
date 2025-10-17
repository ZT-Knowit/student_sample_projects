using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MunicipalityTeams
    {
        public List<Team> Teams = new List<Team>();

        public MunicipalityTeams()
        {
            //Skapar några befintliga lag i kommunen
            CreateExistingTeams();
        }

        private void CreateExistingTeams()
        {
            Team ÖBS = new BandyTeam("Östersunds bandysällskap");
            Team ÖFK = new FootballTeam("Östersunds FK");
            Team ÖIK = new IceHockeyTeam("Östersunds IK");
            //Skapar ett ishockeylag av klassen IceHockeyTeam
            //istället för av basklassen Team
            IceHockeyTeam BIK = new IceHockeyTeam("Brunflo IK");
            
            //Det går men rekommenderas inte att skapa objekt av basklassen Team
            //LÅT BLI: Team genericTeam = new Team("Generiskt lag");
            Team OpeIF = new Team("Ope IF");
            //Usch! Lägg inte till objekt av basklassen Team i listan över lag i kommunen!
            //Kan förhindras genom att göra basklassen abstrakt (abstract)

            Teams.Add(ÖBS);
            Teams.Add(ÖFK);
            Teams.Add(ÖIK);            
            Teams.Add(OpeIF); 
            Teams.Add(BIK);
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
            Console.WriteLine($"\n{team.TeamName} har lagts till i listan av lag i kommunen.");
        }

        public void ListTeams()
        {
            Console.WriteLine("\nLagen i kommunen är:");
            foreach (Team team in Teams)
            {
                Console.WriteLine($"- {team.TeamName}");
            }
            Console.WriteLine();
        }
    }
}
