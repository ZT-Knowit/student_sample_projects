using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FootballTeam: Team
    {
        public FootballTeam(string teamName):base(teamName)
        {
            
        }

        public void PumpTheBalls()
        {
            //Skriver ut en sträng istället för att
            //sätta igång något som pumpar bollarna
            Console.WriteLine("Pumpar bollarna.");
        }

        //Åsidosätter (override) metoden Practice i basklassen Team 
        //och implementerar en egen version av metoden
        public override void Practice()
        {
            Console.WriteLine(TeamName + " tränar skott.");
        }
    }
}
