using System;
using LeagueManager.Common;
using LeagueManager.Common.Interfaces;
using LeagueManager.Common.Statistics;
using System.Collections.Generic;
using LeagueManager.Common.Statistics.Records;

namespace LeagueManager.Common
{
    public class League : ILeagueInterface
    {

        //static items
        public static List<Player> playersOfTheLeague = new List<Player>();
        public static List<Team> teamSubscribedList = new List<Team>();
        protected static List<Team> listOfTeams = new List<Team>();

        //variables
        public string m_leagueName;
        public string m_gameDay;
        public string m_gameTime;
        public string m_responsible;
        public string m_email;

        public League(string p_leagueName, string p_gameDay, string p_gameTime, string p_responsible, string p_email)
        {
            this.m_leagueName = p_leagueName;
            this.m_gameDay = p_gameDay;
            this.m_gameTime = p_gameTime;
            this.m_responsible = p_responsible;
            this.m_email = p_email;
        }

        private void AddTeamToLeague(Team teamToAdd)
        {
            if (teamSubscribedList.Contains(teamToAdd) && !listOfTeams.Contains(teamToAdd))
            {
                listOfTeams.Add(teamToAdd);
                teamSubscribedList.Remove(teamToAdd);
            }
            else
            {
                if (!teamSubscribedList.Contains(teamToAdd))
                {
                    throw new InvalidOperationException("The team has not subscribed to this league.");
                }
                else
                {
                    throw new InvalidOperationException("The team has already subscribed to this league.");
                }
            }
        }


        public bool ReportGame(Team winningTeam, int winninfTeamScore, Team loosingTeam, int losingTeamScore)
        {
            throw new NotImplementedException();
        }
    }
}
