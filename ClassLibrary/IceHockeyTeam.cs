using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class IceHockeyTeam: Team
    {
        public IceHockeyTeam(string teamName):base(teamName)
        {
        }

        public override void Practice()
        {
            Console.WriteLine(TeamName + " gymmar.");
        }

        public void PickPucks()
        {
            Console.WriteLine("/nPlockar upp puckar från isen.");
        }
    }
}
