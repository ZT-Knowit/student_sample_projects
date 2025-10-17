using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BandyTeam: Team
    {
        public string SkateSharpenerName;

        public BandyTeam(string teamName):base(teamName)
        {
            SkateSharpenerName = "Vakant roll";
        }

        public override void Practice()
        {
            Console.WriteLine(TeamName + " tränar skridskoåkning.");
        }
    }
}
