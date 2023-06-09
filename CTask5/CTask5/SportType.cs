using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTask5
{
    internal interface SportType
    {
        bool isContinues { get; }

        void startGame();

        void stopGame();
    }
}
