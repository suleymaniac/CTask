using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTask5
{
    internal class Football : TeamSport
    {
        public int numberPlayersFirstTeam;
        public int numberPlayersSecondTeam;
        public Football(int numberPlayersFirstTeam, int numberPlayersSecondTeam)
        {
            this.numberPlayersFirstTeam = numberPlayersFirstTeam;
            this.numberPlayersSecondTeam = numberPlayersSecondTeam;
        }

        public override void addPointsFirstTeam()
        {
            if (isContinues)
            {
                pointsFirstTeam++;
            } else
            {
                Console.WriteLine("Game not started");
            }
            
        }

        public override void addPointsSecondTeam()
        {
            if (isContinues)
            {
                pointsSecondTeam++;
            } else
            {
                Console.WriteLine("Game not started");
            }
            
        }

        public void getWinner()
        {
            if (isContinues)
            {
                Console.WriteLine("Game not finished");
            } else
            {
                if (pointsFirstTeam > pointsSecondTeam)
                {
                    Console.WriteLine("First team win");
                }
                else if (pointsFirstTeam < pointsSecondTeam)
                {
                    Console.WriteLine("Second team win");
                }
                else
                {
                    Console.WriteLine("Equals results");
                }
            }
            

        }
        public void takeRedCard()
        {
            numberPlayersFirstTeam--;
            numberPlayersSecondTeam--;
        }
    }
}
