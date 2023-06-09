using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTask5
{
    internal abstract class TeamSport : SportType
    {
        public bool isContinues { get; set; }

        public int pointsFirstTeam = 0;
        public int pointsSecondTeam = 0;

        public void startGame()
        {
            isContinues = true;
        }

        public void stopGame()
        {
            isContinues = false;
        }

        public abstract void addPointsFirstTeam();

        public abstract void addPointsSecondTeam();
    }
}
