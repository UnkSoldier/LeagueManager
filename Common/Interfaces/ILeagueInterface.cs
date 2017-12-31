using System;
namespace LeagueManager.Common.Interfaces
{
    public interface ILeagueInterface
    {
        //void addTeamToLeague(Team teamToAdd);
        bool ReportGame(Team winningTeam, int winninfTeamScore, Team loosingTeam, int losingTeamScore);

    }
}
