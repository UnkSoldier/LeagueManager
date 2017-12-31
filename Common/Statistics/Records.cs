using System;

namespace LeagueManager.Common.Statistics.Records
{

    public class Records
    {
        //Variables
        protected int nbVictory;
        protected int nbLoss;
        protected int nbDraws;
        protected int nbGamesPlayed;


        public Records(Team team)
        {
            this.nbGamesPlayed = 0;
            this.nbVictory = 0;
            this.nbLoss = 0;
            this.nbDraws = 0;
        }

        public string ShowRecord()
        {
            return "test";   
        }


    }

}