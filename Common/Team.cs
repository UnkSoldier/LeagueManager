using System;
using System.Collections.Generic;
using LeagueManager.Common.Statistics.Records;

namespace LeagueManager.Common
{
    public class Team
    {
        //Teammates
        Player m_first { get; }
        Player m_second { get; }
        Player m_third { get; }
        Player m_skip { get; }
        public List<Player> playersInTeam = new List<Player>();

        public Team(Player p_first, Player p_second, Player p_third, Player p_skip)
        {
            this.m_first = p_first;
            this.m_second = p_second;
            this.m_third = p_third;
            this.m_skip = p_skip;

            playersInTeam.Add(m_first);
            playersInTeam.Add(m_second);
            playersInTeam.Add(m_third);
            playersInTeam.Add(m_skip);
        }
    }
}
