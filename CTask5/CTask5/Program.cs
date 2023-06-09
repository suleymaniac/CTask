using CTask5;

internal class Program
{
    private static void Main(string[] args)
    {
        List<SportType> footballs = new List<SportType>()
        {
            new Football(20, 23),
            new Football(19, 21),
            new Football(20, 22),
            new Voleibol()
        };

        foreach(Football football in footballs) { 
            football.startGame();
            football.addPointsFirstTeam();
            football.addPointsFirstTeam();
            football.addPointsSecondTeam();

            football.stopGame();
            football.getWinner();
        }
    }

    class Voleibol : TeamSport
    {
        public bool isContinues => throw new NotImplementedException();

        public override void addPointsFirstTeam()
        {
            throw new NotImplementedException();
        }

        public override void addPointsSecondTeam()
        {
            throw new NotImplementedException();
        }

        public void startGame()
        {
            throw new NotImplementedException();
        }

        public void stopGame()
        {
            throw new NotImplementedException();
        }
    }
}